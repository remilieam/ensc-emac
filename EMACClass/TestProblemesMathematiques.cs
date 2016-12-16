using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;


namespace EMACClass
{
    public class TestProblemesMathematiques : TestProblemes
    {
        /// <summary>
        /// Construit un nouveau test “Problèmes mathématiques”.
        /// Initialise le score à 0.
        /// Prend en argument la difficulté du test (false = facile, true = difficile).
        /// </summary>
        /// <param name="difficulteTest">Difficulté du test</param>
        public TestProblemesMathematiques(bool difficulteTest)
            : base(difficulteTest)
        {
            // Initialisation des attributs
            idTest = 4;
            nom = "";
            consigne = "";
            imagesDemo = new List<string>();
            difficulte = difficulteTest;
            questions = new List<string>();
            imagesQuestion = new List<string>();
            reponses = new List<string>();
            score = 0;

            // Appel aux méthodes implémentant les attributs avec la base de données
            RecupererDemonstration();
            GenererListeQuestions();
        }
    }
}
  
