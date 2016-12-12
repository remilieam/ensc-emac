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

        private void Menu_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Test1Facile_Button_Click(object sender, EventArgs e)
        {
            TestPerceptionMemoire test = new TestPerceptionMemoire(false);
            TestDemonstration_Form testPerception = new TestDemonstration_Form(test);
            testPerception.Show();
        }

        private void Test1Difficile_Button_Click(object sender, EventArgs e)
        {
            TestPerceptionMemoire test = new TestPerceptionMemoire(true);
            TestDemonstration_Form testPerception = new TestDemonstration_Form(test);
            testPerception.Show();
        }

        private void Test2Facile_Button_Click(object sender, EventArgs e)
        {
            TestAttentionConcentration test = new TestAttentionConcentration(false);
            TestDemonstration_Form testAttention = new TestDemonstration_Form(test);
            testAttention.Show();
        }

        private void Test2Difficile_Button_Click(object sender, EventArgs e)
        {
            TestAttentionConcentration test = new TestAttentionConcentration(true);
            TestDemonstration_Form testAttention = new TestDemonstration_Form(test);
            testAttention.Show();
        }

        private void Test3Facile_Button_Click(object sender, EventArgs e)
        {
            TestCalculMental test = new TestCalculMental(false);
            TestDemonstration_Form testCalcul = new TestDemonstration_Form(test);
            testCalcul.Show();
        }

        private void Test3Difficile_Button_Click(object sender, EventArgs e)
        {
            TestCalculMental test = new TestCalculMental(true);
            TestDemonstration_Form testCalcul = new TestDemonstration_Form(test);
            testCalcul.Show();
        }

        private void Test4Facile_Button_Click(object sender, EventArgs e)
        {
            TestProblemesMathematiques test = new TestProblemesMathematiques(false);
            TestDemonstration_Form testMaths = new TestDemonstration_Form(test);
            testMaths.Show();
        }

        private void Test4Difficile_Button_Click(object sender, EventArgs e)
        {
            TestProblemesMathematiques test = new TestProblemesMathematiques(true);
            TestDemonstration_Form testMaths = new TestDemonstration_Form(test);
            testMaths.Show();
        }

        private void Test5Facile_Button_Click(object sender, EventArgs e)
        {
            TestProblemesPhysiques test = new TestProblemesPhysiques(false);
            TestDemonstration_Form testPhysique = new TestDemonstration_Form(test);
            testPhysique.Show();

        }

        private void Test5Difficile_Button_Click(object sender, EventArgs e)
        {
            TestProblemesPhysiques test = new TestProblemesPhysiques(true);
            TestDemonstration_Form testPhysique = new TestDemonstration_Form(test);
            testPhysique.Show();

        }
    }
}
