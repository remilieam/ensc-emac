using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMACClass
{
    class TestProblemesMathematiques : TestProblemes
    {
        public TestProblemesMathematiques(bool difficulteTest, int intervalleTest, List<Object> donneesTest)
            : base(difficulteTest, intervalleTest, donneesTest)
        {
            nom = "Problèmes mathématiques";
        }
    }
}
