namespace OOOSportProducts
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxCost = new System.Windows.Forms.ComboBox();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.comboBoxManuf = new System.Windows.Forms.ComboBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSortPrice = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelManuf = new System.Windows.Forms.Label();
            this.labelFind = new System.Windows.Forms.Label();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelTop.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonReturn, 2, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1212, 50);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::OOOSportProducts.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Location = new System.Drawing.Point(103, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(53, 0, 3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1006, 50);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Список товаров";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReturn.Location = new System.Drawing.Point(1115, 3);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(94, 44);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Назад";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 8;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxCost, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxDiscount, 3, 1);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxManuf, 5, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxFind, 7, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelCount, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelFullName, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewProduct, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelSortPrice, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelDiscount, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelManuf, 4, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelFind, 6, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonAddProduct, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1212, 574);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // comboBoxCost
            // 
            this.comboBoxCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCost.FormattingEnabled = true;
            this.comboBoxCost.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
            this.comboBoxCost.Location = new System.Drawing.Point(131, 75);
            this.comboBoxCost.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.comboBoxCost.Name = "comboBoxCost";
            this.comboBoxCost.Size = new System.Drawing.Size(168, 31);
            this.comboBoxCost.TabIndex = 0;
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Items.AddRange(new object[] {
            "все диапазоны",
            "0-10%",
            "11-14%",
            "15% и более"});
            this.comboBoxDiscount.Location = new System.Drawing.Point(433, 75);
            this.comboBoxDiscount.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(168, 31);
            this.comboBoxDiscount.TabIndex = 1;
            // 
            // comboBoxManuf
            // 
            this.comboBoxManuf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxManuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManuf.FormattingEnabled = true;
            this.comboBoxManuf.Location = new System.Drawing.Point(735, 75);
            this.comboBoxManuf.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.comboBoxManuf.Name = "comboBoxManuf";
            this.comboBoxManuf.Size = new System.Drawing.Size(168, 31);
            this.comboBoxManuf.TabIndex = 2;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFind.Location = new System.Drawing.Point(1037, 70);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(172, 30);
            this.textBoxFind.TabIndex = 3;
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCount.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelCount, 3);
            this.labelCount.Location = new System.Drawing.Point(10, 17);
            this.labelCount.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(410, 23);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Количество: 0 из";
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFullName.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelFullName, 5);
            this.labelFullName.Location = new System.Drawing.Point(433, 17);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(776, 23);
            this.labelFullName.TabIndex = 5;
            this.labelFullName.Text = "ФИО";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AllowUserToResizeColumns = false;
            this.dataGridViewProduct.AllowUserToResizeRows = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.ColumnHeadersVisible = false;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnPhoto,
            this.ColumnDesc,
            this.ColumnCount});
            this.tableLayoutPanelMain.SetColumnSpan(this.dataGridViewProduct, 8);
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.Location = new System.Drawing.Point(3, 117);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1206, 395);
            this.dataGridViewProduct.TabIndex = 6;
            this.dataGridViewProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewProduct_MouseClick);
            // 
            // ColumnID
            // 
            this.ColumnID.Frozen = true;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            this.ColumnID.Width = 150;
            // 
            // ColumnPhoto
            // 
            this.ColumnPhoto.Frozen = true;
            this.ColumnPhoto.HeaderText = "ColumnPhoto";
            this.ColumnPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnPhoto.Name = "ColumnPhoto";
            this.ColumnPhoto.ReadOnly = true;
            this.ColumnPhoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPhoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnPhoto.Width = 250;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDesc.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnDesc.Frozen = true;
            this.ColumnDesc.HeaderText = "ColumnDesc";
            this.ColumnDesc.Name = "ColumnDesc";
            this.ColumnDesc.ReadOnly = true;
            this.ColumnDesc.Width = 753;
            // 
            // ColumnCount
            // 
            this.ColumnCount.Frozen = true;
            this.ColumnCount.HeaderText = "ColumnCount";
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            this.ColumnCount.Width = 200;
            // 
            // labelSortPrice
            // 
            this.labelSortPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSortPrice.AutoSize = true;
            this.labelSortPrice.Location = new System.Drawing.Point(10, 74);
            this.labelSortPrice.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelSortPrice.Name = "labelSortPrice";
            this.labelSortPrice.Size = new System.Drawing.Size(108, 23);
            this.labelSortPrice.TabIndex = 7;
            this.labelSortPrice.Text = "Стоимость";
            // 
            // labelDiscount
            // 
            this.labelDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(312, 74);
            this.labelDiscount.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(108, 23);
            this.labelDiscount.TabIndex = 8;
            this.labelDiscount.Text = "Скидка";
            // 
            // labelManuf
            // 
            this.labelManuf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelManuf.AutoSize = true;
            this.labelManuf.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManuf.Location = new System.Drawing.Point(614, 76);
            this.labelManuf.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelManuf.Name = "labelManuf";
            this.labelManuf.Size = new System.Drawing.Size(108, 18);
            this.labelManuf.TabIndex = 9;
            this.labelManuf.Text = "Производитель";
            // 
            // labelFind
            // 
            this.labelFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(916, 74);
            this.labelFind.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(108, 23);
            this.labelFind.TabIndex = 10;
            this.labelFind.Text = "Поиск";
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 1;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 624);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(1212, 50);
            this.tableLayoutPanelBottom.TabIndex = 2;
            // 
            // buttonAddProduct
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.buttonAddProduct, 4);
            this.buttonAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddProduct.Location = new System.Drawing.Point(50, 525);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(504, 39);
            this.buttonAddProduct.TabIndex = 11;
            this.buttonAddProduct.Text = "Добавить товар";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 674);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(964, 607);
            this.Name = "FormProduct";
            this.Text = "Список товаров";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ComboBox comboBoxCost;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
        private System.Windows.Forms.ComboBox comboBoxManuf;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Label labelSortPrice;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelManuf;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.Button buttonAddProduct;
    }
}

