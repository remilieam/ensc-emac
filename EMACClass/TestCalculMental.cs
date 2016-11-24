using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public class TestCalculMental : Test
    {
        public TestCalculMental(bool difficulteTest, int intervalleTest, List<Object> donneesTest)
        {
            nom = "Calcul mental";
            difficulte = difficulteTest;
            score = 0;
            intervalle = intervalleTest;
        }

        public override void Jouer()
        {
            throw new NotImplementedException();
        }
    }
}
