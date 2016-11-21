using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMACClass
{
    class TestProblemesPhysiques : TestProblemes
    {
        public TestProblemesPhysiques(bool difficulteTest, int intervalleTest, List<Object> donneesTest)
            : base(difficulteTest, intervalleTest, donneesTest)
        {
            nom = "Problèmes physiques";
        }
    }
}
