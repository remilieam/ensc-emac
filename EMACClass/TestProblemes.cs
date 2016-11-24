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

        public override void Jouer()
        {
            throw new NotImplementedException();
        }
    }
}
