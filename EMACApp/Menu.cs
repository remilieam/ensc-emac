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
            try
            {
                TestPerceptionMemoire test = new TestPerceptionMemoire(false);
                TestDemonstration_Form testDemoPerception = new TestDemonstration_Form(test);

                this.Hide();

                if (testDemoPerception.ShowDialog() == DialogResult.OK)
                {
                    TestPerception_Form testPerception = new TestPerception_Form(test);

                    if (testPerception.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }
                }

                else
                {
                    this.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Impossible de générer le test...", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Test1Difficile_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestPerceptionMemoire test = new TestPerceptionMemoire(true);
                TestDemonstration_Form testDemoPerception = new TestDemonstration_Form(test);

                this.Hide();

                if (testDemoPerception.ShowDialog() == DialogResult.OK)
                {
                    TestPerception_Form testPerception = new TestPerception_Form(test);

                    if (testPerception.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }
                }

                else
                {
                    this.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Impossible de générer le test...", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Test2Facile_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestAttentionConcentration test = new TestAttentionConcentration(false);
                TestDemonstration_Form testDemoAttention = new TestDemonstration_Form(test);

                this.Hide();

                if (testDemoAttention.ShowDialog() == DialogResult.OK)
                {
                    TestAttention_Form testAttention = new TestAttention_Form(test);

                    if (testAttention.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }
                }

                else
                {
                    this.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Impossible de générer le test...", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Test2Difficile_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestAttentionConcentration test = new TestAttentionConcentration(true);
                TestDemonstration_Form testDemoAttention = new TestDemonstration_Form(test);

                this.Hide();

                if (testDemoAttention.ShowDialog() == DialogResult.OK)
                {
                    TestAttention_Form testAttention = new TestAttention_Form(test);

                    if (testAttention.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }
                }

                else
                {
                    this.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Impossible de générer le test...", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Test3Facile_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestCalculMental test = new TestCalculMental(false);
                TestDemonstration_Form testDemoCalcul = new TestDemonstration_Form(test);

                this.Hide();

                if (testDemoCalcul.ShowDialog() == DialogResult.OK)
                {
                    TestCalcul_Form testCalcul = new TestCalcul_Form(test);

                    if (testCalcul.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }
                }

                else
                {
                    this.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Impossible de générer le test...", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Test3Difficile_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestCalculMental test = new TestCalculMental(true);
                TestDemonstration_Form testDemoCalcul = new TestDemonstration_Form(test);

                this.Hide();

                if (testDemoCalcul.ShowDialog() == DialogResult.OK)
                {
                    TestCalcul_Form testCalcul = new TestCalcul_Form(test);

                    if (testCalcul.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }
                }

                else
                {
                    this.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Impossible de générer le test...", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Test4Facile_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestProblemesMathematiques test = new TestProblemesMathematiques(false);
                TestDemonstration_Form testDemoMaths = new TestDemonstration_Form(test);

                this.Hide();

                if (testDemoMaths.ShowDialog() == DialogResult.OK)
                {
                    TestMaths_Form testMaths = new TestMaths_Form(test);

                    if (testMaths.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }
                }

                else
                {
                    this.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Impossible de générer le test...", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Test4Difficile_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestProblemesMathematiques test = new TestProblemesMathematiques(true);
                TestDemonstration_Form testDemoMaths = new TestDemonstration_Form(test);

                this.Hide();

                if (testDemoMaths.ShowDialog() == DialogResult.OK)
                {
                    TestMaths_Form testMaths = new TestMaths_Form(test);

                    if (testMaths.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }
                }

                else
                {
                    this.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Impossible de générer le test...", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Test5Facile_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestProblemesPhysiques test = new TestProblemesPhysiques(false);
                TestDemonstration_Form testDemoPhysiques = new TestDemonstration_Form(test);

                this.Hide();

                if (testDemoPhysiques.ShowDialog() == DialogResult.OK)
                {
                    TestPhysique_Form testPhysiques = new TestPhysique_Form(test);

                    if (testPhysiques.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }
                }

                else
                {
                    this.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Impossible de générer le test...", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Test5Difficile_Button_Click(object sender, EventArgs e)
        {
            try
            {
                TestProblemesPhysiques test = new TestProblemesPhysiques(true);
                TestDemonstration_Form testDemoPhysiques = new TestDemonstration_Form(test);

                this.Hide();

                if (testDemoPhysiques.ShowDialog() == DialogResult.OK)
                {
                    TestPhysique_Form testPhysiques = new TestPhysique_Form(test);

                    if (testPhysiques.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }
                }

                else
                {
                    this.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Impossible de générer le test...", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
