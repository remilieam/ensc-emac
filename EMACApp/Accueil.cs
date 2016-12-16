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
    public partial class Accueil_Form : Form
    {
        public Accueil_Form()
        {
            InitializeComponent();
        }

        private void Quitter_Buttom_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Accueil_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr(e) de vouloir quitter ?", "Demande de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Continuer_Buttom_Click(object sender, EventArgs e)
        {
            // Tant qu’on n’a pas fermé le formulaire de menu, on cache le formulaire de bienvenue
            this.Hide();

            Menu_Form menu = new Menu_Form();

            if (menu.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
