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
        string path = Application.StartupPath ;
        Bitmap bmp;
        OpenFileDialog openFileDialog;

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

            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg";

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
                    img.Dispose();
                    Image newImg = Image.FromStream(ms);
                    pictureBoxImage.Image = newImg;
                    ms.Close();
                }
            }
            else buttonDelete.Enabled = false;
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

        /// <summary>
        /// Сохранение товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string article = textBoxArticle.Text;
            string name = textBoxName.Text;
            string stringCost = textBoxCost.Text;
            string desc = textBoxDesc.Text;

            if (String.IsNullOrEmpty(article) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(stringCost))
            {
                MessageBox.Show("Вы ввели не все данные", Helper.FormAction + " товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double cost;
            try
            {
                cost= Convert.ToDouble(stringCost);
            }
            catch
            {
                MessageBox.Show("Неверный формат цены", Helper.FormAction + " товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cost < 0)
            {
                MessageBox.Show("Цена меньше нуля", Helper.FormAction + " товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maxSale = (int)numericUpDownDistountMax.Value;
            int nowSale = (int)numericUpDownDiscountNow.Value;

            if (nowSale > maxSale)
            {
                MessageBox.Show("Текущая скидка не может быть больше максимальной", Helper.FormAction + " товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int unitId = comboBoxUnit.SelectedIndex + 1;
            int manfId = comboBoxManf.SelectedIndex + 1;
            int provId = comboBoxProv.SelectedIndex + 1;
            int categoryId = comboBoxCategory.SelectedIndex + 1;

            Product p;
            if (Helper.FormAction == FormAction.Добавление)
            {
                p = new Product();
            }
            else p = Helper.DB.Product.Where(x => x.ProductArticleNumber == this.article).FirstOrDefault();

            p.ProductArticleNumber = article;
            p.ProductName = name;
            p.UnitId = unitId;
            p.ProductCost = cost;
            p.ProductDiscountMax = (byte)maxSale;
            p.ManufacturerId = manfId;
            p.ProviderId = provId;
            p.CategoryId = categoryId;
            p.ProductDiscountNow = (byte?)nowSale;
            p.ProductDescription = desc;
            if (pictureBoxImage.Image == null) p.ProductImage = null;
            else
            {
                Image saveImage = pictureBoxImage.Image;
                if (Helper.FormAction == FormAction.Редактирование && File.Exists(path + "\\Товар_import\\" + article + ".jpg"))
                {
                    File.Delete(path + "\\Товар_import\\" + article + ".jpg");
                }
                File.Copy(newPath, path + "\\Товар_import\\" + article + ".jpg");
                p.ProductImage = article + ".jpg";
            }

            if (Helper.FormAction == FormAction.Добавление)
                Helper.DB.Product.Add(p);

            Helper.DB.SaveChanges();

            MessageBox.Show("Товар сохранен", Helper.FormAction + " товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        String newPath;

        /// <summary>
        /// Выбор изображения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                Image img = Image.FromFile(openFileDialog.FileName);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Jpeg);
                img.Dispose();
                Image newImg = Image.FromStream(ms);
                pictureBoxImage.Image = newImg;
                ms.Close();
                newPath = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Удаление изображения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelImage_Click(object sender, EventArgs e)
        {
            pictureBoxImage.Image = null;
        }
    }
}
