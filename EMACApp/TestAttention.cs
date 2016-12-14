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
    public partial class TestAttention_Form : Form
    {
        private TestAttentionConcentration test; // Contient le test en cours
        private int compteurSerie = 0; // Contient le numéro de la série en cours (3 séries au total)
        private int compteurQuestion = 0; // Contient le numéro de la question en cours (5 questions par série)
        private int decompte; // Pour faire le décompte pour l’affichage des questions

        // Constructeur du test d’attention (enchaînement des questions)
        public TestAttention_Form(TestAttentionConcentration testRecu)
        {
            InitializeComponent();
            this.test = testRecu;
        }

        #region Méthodes liées à des actions sur les composants du formulaire

        // Fermeture du formulaire
        private void TestAttention_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // Affichage de la première règle et définition du chronomètre si le joueur a choisi le mode difficile
        private void TestAttention_Form_Load(object sender, EventArgs e)
        {
            ProgressionTest2_TextBox.Text = "Série : " + (this.compteurSerie + 1) + "    –    Question : " + (this.compteurQuestion + 1);

            if (test.difficulte)
            {
                Regle_TextBox.Text = "Consigne de la série " + (this.compteurSerie + 1) + " :\r\n\r\n" + this.test.questions[this.compteurSerie];
                AfficherQuestion_Timer.Interval = this.test.intervalle * 1000;
            }

            else
            {
                Regle_TextBox.Text = "Consigne pour les 3 séries de questions :\r\n\r\n" + this.test.questions[compteurSerie];
            }
        }
        
        // Appel de la fonction qui affiche la question
        private void Suivant_Button_Click(object sender, EventArgs e)
        {
            Regle_TextBox.Hide();
            Suivant_Button.Hide();

            this.AfficherQuestion();
        }

        // Affichage de la réponse dans le cas où on a appuyé sur le bouton 1
        private void Bouton1_Button_Click(object sender, EventArgs e)
        {
            if (test.difficulte)
            {
                AfficherQuestion_Timer.Stop();
                Decompte_Timer.Stop();
                Chrono_Panel.Hide();
                Decompte_Label.Hide();
            }

            this.AfficherReponse("1");
        }

        // Affichage de la réponse dans le cas où on a appuyé sur le bouton 2
        private void Bouton2_Button_Click(object sender, EventArgs e)
        {
            if (test.difficulte)
            {
                AfficherQuestion_Timer.Stop();
                Decompte_Timer.Stop();
                Chrono_Panel.Hide();
                Decompte_Label.Hide();
            }

            this.AfficherReponse("2");
        }

        // Affichage de la réponse dans le cas où on a appuyé sur le bouton 3
        private void Bouton3_Button_Click(object sender, EventArgs e)
        {
            if (test.difficulte)
            {
                AfficherQuestion_Timer.Stop();
                Decompte_Timer.Stop();
                Chrono_Panel.Hide();
                Decompte_Label.Hide();
            }

            this.AfficherReponse("3");
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

        // Affichage de la réponse dans le cas où on n’a pas répondu à temps
        public void AfficherQuestion_Timer_Tick(object sender, EventArgs e)
        {
            Decompte_Timer.Stop();
            Chrono_Panel.Hide();
            Decompte_Label.Hide();

            AfficherQuestion_Timer.Stop();
            this.AfficherReponse("0");
        }

        #endregion

        #region Méthodes auxiliaires

        // Affichage de la consigne à suivre dans la série ou les 3 séries
        private void AfficherConsigne()
        {
            ProgressionTest2_TextBox.Text = "Série : " + (this.compteurSerie + 1) + "    –    Question : " + (this.compteurQuestion + 1);

            if (test.difficulte)
            {
                Regle_TextBox.Text = "Consigne de la série " + this.compteurSerie + " :\r\n\r\n" + test.questions[this.compteurSerie];
            }

            Regle_TextBox.Show();
            Suivant_Button.Show();
        }

        // Affichage de l’image et des boutons
        private void AfficherQuestion()
        {
            ProgressionTest2_TextBox.Text = "Série : " + (this.compteurSerie + 1) + "    –    Question : " + (this.compteurQuestion + 1);

            Objet_PictureBox.ImageLocation = "..\\..\\..\\EMACApp\\AppImages\\Test_2\\" + this.test.imagesSeries[this.compteurSerie][this.compteurQuestion];
            Objet_PictureBox.Show();
            Zone_PictureBox.Show();
            Bouton3_Button.Show();

            if (compteurQuestion != 0)
            {
                Bouton2_Button.Show();
                Bouton1_Button.Show();
            }

            if (test.difficulte)
            {
                decompte = test.intervalle;
                Chrono_Panel.Show();
                Decompte_Label.Show();
                Decompte_Label.Text = decompte.ToString();
                Decompte_Timer.Start();
                AfficherQuestion_Timer.Start();
            }
        }

        // Affichage de la réponse selon si elle est juste ou non
        private void AfficherReponse(string reponseJoueur)
        {
            Objet_PictureBox.Hide();
            Zone_PictureBox.Hide();
            Bouton1_Button.Hide();
            Bouton2_Button.Hide();
            Bouton3_Button.Hide();

            List<string> erreurJoueur = this.test.VerifierReponse(reponseJoueur, this.compteurSerie * 5 + this.compteurQuestion);

            if (erreurJoueur.Count == 0)
            {
                TestResultat_Form resultat = new TestResultat_Form("OK ! Vous avez choisi le bon bouton !");

                if (resultat.ShowDialog() == DialogResult.OK)
                {
                    resultat.Close();
                    this.PasserQuestionSuivante();
                }
            }

            else
            {
                TestResultat_Form resultat = new TestResultat_Form(this.test.AfficherErreur(erreurJoueur));

                if (resultat.ShowDialog() == DialogResult.OK)
                {
                    resultat.Close();
                    this.PasserQuestionSuivante();
                }
            }
        }

        // Gestion du passage à la question suivante
        private void PasserQuestionSuivante()
        {
            // Cas où on n’en est pas à la dernière série de questions
            if (this.compteurSerie < 2)
            {
                // Cas où on n’est pas à la dernière question de la série
                if (this.compteurQuestion < 4)
                {
                    // Passage à la question suivante
                    this.compteurQuestion++;
                    this.AfficherQuestion();
                }

                // Cas où on vient de faire la dernière question de la série
                else
                {
                    // Passage à la série suivante
                    this.compteurSerie++;
                    this.compteurQuestion = 0;
                    if (this.test.difficulte) { this.AfficherConsigne(); }
                    else { this.AfficherQuestion(); }
                }
            }

            // Cas où on en train de faire la dernière série
            else
            {
                // Cas où on n’est pas à la dernière question de la dernière série
                if (this.compteurQuestion < 4)
                {
                    // Passage à la question suivante
                    this.compteurQuestion++;
                    this.AfficherQuestion();
                }

                // Cas où on vient de faire la dernière question de la dernière série
                else
                {
                    // Affichage du résultat final
                    this.AfficherResultat();
                }
            }
        }

        // Affichage du résultat à l’issue des 3 séries de 5 questions
        private void AfficherResultat()
        {
            Resultat_TextBox.Text = "Vous avez un taux de réussite de " + test.CalculerResultat() + " % !";
            Resultat_TextBox.Show();
            Terminer_Button.Show();
        }

        #endregion
    }
}
