using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;


namespace EMACClass
{
    public class TestProblemesMathematiques : TestProblemes
    {
        public TestProblemesMathematiques(bool difficulteTest)
            : base(difficulteTest)
        {
            idTest = 4;
            nom = "Problèmes Mathématiques";
            consigne = "";
            imagesDemo = new List<string>();
            difficulte = difficulteTest;
            questions = new List<string>();
            imagesQuestion = new List<string>();
            reponses = new List<string>();
            score = 0;
            compteur = 0;
            RecupererDemonstration();
            GenererListeQuestions();
        }
    }
}
  
