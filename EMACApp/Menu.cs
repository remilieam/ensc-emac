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

        private void Test1EasyMenuButtom_Click(object sender, EventArgs e)
        {
            TestPerceptionDemo_Form testPerception = new TestPerceptionDemo_Form();
            testPerception.Show();
        }

        private void Menu_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
