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
    public partial class Pattern : Form
    {
        public Pattern()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pattern_Load(object sender, EventArgs e)
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
    }
}
