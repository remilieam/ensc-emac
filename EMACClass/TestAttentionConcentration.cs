using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestAttentionConcentration : Test
    {
        // Attribut
        public List<List<string>> imagesSeries { get; private set; }

        /// <summary>
        /// Construit un nouveau test “Attention et concentration”.
        /// Initialise le score à 0.
        /// Prend en argument la difficulté du test (false = facile, true = difficile)
        /// </summary>
        /// <param name="difficulteTest">Difficulté du test</param>
        public TestAttentionConcentration(bool difficulteTest)
        {
            nom = "";
            consigne = "";
            imagesDemo = new List<string>();
            texteDemo = new List<string>();
            difficulte = difficulteTest;
            questions = new List<string>();
            imagesQuestion = new List<string>();
            reponses = new List<string>();
            score = 0;
            intervalle = (difficulte) ? 3 : 0;
            imagesSeries = new List<List<string>>();

            RecupererDemonstration(2);
            GenererListeQuestions(2, 3);
            SeparerImages();
        }

        /// <summary>
        /// Sépare les images pour chaque série en les regroupant par paquet de 5.
        /// </summary>
        private void SeparerImages()
        {
            int nbImages = 0;

            for (int i = 0; i < this.questions.Count; i++)
            {
                List<string> imagesSerie = new List<string>();

                for (int j = 0; j < 5; j++)
                {
                    imagesSerie.Add(imagesQuestion[nbImages]);
                    nbImages++;
                }

                imagesSeries.Add(imagesSerie);
            }
        }

        /// <summary>
        /// Compare la réponse entrée par l’utilisateur à la réponse juste.
        /// </summary>
        /// <param name="reponse">Chaîne de caractères correspondant à la réponse de l’utilisateur</param>
        /// <param name="numSerie">Numéro de la série à laquelle appartient la question</param>
        /// <param name="numQuestion">Numéro de la question à vérifier</param>
        /// <returns>Liste avec [réponse juste, réponse du joueur]</returns>
        public List<string> VerifierBouton(string reponse, int numSerie, int numQuestion)
        {
            List<string> erreurs = new List<string>();

            if (this.reponses[numSerie][numQuestion].ToString() != reponse)
            {
                erreurs.Add(this.reponses[numSerie][numQuestion].ToString());
                erreurs.Add(reponse.ToString());
            }

            return erreurs;
        }

        /// <summary>
        /// Affiche à l’utilisateur son erreur.
        /// </summary>
        /// <param name="erreur">Liste obtenue grâce à la méthode “VerifierBouton”</param>
        /// <returns>Chaîne de caractères à afficher au joueur</returns>
        public string AfficherErreur(List<string> erreur)
        {
            if (erreur[1] == "0")
            {
                return "Vous n’avez cliqué sur aucun bouton.\r\nPour information, il fallait appuyer sur bouton " + erreur[0] + ".";
            }

            return "Vous avez cliquez sur le bouton " + erreur[1] + " au lieu du bouton " + erreur[0] + ".";
        }

        /// <summary>
        /// Calcule le résultat de l’utilisateur, c’est-à-dire sa proportion de réponses justes.
        /// </summary>
        /// <returns>Résultat de l’utilisateur</returns>
        public override double CalculerResultat()
        {
            return this.score / (this.reponses.Count * 5.0) * 100.0;
        }
    }
}
