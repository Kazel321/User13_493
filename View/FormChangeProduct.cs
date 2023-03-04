using OOOSportProducts.Classes;
using OOOSportProducts.Classes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOOSportProducts
{
    public partial class FormChangeProduct : Form
    {
        string article;
        string path = Application.StartupPath;
        Bitmap bmp;

        public FormChangeProduct()
        {
            InitializeComponent();
        }

        public FormChangeProduct(string article)
        {
            this.article = article;
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormChangeProduct_Load(object sender, EventArgs e)
        {
            tableLayoutPanelTop.BackColor = Color.FromArgb(118, 227, 131);
            tableLayoutPanelMain.BackColor = Color.FromArgb(255, 255, 255);
            tableLayoutPanelBottom.BackColor = Color.FromArgb(118, 227, 131);

            var unit = Helper.DB.Unit.Select(x => x.UnitName).ToList();
            comboBoxUnit.DataSource = unit;
            comboBoxUnit.SelectedIndex = 0;
            var manf = Helper.DB.Manufacturer.Select(x => x.ManufacturerName).ToList();
            comboBoxManf.DataSource = manf;
            comboBoxManf.SelectedIndex = 0;
            var prov = Helper.DB.Provider.Select(x => x.ProviderName).ToList();
            comboBoxProv.DataSource = prov;
            comboBoxProv.SelectedIndex = 0;
            var category = Helper.DB.Category.Select(x => x.CategoryName).ToList();
            comboBoxCategory.DataSource = category;
            comboBoxCategory.SelectedIndex = 0;

            if (Helper.FormAction == FormAction.Редактирование)
            {
                Product p = Helper.DB.Product.Where(x => x.ProductArticleNumber == article).FirstOrDefault();
                textBoxArticle.Text = article;
                textBoxArticle.ReadOnly = true;
                textBoxName.Text = p.ProductName;
                comboBoxUnit.SelectedIndex = p.UnitId - 1;
                textBoxCost.Text = p.ProductCost.ToString();

                numericUpDownDistountMax.Value = p.ProductDiscountMax;
                comboBoxManf.SelectedIndex = p.ManufacturerId - 1;
                comboBoxProv.SelectedIndex = p.ProviderId - 1;
                comboBoxCategory.SelectedIndex = p.CategoryId - 1;
                numericUpDownDiscountNow.Value = (byte)p.ProductDiscountNow;
                textBoxDesc.Text = p.ProductDescription;

                if (!String.IsNullOrEmpty(p.ProductImage))
                {
                    Image img = Image.FromFile(path + "\\Товар_import\\" + p.ProductImage);
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, ImageFormat.Jpeg);
                    bmp = (Bitmap)Image.FromStream(ms);
                    pictureBoxImage.Image = img;
                    bmp.Dispose();
                    ms.Close();
                }
            }
        }

        /// <summary>
        /// Вернутся назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
