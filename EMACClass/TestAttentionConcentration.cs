using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestAttentionConcentration : Test
    {
        public TestAttentionConcentration(bool difficulteTest, int intervalleTest, List<Object> donneesTest)
        {
            nom = "Attention et concentration";
            difficulte = difficulteTest;
            score = 0;
            intervalle = intervalleTest;
        }

        public override void Jouer()
        {
            throw new NotImplementedException();
        }

        public override void AfficherDemonstration()
        {
            throw new NotImplementedException();
        }

        public override List<object> VerifierReponse(string reponse)
        {
            throw new NotImplementedException();
        }

        public override void AfficherErreurs(List<object> erreurs)
        {
            throw new NotImplementedException();
        }

        public override void ModifierScore(List<object> erreurs)
        {
            throw new NotImplementedException();
        }

        public override double CalculerResultat()
        {
            throw new NotImplementedException();
        }
    }
}
