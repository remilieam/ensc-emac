using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestPerceptionMemoire : Test
    {
        // Attribut
        public List<string> lettres { get; private set; }

        /// <summary>
        /// Construit un nouveau test “Perception et mémoire associative”.
        /// Initialise le score à 0.
        /// Prend en argument la difficulté du test (false = facile, true = difficile)
        /// </summary>
        /// <param name="difficulteTest">Difficulté du test</param>
        public TestPerceptionMemoire(bool difficulteTest)
        {
            nom = "";
            consigne = "";
            imagesDemo = new List<string>();
            texteDemo=new List<string>();
            difficulte = difficulteTest;
            questions = new List<string>();
            imagesQuestion = new List<string>();
            reponses = new List<string>();
            score = 0;
            intervalle = (difficulte) ? 2 : 4;
            lettres = new List<string>();

            GetDemonstration(1);
            GenerateListQuestions(1, 10);
            SeparationLettresReponses();
        }

        /// <summary>
        /// Sépare les lettres et les chiffres de toutes les réponses du test. 
        /// Par exemple, si la réponse à une question est A2F4H7, on sépare d’un côté A, F et H et de l’autre 2, 4 et 7.
        /// </summary>
        private void SeparationLettresReponses()
        {
            List<string> chiffres = new List<string>();

            for (int i = 0; i < this.reponses.Count; i++)
            {
                string chaineLettres = "";
                string chaineChiffres = "";

                for (int j = 0; j < this.reponses[i].Length - 1; j += 2)
                {
                    chaineLettres += this.reponses[i][j];
                    chaineChiffres += this.reponses[i][j + 1];
                }

                this.lettres.Add(chaineLettres);
                chiffres.Add(chaineChiffres);
            }

            this.reponses = chiffres;
        }

        /// <summary>
        /// Calcule le résultat de l’utilisateur, c’est-à-dire sa proportion de réponses justes.
        /// </summary>
        /// <returns>Résultat de l’utilisateur</returns>
        public override double CalculerResultat()
        {
            double nbQuestions = 0;

            for (int i = 0; i < this.reponses.Count; i++)
            {
                nbQuestions += this.reponses[i].Length;
            }

            return this.score / nbQuestions * 100.0;
        }

    }
}
