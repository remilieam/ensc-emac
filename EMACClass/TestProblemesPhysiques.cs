using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestProblemesPhysiques : TestProblemes
    {
        public TestProblemesPhysiques(bool difficulteTest)
            : base(difficulteTest)
        {
            idTest = 5;
            nom = "Problèmes Physiques";
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

    




