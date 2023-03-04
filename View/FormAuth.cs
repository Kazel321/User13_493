using OOOSportProducts.Classes;
using OOOSportProducts.Classes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOOSportProducts
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAuth_Load(object sender, EventArgs e)
        {
            tableLayoutPanelTop.BackColor = Color.FromArgb(118, 227, 131);
            tableLayoutPanelMain.BackColor = Color.FromArgb(255, 255, 255);
            tableLayoutPanelBottom.BackColor = Color.FromArgb(118, 227, 131);
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

        int loginAttempts = 0;

        /// <summary>
        /// Войти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (timerBlock.Enabled)
            {
                MessageBox.Show("Вы заблокированы на 10 секунд", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string login = textBoxLogin.Text;
            string pass = textBoxPassword.Text;
            string cap = textBoxCaptcha.Text;

            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Вы заполнили не все данные", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = Helper.DB.User.Where(x => x.UserLogin == login && x.UserPassword == pass).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Вы ввели неверный логин или пароль", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelCaptcha.Text = generateCaptcha();
                if (loginAttempts == 0)
                {
                    labelCaptcha.Visible = true;
                    textBoxCaptcha.Visible = true;
                }
                if (loginAttempts > 0) timerBlock.Start();
                loginAttempts++;
                return;
            }
            else
            {
                if (loginAttempts > 0)
                {
                    if (cap != labelCaptcha.Text)
                    {
                        MessageBox.Show("Вы ввели неверный логин, пароль или каптчу", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        timerBlock.Start();
                        labelCaptcha.Text = generateCaptcha();
                        loginAttempts++;
                        return;
                    }
                }
                Helper.User = user;
                FormProduct form = new FormProduct();
                MessageBox.Show("Вы ввошли как: " + user.Role.RoleName, "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        /// <summary>
        /// Создвание каптчи
        /// </summary>
        /// <returns></returns>
        string generateCaptcha()
        {
            Random rand = new Random();
            string text = "123456789QWERTYUIOPASDFGHJKLZXCVBNM";
            string captcha = "";
            for (int i = 0; i < 6; i++)
            {
                captcha += text[rand.Next(text.Length)];
            }
            return captcha;
        }

        /// <summary>
        /// Таймер блокировки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBlock_Tick(object sender, EventArgs e)
        {
            timerBlock.Enabled = false;
        }
    }
}
