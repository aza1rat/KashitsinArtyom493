using OOO_Aromatny_Mir.Classes;
using OOO_Aromatny_Mir.Entities;
using OOO_Aromatny_Mir.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Aromatny_Mir
{
    public partial class FormCatalogue : Form
    {
        private List<Entities.Product> products;
        public FormCatalogue()
        {
            InitializeComponent();
        }

        private void FormCatalogue_Load(object sender, EventArgs e)
        {
            if (Helper.CurrentUser is null)
                LabelUser.Text = "";
            else
                LabelUser.Text = Helper.CurrentUser.UserSurname + "\n" +
                    Helper.CurrentUser.UserName + "\n" +
                    Helper.CurrentUser.UserPatronymic;
            if (Helper.CurrentUser is null || Helper.CurrentUserRole != Helper.UserRole.Администратор)
            {
                ButtonAddNewProduct.Enabled = false;
                ButtonAddNewProduct.Visible = false;
            }
            else
            {
                ButtonAddNewProduct.Enabled = true;
                ButtonAddNewProduct.Visible = true;
            }
            ComboBoxCategory.Items.Clear();
            ComboBoxCategory.Items.Add("Все категории");
            foreach (Entities.Category category in Helper.ModelDB.Category)
            {
                ComboBoxCategory.Items.Add(category.CategoryName);
            }
            ComboBoxCost.SelectedIndex = 0;
            ComboBoxCategory.SelectedIndex = 0;
            ComboBoxDiscount.SelectedIndex = 0;
        }

        private bool IsHaveLetter(string str, string letters)
        {
            if (String.IsNullOrEmpty(str))
                return true;
            return str.Contains(letters);
        }

        private int GetCategoryID(string value)
        {
            var category = Helper.ModelDB.Category.Where(c => c.CategoryName == value).First();
            return category.CategoryID;
        }

        private void UpdateGrid()
        {
            DGVCatalogue.Rows.Clear();
            foreach (Entities.Product product in products)
            {
                if (!(IsHaveLetter(product.ProductName, TextBoxSearch.Text)))
                    continue;
                int viewID = DGVCatalogue.Rows.Add();
                DGVCatalogue.Rows[viewID].Height = 150;
                if (product.ProductPhoto != null)
                {
                    MemoryStream ms = new MemoryStream(product.ProductPhoto);
                    Bitmap bitmap = (Bitmap)Image.FromStream(ms);
                    DGVCatalogue.Rows[viewID].Cells[0].Value = bitmap;
                }
                else
                    DGVCatalogue.Rows[viewID].Cells[0].Value = (Bitmap)Resources.picture;
                DGVCatalogue.Rows[viewID].Cells[0].Tag = product.ProductArticle;
                DGVCatalogue.Rows[viewID].Cells[1].Value += "Наименование товара: " + product.ProductName +
                    Environment.NewLine + "Описание: " + Environment.NewLine + product.ProductDescription +
                    Environment.NewLine + "Производитель: " + product.Manufacturer.ManufacturerName +
                    Environment.NewLine + "Цена: " + product.ProductCost;
                if (product.ProductDiscount != null || product.ProductDiscount > 0)
                {
                    DGVCatalogue.Rows[viewID].Cells[1].Value += Environment.NewLine + "Стоимость со скидкой: " +
                    ((double)product.ProductCost - ((double)product.ProductCost *
                    ((double)product.ProductDiscount / 100)));
                    DGVCatalogue.Rows[viewID].Cells[2].Value = "Скидка: " + product.ProductDiscount + "%";
                }
                if (product.ProductDiscount > 15)
                    DGVCatalogue.Rows[viewID].DefaultCellStyle.BackColor = Color.FromArgb(204, 102, 0);
            }
            LabelProductCount.Text = $"Показано {DGVCatalogue.RowCount} из {Helper.ModelDB.Product.Count()}";
        }

        private void GetFromDB()
        {
            if (ComboBoxCategory.SelectedItem is null || ComboBoxCost.SelectedItem == null || ComboBoxDiscount.SelectedItem == null)
                return;
            string sqlCommand = "SELECT * FROM Product WHERE ";
            if (ComboBoxCategory.SelectedItem.ToString() != "Все категории")
                sqlCommand += "ProductCategory = " + GetCategoryID(ComboBoxCategory.SelectedItem.ToString()) + " AND ";
            switch (ComboBoxDiscount.SelectedItem.ToString())
            {
                case "0-10%": sqlCommand += "ProductDiscount <= 10 "; break;
                case "11-14%": sqlCommand += "ProductDiscount > 10 AND ProductDiscount <= 14 "; break;
                case "15% и более": sqlCommand += "ProductDiscount > 14 "; break;
                default:
                    if (ComboBoxCategory.SelectedItem.ToString() != "Все категории")
                        sqlCommand = sqlCommand.Substring(0, sqlCommand.Length - 4);
                    else
                        sqlCommand = sqlCommand.Substring(0, sqlCommand.Length - 6);
                    break;
            }
            switch (ComboBoxCost.SelectedItem.ToString())
            {
                case "Возрастает": sqlCommand += "ORDER BY ProductCost ASC"; break;
                case "Убывает": sqlCommand += "ORDER BY ProductCost DESC"; break;
            }
            products = Helper.ModelDB.Product.SqlQuery(sqlCommand).ToList();
            UpdateGrid();
        }

        private void ComboBoxCost_SelectedValueChanged(object sender, EventArgs e)
        {
            GetFromDB();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GetFromDB();
        }

        private void ButtonCatalogueExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
