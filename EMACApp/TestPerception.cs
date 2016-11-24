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
    public partial class TestPerception_Form : Form
    {
        public int compteur = 0;
        public TestPerceptionMemoire test = new TestPerceptionMemoire(false);

        public TestPerception_Form()
        {
            InitializeComponent();
        }

        private void TestPerceptionForm_Load(object sender, EventArgs e)
        {
            test.GetDemonstration(1);
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
            if (compteur == test.imagesDemo.Count)
            {
                compteur = 0;
            }

            else
            {
                compteur++;
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

                PictureDemo_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\" + test.imagesDemo[test.imagesDemo.Count - compteur -1];
                TextDemo_TextBox.Text = test.texteDemo[test.imagesDemo.Count - compteur - 1] + " " + compteur;
            }
        }
    }
}
