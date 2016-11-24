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
        /// Initialise le score à 0.
        /// Prend en argument la difficulté du test (false = facile, true = difficile)
        /// </summary>
        /// <param name="difficulteTest">Difficulté du test</param>
        public TestPerceptionMemoire(bool difficulteTest)
        {
            difficulte = difficulteTest;
            score = 0;
            nom = "";
            consigne = "";
            imagesDemo = new List<string>();
            texteDemo = new List<string>();
            questions = new List<string>();
            imagesQuestion = new List<string>();
            reponses = new List<string>();
            intervalle = (difficulte)?2:4;
        }

        public override void Jouer()
        {
            throw new NotImplementedException();
        }
    }
}
