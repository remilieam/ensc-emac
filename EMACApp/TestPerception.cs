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
        private TestPerceptionMemoire test; // Contient le test en cours
        private int compteur = 0; // Pour compter à quelle question on en est

        // Constructeur du test de perception (enchaînement des questions)
        public TestPerception_Form(TestPerceptionMemoire testRecu)
        {
            InitializeComponent();
            test = testRecu;
        }

        // Affichage de la première règle lors du chargement de la page et implémentation du timer (2 s en difficile, 4 s en facile)
        private void TestPerception_Form_Load(object sender, EventArgs e)
        {
            Rule_TextBox.Text = test.questions[compteur];
            DisplayPicture_Timer.Interval = test.intervalle * 1000;
        }

        // Affichage de l’image pendant 2 ou 4 secondes
        private void Next_Button_Click(object sender, EventArgs e)
        {
            Rule_TextBox.Hide();
            Next_Button.Hide();
            Picture_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\Test_1\\" + test.imagesQuestion[compteur];
            Picture_PictureBox.Show();
            DisplayPicture_Timer.Start();
            DisplayPicture_Timer.Tick += new EventHandler(DisplayPictureTimerTick);
        }

        // Affichage du formulaire pour répondre à la question
        public void DisplayPictureTimerTick(object sender, EventArgs e)
        {
            DisplayPicture_Timer.Stop();

            Letter1_Label.Text = test.lettres[compteur][0] + " :";
            Letter2_Label.Text = test.lettres[compteur][1] + " :";
            Letter3_Label.Text = test.lettres[compteur][2] + " :";

            Picture_PictureBox.Hide();
            Letter1_Label.Show();
            Letter1_TextBox.Show();
            Letter2_Label.Show();
            Letter2_TextBox.Show();
            Letter3_Label.Show();
            Letter3_TextBox.Show();

            if (test.reponses[compteur].Length == 4)
            {
                Letter4_Label.Text = test.lettres[compteur][3] + " :";
                Letter4_Label.Show();
                Letter4_TextBox.Show();
            }

            Submit_Button.Show();
        }

        // Vérification de la réponse du joueur, mise à jour du score et affichage des erreurs (ou non) dans un pop-up
        private void Submit_Button_Click(object sender, EventArgs e)
        {
            Letter1_TextBox.Text = (Letter1_TextBox.Text != "") ? Letter1_TextBox.Text : " ";
            Letter2_TextBox.Text = (Letter2_TextBox.Text != "") ? Letter2_TextBox.Text : " ";
            Letter3_TextBox.Text = (Letter3_TextBox.Text != "") ? Letter3_TextBox.Text : " ";

            string reponseJoueur = Letter1_TextBox.Text + Letter2_TextBox.Text + Letter3_TextBox.Text;

            if (test.reponses[compteur].Length == 4)
            {
                Letter4_TextBox.Text = (Letter4_TextBox.Text != "") ? Letter4_TextBox.Text : " ";
                reponseJoueur += Letter4_TextBox.Text;
            }

            List<List<string>> erreursJoueur = test.VerifierReponse(reponseJoueur, compteur);

            if (erreursJoueur.Count == 0)
            {
                if (MessageBox.Show("OK ! Vous avez tout juste !", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    test.ModifierScore(erreursJoueur, compteur);
                    compteur++;

                    if (compteur != 10)
                    {
                        this.AfficherRegle();
                    }

                    else
                    {
                        this.AfficherResultat();
                    }
                }
            }

            else
            {
                string message = test.AfficherErreurs(erreursJoueur, compteur);

                if (MessageBox.Show(message, "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    test.ModifierScore(erreursJoueur, compteur);
                    compteur++;

                    if (compteur != 10)
                    {
                        this.AfficherRegle();
                    }

                    else
                    {
                        this.AfficherResultat();
                    }

                }
            }
        }

        // Affichage de la règle
        private void AfficherRegle()
        {
            Rule_TextBox.Text = test.questions[compteur];
            Rule_TextBox.Show();
            Next_Button.Show();

            Letter1_Label.Hide();
            Letter1_TextBox.Hide();
            Letter1_TextBox.Clear();
            Letter2_Label.Hide();
            Letter2_TextBox.Hide();
            Letter2_TextBox.Clear();
            Letter3_Label.Hide();
            Letter3_TextBox.Hide();
            Letter3_TextBox.Clear();

            if (test.reponses[compteur-1].Length == 4)
            {
                Letter4_Label.Hide();
                Letter4_TextBox.Hide();
                Letter4_TextBox.Clear();
            }

            Submit_Button.Hide();
        }

        // Affichage du résultat à l’issue des 10 questions
        public void AfficherResultat()
        {
            Rule_TextBox.Text = "Vous avez un taux de réussite de " + test.CalculerResultat() + " % !";
            Rule_TextBox.Show();
            End_Button.Show();

            Letter1_Label.Hide();
            Letter1_TextBox.Hide();
            Letter1_TextBox.Clear();
            Letter2_Label.Hide();
            Letter2_TextBox.Hide();
            Letter2_TextBox.Clear();
            Letter3_Label.Hide();
            Letter3_TextBox.Hide();
            Letter3_TextBox.Clear();

            if (test.reponses[compteur-1].Length == 4)
            {
                Letter4_Label.Hide();
                Letter4_TextBox.Hide();
                Letter4_TextBox.Clear();
            }

            Submit_Button.Hide();
        }

        // Fermeture du formulaire à la fin du test
        private void End_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
