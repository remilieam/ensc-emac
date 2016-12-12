using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EMACClass;

namespace EMACApp
{
    public partial class TestDemonstration_Form : Form
    {
        private int compteur = 0;
        private Test test;

        public TestDemonstration_Form(Test testRecu)
        {
            InitializeComponent();
            test = testRecu;
        }

        private void TestPerception_Form_Load(object sender, EventArgs e)
        {
            NomTest_Label.Text = test.nom;
            Instruction_TextBox.Text = test.consigne + " " ;
        }

        private void Suivant_PictureBox_Click(object sender, EventArgs e)
        {
            if (compteur == test.imagesDemo.Count)
            {
                compteur = 0;
            }

            else
            {
                compteur++;
            }

            if(compteur == 0)
            {
                Instruction_TextBox.Show();
                ImageDemo_PictureBox.Hide();
                TexteDemo_TextBox.Hide();

                Instruction_TextBox.Text = test.consigne + " " ;
            }

            else
            {
                Instruction_TextBox.Hide();
                ImageDemo_PictureBox.Show();
                //TextDemo_TextBox.Show();

                ImageDemo_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\" + test.imagesDemo[compteur-1];
                TexteDemo_TextBox.Text = test.texteDemo[compteur - 1] + " "  ;
            }
        }

        private void Precedent_PictureBox_Click(object sender, EventArgs e)
        {
            if (compteur == 0)
            {
                compteur = test.imagesDemo.Count;
            }

            else
            {
                compteur--;
            }

            if (compteur == 0)
            {
                Instruction_TextBox.Show();
                ImageDemo_PictureBox.Hide();
                TexteDemo_TextBox.Hide();

                Instruction_TextBox.Text = test.consigne + " " + compteur;
            }

            else
            {
                Instruction_TextBox.Hide();
                ImageDemo_PictureBox.Show();
                //TextDemo_TextBox.Show();

                ImageDemo_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\" + test.imagesDemo[compteur - 1];
                TexteDemo_TextBox.Text = test.texteDemo[compteur-1] + " " + compteur;
            }
        }

        private void Jouer_Button_Click(object sender, EventArgs e)
        {
            if (test is TestPerceptionMemoire)
            {
                TestPerception_Form jeu = new TestPerception_Form((TestPerceptionMemoire)test);
                jeu.Show();
            }

            if (test is TestAttentionConcentration)
            {
                TestAttention_Form jeu = new TestAttention_Form((TestAttentionConcentration)test);
                jeu.Show();
            }

            if (test is TestCalculMental)
            {
                TestCalcul_Form jeu = new TestCalcul_Form((TestCalculMental)test);
                jeu.Show();
            }

            if (test is TestProblemesMathematiques)
            {
                TestMaths_Form jeu = new TestMaths_Form((TestProblemesMathematiques)test);
                jeu.Show();
            }

            if (test is TestProblemesPhysiques)
            {
                TestPhysique_Form jeu = new TestPhysique_Form((TestProblemesPhysiques)test);
                jeu.Show();
            }

            this.Close();
        }

        // Fermeture du formulaire pour retourner au menu
        private void Menu_Panel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
