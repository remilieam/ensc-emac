using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EMACApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            HomeForm home = new HomeForm();
            home.Show();
        }

        private void ReturnMenuButtom_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomeForm home = new HomeForm();
            home.Show();
        }
    }
}
