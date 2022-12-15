using OOO_Aromatny_Mir.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOO_Aromatny_Mir.Entities;
using OOO_Aromatny_Mir.Properties;
using System.IO;

namespace OOO_Aromatny_Mir
{
    public partial class FormChangeProduct : Form
    {
        private Product selectedProduct;
        public FormChangeProduct()
        {
            InitializeComponent();
            GetStatementsFromDB();
            PictureBoxProduct.Image = Resources.picture;
        }

        public FormChangeProduct(string article)
        {
            InitializeComponent();
            TextBoxArticle.Enabled = false;
            GetStatementsFromDB();
            selectedProduct = Helper.ModelDB.Product.Where(product => product.ProductArticle == article).First();
            TextBoxArticle.Text = selectedProduct.ProductArticle;
            TextBoxName.Text = selectedProduct.ProductName;
            TextBoxCost.Text = selectedProduct.ProductCost.ToString();
            TextBoxDiscount.Text = selectedProduct.ProductDiscount.ToString();
            TextBoxMaxDiscount.Text = selectedProduct.ProductMaxDiscount.ToString();
            TextBoxInStock.Text = selectedProduct.ProductQuantity.ToString();
            TextBoxDescription.Text = selectedProduct.ProductDescription;
            ComboBoxCategory.SelectedItem = Helper.ModelDB.Category.Where(item =>
            item.CategoryID == selectedProduct.ProductCategory).First();
            ComboBoxManufacturer.SelectedItem = Helper.ModelDB.Manufacturer.Where(item =>
            item.ManufacturerID == selectedProduct.ProductManufacturer).First();
            ComboBoxProvider.SelectedItem = Helper.ModelDB.Provider.Where(item =>
            item.ProviderID == selectedProduct.ProductProvider).First();
            ComboBoxUnit.SelectedItem = Helper.ModelDB.Unit.Where(item =>
            item.UnitID == selectedProduct.ProductUnit).First();
            if (selectedProduct.ProductPhoto != null)
            {
                MemoryStream ms = new MemoryStream(selectedProduct.ProductPhoto);
                Bitmap bitmap = (Bitmap)Image.FromStream(ms);
                PictureBoxProduct.Image = bitmap;
            }
            else
                PictureBoxProduct.Image = (Bitmap)Resources.picture;
        }

        private void ButtonProductBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void GetStatementsFromDB()
        {
            ComboBoxCategory.DataSource = Helper.ModelDB.Category.ToList();
            ComboBoxCategory.DisplayMember = "CategoryName";
            ComboBoxCategory.ValueMember = "CategoryID";
            ComboBoxCategory.SelectedIndex = 0;
            ComboBoxProvider.DataSource = Helper.ModelDB.Provider.ToList();
            ComboBoxProvider.DisplayMember = "ProviderName";
            ComboBoxProvider.ValueMember = "ProviderID";
            ComboBoxProvider.SelectedIndex = 0;
            ComboBoxManufacturer.DataSource = Helper.ModelDB.Manufacturer.ToList();
            ComboBoxManufacturer.DisplayMember = "ManufacturerName";
            ComboBoxManufacturer.ValueMember = "ManufacturerID";
            ComboBoxManufacturer.SelectedIndex = 0;
            ComboBoxUnit.DataSource = Helper.ModelDB.Unit.ToList();
            ComboBoxUnit.DisplayMember = "UnitName";
            ComboBoxUnit.ValueMember = "UnitID";
            ComboBoxUnit.SelectedIndex = 0;
        }

        private Product CheckValidate()
        {
            Product changeProduct = new Product();
            int discount = -1;
            int maxDiscount = -1;
            if (String.IsNullOrEmpty(TextBoxArticle.Text))
            {
                MessageBox.Show("Введите артикль", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
                
            if (String.IsNullOrEmpty(TextBoxName.Text))
            {
                MessageBox.Show("Введите название товара", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (String.IsNullOrEmpty(TextBoxCost.Text))
            {
                MessageBox.Show("Введите стоимость товара", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (String.IsNullOrEmpty(TextBoxInStock.Text))
            {
                MessageBox.Show("Введите количество товара на складе", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (String.IsNullOrEmpty(TextBoxDescription.Text))
            {
                MessageBox.Show("Введите описание для товара", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (String.IsNullOrEmpty(TextBoxDiscount.Text))
                discount = 0;
            if (String.IsNullOrEmpty(TextBoxMaxDiscount.Text))
                maxDiscount = 0;
            try
            {
                changeProduct.ProductArticle = TextBoxArticle.Text;
                changeProduct.ProductDescription = TextBoxDescription.Text;
                changeProduct.ProductName = TextBoxName.Text;
                Category category = (Category)ComboBoxCategory.SelectedItem;
                changeProduct.ProductCategory = category.CategoryID;
                Manufacturer manufacturer = (Manufacturer)ComboBoxManufacturer.SelectedItem;
                changeProduct.ProductManufacturer = manufacturer.ManufacturerID;
                Provider provider = (Provider)ComboBoxProvider.SelectedItem;
                changeProduct.ProductProvider = provider.ProviderID;
                Unit unit = (Unit)ComboBoxUnit.SelectedItem;
                changeProduct.ProductUnit = unit.UnitID;

                double cost = Convert.ToDouble(TextBoxCost.Text);
                if (cost <= 0)
                {
                    MessageBox.Show("Стоимость должна быть больше 0", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }    
                int dotCost = TextBoxCost.Text.IndexOf(',');
                if (dotCost != -1 && TextBoxCost.Text.Length - dotCost - 1 > 2)
                {
                    MessageBox.Show("Допустимо 2 числа после запятой у стоимости товара", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                changeProduct.ProductCost = (decimal)cost;
                if (discount != 0)
                {
                    discount = Convert.ToInt32(TextBoxDiscount.Text);
                    if (discount < 0 || discount >= 100)
                    {
                        MessageBox.Show("Величина скидки должна быть в пределах 0-100%", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    changeProduct.ProductDiscount = discount;
                }
                if (maxDiscount != 0)
                {
                    maxDiscount = Convert.ToInt32(TextBoxMaxDiscount.Text);
                    if (maxDiscount < 0 || maxDiscount >= 100)
                    {
                        MessageBox.Show("Величина максимальной скидки должна быть в пределах 0-100%", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    changeProduct.ProductMaxDiscount = maxDiscount;
                }
                int quantity = Convert.ToInt32(TextBoxInStock.Text);
                if (quantity < 0)
                {
                    MessageBox.Show("Количество товара на складе может быть 0 или более", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                changeProduct.ProductQuantity = quantity;
                if (discount > maxDiscount)
                {
                    MessageBox.Show("Количество товара на складе может быть 0 или более", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                    
            }
            catch
            {
                MessageBox.Show("Проверьте правильно ли выбраны элементы из выпадающих списков. Правильно ли введены значения числовых полей", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (PictureBoxProduct.Image != Resources.picture)
            {
                MemoryStream ms = new MemoryStream();
                PictureBoxProduct.Image.Save(ms, PictureBoxProduct.Image.RawFormat);
                changeProduct.ProductPhoto = ms.ToArray();
            }
            return changeProduct;
        }

        private void ButtonChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string file = dlg.FileName;
                PictureBoxProduct.Image = Image.FromFile(file);
            }
        }

        private void ButtonDefaultImage_Click(object sender, EventArgs e)
        {
            PictureBoxProduct.Image = Resources.picture;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            Product product = CheckValidate();
            if (product == null)
                return;

            try
            {
                Helper.ModelDB.Product.Add(product);
                Helper.ModelDB.SaveChanges();
                MessageBox.Show("Добавлен новый товар", "Добавление товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Добавление товара отменено. Проверьте, что в базе не существует товар с указанным артиклем", "Добавление товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ButtonChangeProduct_Click(object sender, EventArgs e)
        {
            Product product = CheckValidate();
            if (product == null)
                return;
            try
            {
                Helper.ModelDB.Entry(selectedProduct).CurrentValues.SetValues(product);
                Helper.ModelDB.SaveChanges();
                MessageBox.Show("Изменен текущий товар", "Изменение товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Изменения не сохранились", "Изменение товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            Product product = CheckValidate();
            if (product == null)
                return;
            try
            {
                Helper.ModelDB.Product.Remove(product);
                Helper.ModelDB.SaveChanges();
                MessageBox.Show("Удален текущий товар", "Удаление товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Удаление товара отменено", "Удаление товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
