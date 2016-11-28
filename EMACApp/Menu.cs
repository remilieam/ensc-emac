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
            TestPerceptionMemoire test = new TestPerceptionMemoire(false);
            TestDemonstration_Form testPerception = new TestDemonstration_Form(test);
            testPerception.Show();
        }

        private void Test1DifficultMenu_Button_Click(object sender, EventArgs e)
        {
            TestPerceptionMemoire test = new TestPerceptionMemoire(true);
            TestDemonstration_Form testPerception = new TestDemonstration_Form(test);
            testPerception.Show();
        }

        private void Test2EasyMenu_Button_Click(object sender, EventArgs e)
        {
            TestAttentionConcentration test = new TestAttentionConcentration(false);
            TestDemonstration_Form testPerception = new TestDemonstration_Form(test);
            testPerception.Show();
        }

        private void Test2DifficultMenu_Button_Click(object sender, EventArgs e)
        {
            TestAttentionConcentration test = new TestAttentionConcentration(true);
            TestDemonstration_Form testPerception = new TestDemonstration_Form(test);
            testPerception.Show();
        }

        private void Menu_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {

        }

        private void Test4EasyMenu_Button_Click(object sender, EventArgs e)
        {
            TestProblemesMathematiques test = new TestProblemesMathematiques(false);
            TestDemonstration_Form testMaths = new TestDemonstration_Form(test);
            testMaths.Show();
        }

        private void Test4DifficultMenu_Button_Click(object sender, EventArgs e)
        {
            TestProblemesMathematiques test = new TestProblemesMathematiques(true);
            TestDemonstration_Form testMaths = new TestDemonstration_Form(test);
            testMaths.Show();
        }
    }
}
