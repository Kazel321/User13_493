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
    public partial class FormProduct : Form
    {
        string path = Application.StartupPath;

        public FormProduct()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormProduct_Load(object sender, EventArgs e)
        {
            tableLayoutPanelTop.BackColor = Color.FromArgb(118, 227, 131);
            tableLayoutPanelMain.BackColor = Color.FromArgb(255, 255, 255);
            tableLayoutPanelBottom.BackColor = Color.FromArgb(118, 227, 131);

            labelFullName.Text = Helper.User.UserFullName;
            if (Helper.User.RoleId != 1) buttonAddProduct.Visible = false;

            comboBoxCost.SelectedIndex = 0;
            comboBoxDiscount.SelectedIndex = 0;
            var manf = Helper.DB.Manufacturer.Select(x => x.ManufacturerName).ToList();
            manf.Insert(0, "все производители");
            comboBoxManuf.DataSource = manf;
            comboBoxManuf.SelectedIndex = 0;

            UpdateProduct();

            comboBoxCost.SelectedIndexChanged += Filter;
            comboBoxDiscount.SelectedIndexChanged += Filter;
            comboBoxManuf.SelectedIndexChanged += Filter;
            textBoxFind.TextChanged += Filter;
        }

        /// <summary>
        /// Обновление списка
        /// </summary>
        private void UpdateProduct()
        {
            dataGridViewProduct.Rows.Clear();

            using (DB DB = new DB()) 
            {
                var product = DB.Product.ToList();
                if (!String.IsNullOrEmpty(textBoxFind.Text))
                    product = product.Where(x => x.ProductName.Contains(textBoxFind.Text)).ToList();
                if (comboBoxManuf.SelectedIndex != 0)
                    product = product.Where(x => x.ManufacturerId == comboBoxManuf.SelectedIndex).ToList();
                switch (comboBoxDiscount.SelectedIndex)
                {
                    case 1:
                        product = product.Where(x => x.ProductDiscountMax < 11).ToList();
                        break;
                    case 2:
                        product = product.Where(x => x.ProductDiscountMax < 15 && x.ProductDiscountMax > 10).ToList();
                        break;
                    case 3:
                        product = product.Where(x => x.ProductDiscountMax > 15).ToList();
                        break;
                }
                if (comboBoxCost.SelectedIndex == 0)
                    product = product.OrderBy(x => x.ProductCost).ToList();
                else
                    product = product.OrderByDescending(x => x.ProductCost).ToList();

                int ind = -1;
                Bitmap bmp;

                foreach (var item in product)
                {
                    ind = dataGridViewProduct.Rows.Add();
                    dataGridViewProduct.Rows[ind].Height = 200;
                    dataGridViewProduct[0, ind].Value = item.ProductArticleNumber;

                    if (String.IsNullOrEmpty(item.ProductImage))
                    {
                        dataGridViewProduct[1, ind].Value = Properties.Resources.picture;
                    }
                    else
                    {
                        //Image img = Image.FromFile(path + "\\Товар_import\\" + item.ProductImage);
                        //MemoryStream ms = new MemoryStream();
                        //img.Save(ms, ImageFormat.Jpeg);
                        //bmp = (Bitmap)Image.FromStream(ms);
                        //dataGridViewProduct[1, ind].Value = img;
                        //bmp.Dispose();
                        //ms.Close();

                        Image img = Image.FromFile(path + "\\Товар_import\\" + item.ProductImage);
                        MemoryStream ms = new MemoryStream();
                        img.Save(ms, ImageFormat.Jpeg);
                        img.Dispose();
                        Image newImg = Image.FromStream(ms);
                        dataGridViewProduct[1, ind].Value = newImg;
                        
                        ms.Close();
                    }

                    string desc = "Название: ";
                    desc += item.ProductName;
                    desc += Environment.NewLine + "Описание: " + item.ProductDescription;
                    desc += Environment.NewLine + "Производитель: " + item.Manufacturer.ManufacturerName;
                    desc += Environment.NewLine + "Цена: " + item.ProductCost.ToString("C2");
                    desc += Environment.NewLine + "Скидка: " + item.ProductDiscountMax;
                    double costDiscount = item.ProductCost + (item.ProductCost * (item.ProductDiscountMax / 100));
                    desc += Environment.NewLine + "Цена со скидкой: " + costDiscount.ToString("C2");

                    dataGridViewProduct[2, ind].Value = desc;

                    string quantity;
                    if (item.ProductQuantityInStock == 0)
                    {
                        quantity = "Нет в наличии";
                        dataGridViewProduct[2, ind].Style.BackColor = Color.LightGray;
                        dataGridViewProduct[3, ind].Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        quantity = "В наличии: " + item.ProductQuantityInStock;
                    }

                    dataGridViewProduct[3, ind].Value = quantity;
                }

                labelCount.Text = "Количество: " + (ind + 1) + " из " + Helper.DB.Product.Count();
            }
        }

        private void Filter(object sender, EventArgs e)
        {
            UpdateProduct();
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
        /// Добавление товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Helper.FormAction = FormAction.Добавление;
            FormChangeProduct form = new FormChangeProduct();
            Hide();
            form.ShowDialog();
            Show();
            UpdateProduct();
        }

        private void dataGridViewProduct_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Helper.User.RoleId == 1)
            {
                int row = dataGridViewProduct.HitTest(e.X, e.Y).RowIndex;
                if (row == -1) return;
                Helper.FormAction = FormAction.Редактирование;
                string article = dataGridViewProduct[0, row].Value.ToString();
                FormChangeProduct form = new FormChangeProduct(article);
                Hide();
                form.ShowDialog();
                Show();
                UpdateProduct();
            }
        }
    }
}
