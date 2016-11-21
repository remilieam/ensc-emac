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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void ExitButtom_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr(e) de vouloir quitter ?", "Demande de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ContinueButtom_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuForm menu = new MenuForm();
            menu.Show();
        }
    }
}
