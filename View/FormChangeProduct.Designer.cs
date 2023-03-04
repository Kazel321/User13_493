namespace OOOSportProducts
{
    partial class FormChangeProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeProduct));
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.labelArticle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelDiscountMax = new System.Windows.Forms.Label();
            this.labelManf = new System.Windows.Forms.Label();
            this.labelProv = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDiscountNow = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.buttonDelImage = new System.Windows.Forms.Button();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.numericUpDownDistountMax = new System.Windows.Forms.NumericUpDown();
            this.comboBoxManf = new System.Windows.Forms.ComboBox();
            this.comboBoxProv = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.numericUpDownDiscountNow = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistountMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscountNow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
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
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(961, 50);
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
            this.labelTitle.Size = new System.Drawing.Size(755, 50);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Товар";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReturn.Location = new System.Drawing.Point(864, 3);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(94, 44);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Назад";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.Controls.Add(this.labelArticle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelUnit, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelCost, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.labelDiscountMax, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.labelManf, 0, 5);
            this.tableLayoutPanelMain.Controls.Add(this.labelProv, 0, 6);
            this.tableLayoutPanelMain.Controls.Add(this.labelCategory, 0, 7);
            this.tableLayoutPanelMain.Controls.Add(this.labelDiscountNow, 0, 8);
            this.tableLayoutPanelMain.Controls.Add(this.labelCount, 0, 9);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSave, 0, 10);
            this.tableLayoutPanelMain.Controls.Add(this.buttonDelete, 2, 10);
            this.tableLayoutPanelMain.Controls.Add(this.labelDesc, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelImage, 2, 4);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSaveImage, 2, 9);
            this.tableLayoutPanelMain.Controls.Add(this.buttonDelImage, 3, 9);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxArticle, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxUnit, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxCost, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownDistountMax, 1, 4);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxManf, 1, 5);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxProv, 1, 6);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxCategory, 1, 7);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownDiscountNow, 1, 8);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownCount, 1, 9);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxDesc, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBoxImage, 2, 5);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 11;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(961, 545);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 1;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 595);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(961, 50);
            this.tableLayoutPanelBottom.TabIndex = 2;
            // 
            // labelArticle
            // 
            this.labelArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelArticle.AutoSize = true;
            this.labelArticle.Location = new System.Drawing.Point(30, 13);
            this.labelArticle.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.labelArticle.Name = "labelArticle";
            this.labelArticle.Size = new System.Drawing.Size(207, 23);
            this.labelArticle.TabIndex = 0;
            this.labelArticle.Text = "Артикул:";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 62);
            this.labelName.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(207, 23);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название:";
            // 
            // labelUnit
            // 
            this.labelUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(30, 111);
            this.labelUnit.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(207, 23);
            this.labelUnit.TabIndex = 2;
            this.labelUnit.Text = "Ед. измерения:";
            // 
            // labelCost
            // 
            this.labelCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(30, 160);
            this.labelCost.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(207, 23);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "Цена:";
            // 
            // labelDiscountMax
            // 
            this.labelDiscountMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDiscountMax.AutoSize = true;
            this.labelDiscountMax.Location = new System.Drawing.Point(30, 209);
            this.labelDiscountMax.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.labelDiscountMax.Name = "labelDiscountMax";
            this.labelDiscountMax.Size = new System.Drawing.Size(207, 23);
            this.labelDiscountMax.TabIndex = 4;
            this.labelDiscountMax.Text = "Макс. скидка:";
            // 
            // labelManf
            // 
            this.labelManf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelManf.AutoSize = true;
            this.labelManf.Location = new System.Drawing.Point(30, 258);
            this.labelManf.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.labelManf.Name = "labelManf";
            this.labelManf.Size = new System.Drawing.Size(207, 23);
            this.labelManf.TabIndex = 5;
            this.labelManf.Text = "Производиетель:";
            // 
            // labelProv
            // 
            this.labelProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProv.AutoSize = true;
            this.labelProv.Location = new System.Drawing.Point(30, 307);
            this.labelProv.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.labelProv.Name = "labelProv";
            this.labelProv.Size = new System.Drawing.Size(207, 23);
            this.labelProv.TabIndex = 6;
            this.labelProv.Text = "Поставщик:";
            // 
            // labelCategory
            // 
            this.labelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(30, 356);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(207, 23);
            this.labelCategory.TabIndex = 7;
            this.labelCategory.Text = "Категория:";
            // 
            // labelDiscountNow
            // 
            this.labelDiscountNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDiscountNow.AutoSize = true;
            this.labelDiscountNow.Location = new System.Drawing.Point(30, 405);
            this.labelDiscountNow.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.labelDiscountNow.Name = "labelDiscountNow";
            this.labelDiscountNow.Size = new System.Drawing.Size(207, 23);
            this.labelDiscountNow.TabIndex = 8;
            this.labelDiscountNow.Text = "Текущ. скидка:";
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(30, 454);
            this.labelCount.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(207, 23);
            this.labelCount.TabIndex = 9;
            this.labelCount.Text = "Количество на складе:";
            // 
            // buttonSave
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.buttonSave, 2);
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(30, 500);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(420, 35);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.buttonDelete, 2);
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(510, 500);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(421, 35);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelDesc
            // 
            this.labelDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDesc.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelDesc, 2);
            this.labelDesc.Location = new System.Drawing.Point(510, 13);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(448, 23);
            this.labelDesc.TabIndex = 12;
            this.labelDesc.Text = "Описание:";
            this.labelDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelImage
            // 
            this.labelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImage.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelImage, 2);
            this.labelImage.Location = new System.Drawing.Point(510, 209);
            this.labelImage.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(448, 23);
            this.labelImage.TabIndex = 13;
            this.labelImage.Text = "Изображение";
            this.labelImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveImage.Location = new System.Drawing.Point(540, 444);
            this.buttonSaveImage.Margin = new System.Windows.Forms.Padding(60, 3, 30, 3);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(150, 43);
            this.buttonSaveImage.TabIndex = 14;
            this.buttonSaveImage.Text = "Открыть";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // buttonDelImage
            // 
            this.buttonDelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelImage.Location = new System.Drawing.Point(780, 444);
            this.buttonDelImage.Margin = new System.Windows.Forms.Padding(60, 3, 30, 3);
            this.buttonDelImage.Name = "buttonDelImage";
            this.buttonDelImage.Size = new System.Drawing.Size(151, 43);
            this.buttonDelImage.TabIndex = 15;
            this.buttonDelImage.Text = "Удалить";
            this.buttonDelImage.UseVisualStyleBackColor = true;
            this.buttonDelImage.Click += new System.EventHandler(this.buttonDelImage_Click);
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArticle.Location = new System.Drawing.Point(270, 9);
            this.textBoxArticle.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.Size = new System.Drawing.Size(207, 30);
            this.textBoxArticle.TabIndex = 16;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(270, 58);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(207, 30);
            this.textBoxName.TabIndex = 17;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(270, 107);
            this.comboBoxUnit.Margin = new System.Windows.Forms.Padding(30, 0, 3, 10);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(207, 31);
            this.comboBoxUnit.TabIndex = 18;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCost.Location = new System.Drawing.Point(270, 156);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(207, 30);
            this.textBoxCost.TabIndex = 19;
            // 
            // numericUpDownDistountMax
            // 
            this.numericUpDownDistountMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownDistountMax.Location = new System.Drawing.Point(270, 205);
            this.numericUpDownDistountMax.Margin = new System.Windows.Forms.Padding(30, 0, 3, 10);
            this.numericUpDownDistountMax.Name = "numericUpDownDistountMax";
            this.numericUpDownDistountMax.Size = new System.Drawing.Size(207, 30);
            this.numericUpDownDistountMax.TabIndex = 20;
            // 
            // comboBoxManf
            // 
            this.comboBoxManf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxManf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManf.FormattingEnabled = true;
            this.comboBoxManf.Location = new System.Drawing.Point(270, 254);
            this.comboBoxManf.Margin = new System.Windows.Forms.Padding(30, 0, 3, 10);
            this.comboBoxManf.Name = "comboBoxManf";
            this.comboBoxManf.Size = new System.Drawing.Size(207, 31);
            this.comboBoxManf.TabIndex = 21;
            // 
            // comboBoxProv
            // 
            this.comboBoxProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProv.FormattingEnabled = true;
            this.comboBoxProv.Location = new System.Drawing.Point(270, 303);
            this.comboBoxProv.Margin = new System.Windows.Forms.Padding(30, 0, 3, 10);
            this.comboBoxProv.Name = "comboBoxProv";
            this.comboBoxProv.Size = new System.Drawing.Size(207, 31);
            this.comboBoxProv.TabIndex = 22;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(270, 352);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(30, 0, 3, 10);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(207, 31);
            this.comboBoxCategory.TabIndex = 23;
            // 
            // numericUpDownDiscountNow
            // 
            this.numericUpDownDiscountNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownDiscountNow.Location = new System.Drawing.Point(270, 401);
            this.numericUpDownDiscountNow.Margin = new System.Windows.Forms.Padding(30, 0, 3, 10);
            this.numericUpDownDiscountNow.Name = "numericUpDownDiscountNow";
            this.numericUpDownDiscountNow.Size = new System.Drawing.Size(207, 30);
            this.numericUpDownDiscountNow.TabIndex = 24;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCount.Location = new System.Drawing.Point(270, 450);
            this.numericUpDownCount.Margin = new System.Windows.Forms.Padding(30, 0, 3, 10);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(207, 30);
            this.numericUpDownCount.TabIndex = 25;
            // 
            // textBoxDesc
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.textBoxDesc, 2);
            this.textBoxDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDesc.Location = new System.Drawing.Point(510, 49);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.tableLayoutPanelMain.SetRowSpan(this.textBoxDesc, 3);
            this.textBoxDesc.Size = new System.Drawing.Size(448, 147);
            this.textBoxDesc.TabIndex = 26;
            // 
            // pictureBoxImage
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.pictureBoxImage, 2);
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(510, 245);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.tableLayoutPanelMain.SetRowSpan(this.pictureBoxImage, 4);
            this.pictureBoxImage.Size = new System.Drawing.Size(448, 196);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 27;
            this.pictureBoxImage.TabStop = false;
            // 
            // FormChangeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 645);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(964, 607);
            this.Name = "FormChangeProduct";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.FormChangeProduct_Load);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistountMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscountNow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelArticle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelDiscountMax;
        private System.Windows.Forms.Label labelManf;
        private System.Windows.Forms.Label labelProv;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDiscountNow;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.Button buttonDelImage;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.NumericUpDown numericUpDownDistountMax;
        private System.Windows.Forms.ComboBox comboBoxManf;
        private System.Windows.Forms.ComboBox comboBoxProv;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscountNow;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}

