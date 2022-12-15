namespace OOO_Aromatny_Mir
{
    partial class FormCatalogue
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalogue));
            this.TablePanelTempUpper = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LabelTempNameForm = new System.Windows.Forms.Label();
            this.ButtonCatalogueExit = new System.Windows.Forms.Button();
            this.LabelUser = new System.Windows.Forms.Label();
            this.TablePanelTempDown = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonAddNewProduct = new System.Windows.Forms.Button();
            this.TablePanelCatalogueMain = new System.Windows.Forms.TableLayoutPanel();
            this.LabelProductCount = new System.Windows.Forms.Label();
            this.TablePanelCatalogueSort = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxCost = new System.Windows.Forms.ComboBox();
            this.ComboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.DGVCatalogue = new System.Windows.Forms.DataGridView();
            this.ColumnPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablePanelTempUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.TablePanelTempDown.SuspendLayout();
            this.TablePanelCatalogueMain.SuspendLayout();
            this.TablePanelCatalogueSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCatalogue)).BeginInit();
            this.SuspendLayout();
            // 
            // TablePanelTempUpper
            // 
            this.TablePanelTempUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.TablePanelTempUpper.ColumnCount = 4;
            this.TablePanelTempUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.TablePanelTempUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.00407F));
            this.TablePanelTempUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.48374F));
            this.TablePanelTempUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.44715F));
            this.TablePanelTempUpper.Controls.Add(this.PictureBoxLogo, 0, 0);
            this.TablePanelTempUpper.Controls.Add(this.LabelTempNameForm, 1, 0);
            this.TablePanelTempUpper.Controls.Add(this.ButtonCatalogueExit, 3, 0);
            this.TablePanelTempUpper.Controls.Add(this.LabelUser, 2, 0);
            this.TablePanelTempUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.TablePanelTempUpper.Location = new System.Drawing.Point(0, 0);
            this.TablePanelTempUpper.Margin = new System.Windows.Forms.Padding(4);
            this.TablePanelTempUpper.Name = "TablePanelTempUpper";
            this.TablePanelTempUpper.RowCount = 1;
            this.TablePanelTempUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelTempUpper.Size = new System.Drawing.Size(1312, 60);
            this.TablePanelTempUpper.TabIndex = 0;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxLogo.Image = global::OOO_Aromatny_Mir.Properties.Resources.logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(4, 4);
            this.PictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxLogo.MaximumSize = new System.Drawing.Size(56, 53);
            this.PictureBoxLogo.MinimumSize = new System.Drawing.Size(56, 53);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(56, 53);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // LabelTempNameForm
            // 
            this.LabelTempNameForm.AutoSize = true;
            this.LabelTempNameForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTempNameForm.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTempNameForm.Location = new System.Drawing.Point(56, 0);
            this.LabelTempNameForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTempNameForm.Name = "LabelTempNameForm";
            this.LabelTempNameForm.Size = new System.Drawing.Size(897, 60);
            this.LabelTempNameForm.TabIndex = 1;
            this.LabelTempNameForm.Text = "Каталог";
            this.LabelTempNameForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonCatalogueExit
            // 
            this.ButtonCatalogueExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCatalogueExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCatalogueExit.Location = new System.Drawing.Point(1111, 4);
            this.ButtonCatalogueExit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCatalogueExit.Name = "ButtonCatalogueExit";
            this.ButtonCatalogueExit.Size = new System.Drawing.Size(197, 52);
            this.ButtonCatalogueExit.TabIndex = 2;
            this.ButtonCatalogueExit.Text = "Назад";
            this.ButtonCatalogueExit.UseVisualStyleBackColor = true;
            this.ButtonCatalogueExit.Click += new System.EventHandler(this.ButtonCatalogueExit_Click);
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelUser.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelUser.Location = new System.Drawing.Point(961, 0);
            this.LabelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(142, 60);
            this.LabelUser.TabIndex = 3;
            this.LabelUser.Text = "Гость";
            // 
            // TablePanelTempDown
            // 
            this.TablePanelTempDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.TablePanelTempDown.ColumnCount = 3;
            this.TablePanelTempDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanelTempDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanelTempDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanelTempDown.Controls.Add(this.ButtonAddNewProduct, 1, 0);
            this.TablePanelTempDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TablePanelTempDown.Location = new System.Drawing.Point(0, 641);
            this.TablePanelTempDown.Margin = new System.Windows.Forms.Padding(4);
            this.TablePanelTempDown.Name = "TablePanelTempDown";
            this.TablePanelTempDown.RowCount = 1;
            this.TablePanelTempDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelTempDown.Size = new System.Drawing.Size(1312, 49);
            this.TablePanelTempDown.TabIndex = 1;
            // 
            // ButtonAddNewProduct
            // 
            this.ButtonAddNewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAddNewProduct.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.ButtonAddNewProduct.Location = new System.Drawing.Point(440, 3);
            this.ButtonAddNewProduct.Name = "ButtonAddNewProduct";
            this.ButtonAddNewProduct.Size = new System.Drawing.Size(431, 43);
            this.ButtonAddNewProduct.TabIndex = 0;
            this.ButtonAddNewProduct.Text = "Добавить товар";
            this.ButtonAddNewProduct.UseVisualStyleBackColor = true;
            // 
            // TablePanelCatalogueMain
            // 
            this.TablePanelCatalogueMain.ColumnCount = 1;
            this.TablePanelCatalogueMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelCatalogueMain.Controls.Add(this.LabelProductCount, 0, 0);
            this.TablePanelCatalogueMain.Controls.Add(this.TablePanelCatalogueSort, 0, 1);
            this.TablePanelCatalogueMain.Controls.Add(this.DGVCatalogue, 0, 2);
            this.TablePanelCatalogueMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanelCatalogueMain.Location = new System.Drawing.Point(0, 60);
            this.TablePanelCatalogueMain.Margin = new System.Windows.Forms.Padding(4);
            this.TablePanelCatalogueMain.Name = "TablePanelCatalogueMain";
            this.TablePanelCatalogueMain.RowCount = 3;
            this.TablePanelCatalogueMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TablePanelCatalogueMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TablePanelCatalogueMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TablePanelCatalogueMain.Size = new System.Drawing.Size(1312, 581);
            this.TablePanelCatalogueMain.TabIndex = 2;
            // 
            // LabelProductCount
            // 
            this.LabelProductCount.AutoSize = true;
            this.LabelProductCount.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductCount.Location = new System.Drawing.Point(4, 0);
            this.LabelProductCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelProductCount.Name = "LabelProductCount";
            this.LabelProductCount.Size = new System.Drawing.Size(104, 28);
            this.LabelProductCount.TabIndex = 0;
            this.LabelProductCount.Text = "Показано";
            // 
            // TablePanelCatalogueSort
            // 
            this.TablePanelCatalogueSort.ColumnCount = 8;
            this.TablePanelCatalogueSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TablePanelCatalogueSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TablePanelCatalogueSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.748466F));
            this.TablePanelCatalogueSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57669F));
            this.TablePanelCatalogueSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.202454F));
            this.TablePanelCatalogueSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.39571F));
            this.TablePanelCatalogueSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.595092F));
            this.TablePanelCatalogueSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.4816F));
            this.TablePanelCatalogueSort.Controls.Add(this.label2, 0, 0);
            this.TablePanelCatalogueSort.Controls.Add(this.label3, 2, 0);
            this.TablePanelCatalogueSort.Controls.Add(this.label4, 4, 0);
            this.TablePanelCatalogueSort.Controls.Add(this.label5, 6, 0);
            this.TablePanelCatalogueSort.Controls.Add(this.ComboBoxCost, 1, 0);
            this.TablePanelCatalogueSort.Controls.Add(this.ComboBoxDiscount, 3, 0);
            this.TablePanelCatalogueSort.Controls.Add(this.ComboBoxCategory, 5, 0);
            this.TablePanelCatalogueSort.Controls.Add(this.TextBoxSearch, 7, 0);
            this.TablePanelCatalogueSort.Location = new System.Drawing.Point(4, 62);
            this.TablePanelCatalogueSort.Margin = new System.Windows.Forms.Padding(4);
            this.TablePanelCatalogueSort.Name = "TablePanelCatalogueSort";
            this.TablePanelCatalogueSort.RowCount = 1;
            this.TablePanelCatalogueSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelCatalogueSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TablePanelCatalogueSort.Size = new System.Drawing.Size(1304, 50);
            this.TablePanelCatalogueSort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Стоимость";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(328, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 50);
            this.label3.TabIndex = 1;
            this.label3.Text = "Скидка";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(579, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Категория";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label5.Location = new System.Drawing.Point(977, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 50);
            this.label5.TabIndex = 3;
            this.label5.Text = "Поиск";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBoxCost
            // 
            this.ComboBoxCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxCost.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ComboBoxCost.FormattingEnabled = true;
            this.ComboBoxCost.Items.AddRange(new object[] {
            "Возрастает",
            "Убывает"});
            this.ComboBoxCost.Location = new System.Drawing.Point(166, 4);
            this.ComboBoxCost.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxCost.Name = "ComboBoxCost";
            this.ComboBoxCost.Size = new System.Drawing.Size(154, 36);
            this.ComboBoxCost.TabIndex = 4;
            this.ComboBoxCost.SelectedValueChanged += new System.EventHandler(this.ComboBoxCost_SelectedValueChanged);
            // 
            // ComboBoxDiscount
            // 
            this.ComboBoxDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxDiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ComboBoxDiscount.FormattingEnabled = true;
            this.ComboBoxDiscount.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-10%",
            "11-14%",
            "15% и более"});
            this.ComboBoxDiscount.Location = new System.Drawing.Point(415, 4);
            this.ComboBoxDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxDiscount.Name = "ComboBoxDiscount";
            this.ComboBoxDiscount.Size = new System.Drawing.Size(156, 36);
            this.ComboBoxDiscount.TabIndex = 5;
            this.ComboBoxDiscount.SelectedValueChanged += new System.EventHandler(this.ComboBoxCost_SelectedValueChanged);
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxCategory.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(698, 4);
            this.ComboBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(271, 36);
            this.ComboBoxCategory.TabIndex = 6;
            this.ComboBoxCategory.SelectedValueChanged += new System.EventHandler(this.ComboBoxCost_SelectedValueChanged);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.TextBoxSearch.Location = new System.Drawing.Point(1062, 4);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(238, 35);
            this.TextBoxSearch.TabIndex = 7;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // DGVCatalogue
            // 
            this.DGVCatalogue.AllowUserToAddRows = false;
            this.DGVCatalogue.AllowUserToDeleteRows = false;
            this.DGVCatalogue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCatalogue.ColumnHeadersVisible = false;
            this.DGVCatalogue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPhoto,
            this.ColumnDescription,
            this.ColumnDiscount});
            this.DGVCatalogue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCatalogue.Location = new System.Drawing.Point(4, 120);
            this.DGVCatalogue.Margin = new System.Windows.Forms.Padding(4);
            this.DGVCatalogue.Name = "DGVCatalogue";
            this.DGVCatalogue.ReadOnly = true;
            this.DGVCatalogue.RowHeadersWidth = 51;
            this.DGVCatalogue.Size = new System.Drawing.Size(1304, 457);
            this.DGVCatalogue.TabIndex = 2;
            // 
            // ColumnPhoto
            // 
            this.ColumnPhoto.HeaderText = "Column1";
            this.ColumnPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnPhoto.MinimumWidth = 125;
            this.ColumnPhoto.Name = "ColumnPhoto";
            this.ColumnPhoto.ReadOnly = true;
            this.ColumnPhoto.Width = 125;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnDescription.HeaderText = "Column1";
            this.ColumnDescription.MinimumWidth = 6;
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            this.ColumnDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnDiscount
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ColumnDiscount.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnDiscount.HeaderText = "Column1";
            this.ColumnDiscount.MinimumWidth = 125;
            this.ColumnDiscount.Name = "ColumnDiscount";
            this.ColumnDiscount.ReadOnly = true;
            this.ColumnDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnDiscount.Width = 125;
            // 
            // FormCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.TablePanelCatalogueMain);
            this.Controls.Add(this.TablePanelTempDown);
            this.Controls.Add(this.TablePanelTempUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1327, 728);
            this.Name = "FormCatalogue";
            this.Text = "Каталог";
            this.Load += new System.EventHandler(this.FormCatalogue_Load);
            this.TablePanelTempUpper.ResumeLayout(false);
            this.TablePanelTempUpper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.TablePanelTempDown.ResumeLayout(false);
            this.TablePanelCatalogueMain.ResumeLayout(false);
            this.TablePanelCatalogueMain.PerformLayout();
            this.TablePanelCatalogueSort.ResumeLayout(false);
            this.TablePanelCatalogueSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCatalogue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanelTempUpper;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelTempNameForm;
        private System.Windows.Forms.Button ButtonCatalogueExit;
        private System.Windows.Forms.TableLayoutPanel TablePanelTempDown;
        private System.Windows.Forms.TableLayoutPanel TablePanelCatalogueMain;
        private System.Windows.Forms.Label LabelProductCount;
        private System.Windows.Forms.TableLayoutPanel TablePanelCatalogueSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxCost;
        private System.Windows.Forms.ComboBox ComboBoxDiscount;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.DataGridView DGVCatalogue;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Button ButtonAddNewProduct;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscount;
    }
}

