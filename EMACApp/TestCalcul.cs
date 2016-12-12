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
    public partial class TestCalcul_Form : Form
    {
        private TestCalculMental test; // Contient le test en cours
        private int compteurQuestion = 0; // Contient le numéro de la question en cours (10 questions au total)
        private int decompte; // Pour faire le décompte pour l’affichage des questions

        // Constructeur du test de calcul (enchaînement des questions)
        public TestCalcul_Form(TestCalculMental testRecu)
        {
            InitializeComponent();
            this.test = testRecu;

            if (test.difficulte)
            {
                AfficherQuestion_Timer.Interval = this.test.intervalle * 1000;
            }
        }

        #region Méthodes liées à des actions sur les composants du formulaire

        // Génération d’une liste d’additions et appel de la fonction affichant la première question
        private void Addition_Button_Click(object sender, EventArgs e)
        {
            this.test.GenererQuestions("Addition");
            this.CacherPremierInterface();
            this.AfficherQuestion();
        }

        // Génération d’une liste de soustractions et appel de la fonction affichant la première question
        private void Soustraction_Button_Click(object sender, EventArgs e)
        {
            this.test.GenererQuestions("Soustraction");
            this.CacherPremierInterface();
            this.AfficherQuestion();
        }

        // Génération d’une liste de multiplications et appel de la fonction affichant la première question
        private void Multiplication_Button_Click(object sender, EventArgs e)
        {
            this.test.GenererQuestions("Multiplication");
            this.CacherPremierInterface();
            this.AfficherQuestion();
        }

        // Génération d’une liste de divisions et appel de la fonction affichant la première question
        private void Division_Button_Click(object sender, EventArgs e)
        {
            this.test.GenererQuestions("Division");
            this.CacherPremierInterface();
            this.AfficherQuestion();
        }

        // Appel de la fonction affichant la réponse
        private void Valider_Button_Click(object sender, EventArgs e)
        {
            if (test.difficulte)
            {
                Decompte_Timer.Stop();
                Chrono_Panel.Hide();
                Decompte_Label.Hide();

                AfficherQuestion_Timer.Stop();
            }

            this.AfficherReponse(Reponse_TextBox.Text);
        }

        // Fermeture du formulaire
        private void Terminer_Button_Click(object sender, EventArgs e)
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

        // Événement si le chronomètre atteint 5 secondes
        private void AfficherQuestion_Timer_Tick(object sender, EventArgs e)
        {
            Decompte_Timer.Stop();
            Chrono_Panel.Hide();
            Decompte_Label.Hide();

            AfficherQuestion_Timer.Stop();
            this.AfficherReponse("0");
        }

        #endregion

        #region Méthodes auxiliaires

        // Masquage de l’interface permettant à l’utilisateur de choisir l’opération sur laquelle il veut se tester
        private void CacherPremierInterface()
        {
            Choix_TextBox.Hide();
            Addition_Button.Hide();
            Soustraction_Button.Hide();
            Multiplication_Button.Hide();
            Division_Button.Hide();
        }

        // Affichage de la question
        private void AfficherQuestion()
        {
            ProgressionTest3_TextBox.Text = "Question " + (this.compteurQuestion + 1) + " sur " + this.test.questions.Count;
            Operation_TextBlox.Text = this.test.questions[this.compteurQuestion];
            Reponse_TextBox.Clear();

            Zone_PictureBox.Show();
            Egal_Label.Show();
            ProgressionTest3_TextBox.Show();
            Operation_TextBlox.Show();
            Reponse_TextBox.Show();
            Valider_Button.Show();

            // Démarrage du chronomètre en mode difficile
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

        // Affichage du message disant si la réponse est correcte ou non
        private void AfficherReponse(string reponseJoueur)
        {
            List<string> erreurJoueur = this.test.VerifierReponse(reponseJoueur, this.compteurQuestion);

            if (erreurJoueur.Count == 0)
            {
                if (MessageBox.Show("Bravo ! Votre calcul est correct !", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    this.PasserQuestionSuivate();
                }
            }

            else
            {
                string message = this.test.AfficherErreur(erreurJoueur);

                if (MessageBox.Show(message, "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    this.PasserQuestionSuivate();
                }
            }
        }

        // Gestion du passage à la question suivante ou au résultat
        private void PasserQuestionSuivate()
        {
            Zone_PictureBox.Hide();
            Egal_Label.Hide();
            ProgressionTest3_TextBox.Hide();
            Operation_TextBlox.Hide();
            Reponse_TextBox.Hide();
            Valider_Button.Hide();

            if (compteurQuestion < 9)
            {
                this.compteurQuestion++;
                this.AfficherQuestion();
            }

            else
            {
                this.AfficherResultat();
            }
        }

        // Affichage du résultat (proportion de bonnes réponses du joueur)
        private void AfficherResultat()
        {
            Resultat_TextBox.Text = "Vous avez un taux de réussite de " + this.test.CalculerResultat() + " % !";
            Resultat_TextBox.Show();
            Terminer_Button.Show();
        }

        #endregion
    }
}
