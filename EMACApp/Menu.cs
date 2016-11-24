using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EMACClass;

namespace EMACApp
{
    public partial class Menu_Form : Form
    {
        // Chemin vers la base de données
        private const string BDD = "|DataDirectory|\\AppData\\EMAC.mdb";

        public Menu_Form()
        {
            InitializeComponent();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            Home_Form home = new Home_Form();
            home.Show();
        }

        private void ReturnMenuButtom_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home_Form home = new Home_Form();
            home.Show();
        }

        private void Test1EasyMenuButtom_Click(object sender, EventArgs e)
        {
            TestPerception_Form testPerception = new TestPerception_Form();
            testPerception.Show();
        }
    }
}
