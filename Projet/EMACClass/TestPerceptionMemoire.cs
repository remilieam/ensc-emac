using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestPerceptionMemoire : Test
    {
        /// <summary>
        /// Construit un nouveau test “Perception et mémoire associative”.
        /// 
        /// Initialise le score à 0.
        /// 
        /// Prend en argument le nom du test, sa consigne, sa démonstration (texte et images), sa difficulté 
        /// (false pour facile et true pour difficile), la liste des différentes questions avec les images et 
        /// les réponses associés, et l’intervalle de temps (en seconde) entre chaque question.
        /// </summary>
        /// <param name="nomTest">Nom du test</param>
        /// <param name="consigneTest">Consigne pour comprendre le test</param>
        /// <param name="demonstrationTest">Images utiles pour la démonstration</param>
        /// <param name="difficulteTest">Difficulté du test</param>
        /// <param name="questionsTest">Liste des 10 questions du test</param>
        /// <param name="ecransTest">Liste des 10 images du test</param>
        /// <param name="reponsesTest">Liste des réponses du test</param>
        /// <param name="intervalleTest">Intervalle de temps (en seconde) entre chaque question</param>
        public TestPerceptionMemoire(string nomTest, string consigneTest, List<string> demonstrationTest, bool difficulteTest, List<string> questionsTest, List<string> ecransTest, List<string> reponsesTest, int intervalleTest)
        {
            nom = nomTest;
            consigne = consigneTest;
            demonstration = demonstrationTest;
            difficulte = difficulteTest;
            questions = questionsTest;
            ecrans = ecransTest;
            reponses = reponsesTest;
            score = 0;
            intervalle = intervalleTest;
        }

        /// <summary>
        /// Permet l’enchaînement des différentes questions
        /// </summary>
        public override void Jouer()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gère l’affichage de la consigne et de la démonstration (succession d’écrans avec texte et image).
        /// </summary>
        public override void AfficherDemonstration()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Compare la entrée par l’utilisateur à la réponse juste.
        /// </summary>
        /// <param name="reponse">Chaîne de caractères correspondant à la réponse de l’utilisateur</param>
        /// <returns>Liste des erreurs (une instance = [réponse du joueur, réponse juste])</returns>
        public override List<object> VerifierReponse(string reponse)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Affiche à l’utilisateur le nombre d’erreurs qu’il a commis avec les réponses qu’il aurait dû mettre.
        /// </summary>
        /// <param name="erreurs">Liste obtenue grâce à la méthode “VerifierReponse”</param>
        public override void AfficherErreurs(List<object> erreurs)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Met à jour le score de l’utilisateur.
        /// </summary>
        /// <param name="erreurs">Liste obtenue grâce à la méthode “VerifierReponse”</param>
        public override void ModifierScore(List<object> erreurs)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calcule le résultat de l’utilisateur, c’est-à-dire sa proportion de réponses justes.
        /// </summary>
        /// <returns>Résultat de l’utilisateur</returns>
        public override double CalculerResultat()
        {
            throw new NotImplementedException();
        }
    }
}
