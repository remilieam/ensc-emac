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
        private int decompte; // Pour faire le décompte pour l’affichage des questions

        // Constructeur du test de perception (enchaînement des questions)
        public TestPerception_Form(TestPerceptionMemoire testRecu)
        {
            InitializeComponent();
            test = testRecu;
        }

        #region Méthodes liées à des actions sur les composants du formulaire

        // Fermeture du formulaire
        private void TestPerception_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // Affichage de la première règle lors du chargement de la page et implémentation du timer (2 s en difficile, 4 s en facile)
        private void TestPerception_Form_Load(object sender, EventArgs e)
        {
            Regle_Label.Text = test.questions[compteur];
            AfficherImage_Timer.Interval = test.intervalle * 1000;
            Progression_Label.Text = "Question " + (compteur + 1) + " sur " + test.questions.Count;
        }

        // Affichage de l’image pendant 2 ou 4 secondes avec décompte
        private void Suivant_Button_Click(object sender, EventArgs e)
        {
            Regle_Label.Hide();
            Suivant_Button.Hide();
            Image_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\Test_1\\" + test.imagesQuestion[compteur];
            Image_PictureBox.Show();

            decompte = test.intervalle;
            Decompte_Label.Text = decompte.ToString();
            Chrono_Panel.Show();
            Decompte_Label.Show();
            Decompte_Timer.Start();
            AfficherImage_Timer.Start();
        }

        // Vérification de la réponse du joueur, mise à jour du score et affichage des erreurs (ou non) dans un pop-up
        private void Valider_Button_Click(object sender, EventArgs e)
        {
            Lettre1_TextBox.Text = (Lettre1_TextBox.Text != "") ? Lettre1_TextBox.Text : " ";
            Lettre2_TextBox.Text = (Lettre2_TextBox.Text != "") ? Lettre2_TextBox.Text : " ";
            Lettre3_TextBox.Text = (Lettre3_TextBox.Text != "") ? Lettre3_TextBox.Text : " ";

            string reponseJoueur = Lettre1_TextBox.Text + Lettre2_TextBox.Text + Lettre3_TextBox.Text;

            if (test.reponses[compteur].Length == 4)
            {
                Lettre4_TextBox.Text = (Lettre4_TextBox.Text != "") ? Lettre4_TextBox.Text : " ";
                reponseJoueur += Lettre4_TextBox.Text;
            }

            List<string> erreursJoueur = test.VerifierReponse(reponseJoueur, compteur);

            if (erreursJoueur[0].Length == 0)
            {
                if (MessageBox.Show("Bravo ! Vous avez tout juste !", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
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
                string message = test.AfficherErreur(erreursJoueur);

                if (MessageBox.Show(message, "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
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

        // Fermeture du formulaire à la fin du test
        private void Terminer_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Fermeture du formulaire pour retourner au menu
        private void Menu_Panel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Méthodes liées à des timers

        // Décompte
        public void Decompte_Timer_Tick(object sender, EventArgs e)
        {
            decompte--;
            Decompte_Label.Text = decompte.ToString();
        }

        // Affichage du formulaire pour répondre à la question
        public void AfficherImage_Timer_Tick(object sender, EventArgs e)
        {
            Decompte_Timer.Stop();
            AfficherImage_Timer.Stop();
            Chrono_Panel.Hide();
            Decompte_Label.Hide();

            Lettre1_Label.Text = test.lettres[compteur][0] + " :";
            Lettre2_Label.Text = test.lettres[compteur][1] + " :";
            Lettre3_Label.Text = test.lettres[compteur][2] + " :";

            Image_PictureBox.Hide();
            Lettre1_Label.Show();
            Lettre1_TextBox.Show();
            Lettre2_Label.Show();
            Lettre2_TextBox.Show();
            Lettre3_Label.Show();
            Lettre3_TextBox.Show();

            if (test.reponses[compteur].Length == 4)
            {
                Lettre4_Label.Text = test.lettres[compteur][3] + " :";
                Lettre4_Label.Show();
                Lettre4_TextBox.Show();
            }

            Valider_Button.Show();
        }

        #endregion

        #region Méthodes auxiliaires

        // Affichage de la règle
        private void AfficherRegle()
        {
            Progression_Label.Text = "Question " + (compteur + 1) + " sur " + test.questions.Count;
            Regle_Label.Text = test.questions[compteur];
            Regle_Label.Show();
            Suivant_Button.Show();

            Lettre1_Label.Hide();
            Lettre1_TextBox.Hide();
            Lettre1_TextBox.Clear();
            Lettre2_Label.Hide();
            Lettre2_TextBox.Hide();
            Lettre2_TextBox.Clear();
            Lettre3_Label.Hide();
            Lettre3_TextBox.Hide();
            Lettre3_TextBox.Clear();

            if (test.reponses[compteur-1].Length == 4)
            {
                Lettre4_Label.Hide();
                Lettre4_TextBox.Hide();
                Lettre4_TextBox.Clear();
            }

            Valider_Button.Hide();
        }

        // Affichage du résultat à l’issue des 10 questions
        public void AfficherResultat()
        {
            Regle_Label.Text = "Vous avez un taux de réussite de " + test.CalculerResultat() + " % !";
            Regle_Label.Show();
            Terminer_Button.Show();

            Lettre1_Label.Hide();
            Lettre1_TextBox.Hide();
            Lettre1_TextBox.Clear();
            Lettre2_Label.Hide();
            Lettre2_TextBox.Hide();
            Lettre2_TextBox.Clear();
            Lettre3_Label.Hide();
            Lettre3_TextBox.Hide();
            Lettre3_TextBox.Clear();

            if (test.reponses[compteur-1].Length == 4)
            {
                Lettre4_Label.Hide();
                Lettre4_TextBox.Hide();
                Lettre4_TextBox.Clear();
            }

            Valider_Button.Hide();
        }

        #endregion
    }
}
