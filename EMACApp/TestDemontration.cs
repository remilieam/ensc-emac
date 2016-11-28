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

        private void TestPerceptionForm_Load(object sender, EventArgs e)
        {
            NameTest_Label.Text = test.nom;
            Instruction_TextBox.Text = test.consigne + " " + compteur;
        }

        private void Next_PictureBox_Click(object sender, EventArgs e)
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
                PictureDemo_PictureBox.Hide();
                TextDemo_TextBox.Hide();

                Instruction_TextBox.Text = test.consigne + " " + compteur;
            }

            else
            {
                Instruction_TextBox.Hide();
                PictureDemo_PictureBox.Show();
                TextDemo_TextBox.Show();

                PictureDemo_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\" + test.imagesDemo[compteur-1];
                TextDemo_TextBox.Text = test.texteDemo[compteur-1] + " " + compteur;
            }
        }

        private void Previous_PictureBox_Click(object sender, EventArgs e)
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
                PictureDemo_PictureBox.Hide();
                TextDemo_TextBox.Hide();

                Instruction_TextBox.Text = test.consigne + " " + compteur;
            }

            else
            {
                Instruction_TextBox.Hide();
                PictureDemo_PictureBox.Show();
                TextDemo_TextBox.Show();

                PictureDemo_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\" + test.imagesDemo[compteur -1];
                TextDemo_TextBox.Text = test.texteDemo[compteur - 1] + " " + compteur;
            }
        }

        private void Play_Button_Click(object sender, EventArgs e)
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

            if (test is TestProblemesMathematiques)
            {
                TestMaths_Form jeu = new TestMaths_Form((TestProblemesMathematiques)test);
                jeu.Show();
            }

            this.Close();
        }
    }
}
