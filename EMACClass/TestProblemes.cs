using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestProblemes : Test
    {
        public TestProblemes(bool difficulteTest, int intervalleTest, List<Object> donneesTest)
        {
            difficulte = difficulteTest;
            score = 0;
            intervalle = intervalleTest;
        }

        public override List<string> VerifierReponse(string reponse, int numQuestion)
        {
            return new List<string>();
        }

        public override string AfficherErreur(List<string> erreurs)
        {
            return "";
        }

        public override double CalculerResultat()
        {
            return 0;
        }

        protected override void RecupererDemonstration()
        {
        }

        protected override void GenererListeQuestions()
        {
        }
    }
}
