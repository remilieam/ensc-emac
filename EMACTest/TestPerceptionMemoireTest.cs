using EMACClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EMACTest
{


    /// <summary>
    ///Classe de test pour TestPerceptionMemoireTest, destinée à contenir tous
    ///les tests unitaires TestPerceptionMemoireTest
    ///</summary>
    [TestClass()]
    public class TestPerceptionMemoireTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour VerifierReponse
        ///</summary>
        [TestMethod()]
        public void VerifierReponseTest()
        {
            // Création d’un test
            List<string> reponsesTest = new List<string> { "341", "532" };
            List<string> lettresTest = new List<string> { "AFH", "BDG" };
            TestPerceptionMemoire target = new TestPerceptionMemoire(reponsesTest, lettresTest);

            // Paramètres
            string reponse = "245";
            int numQuestion = 0;

            // Réel et attendu
            List<string> actual = target.VerifierReponse(reponse, numQuestion);
            List<string> expected = new List<string> { "AH", "31", "25" };

            // Vérifiations
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        /// <summary>
        ///Test pour AfficherErreur
        ///</summary>
        [TestMethod()]
        public void AfficherErreurTest()
        {
            // Création d’un test
            List<string> reponsesTest = new List<string> { "341", "532" };
            List<string> lettresTest = new List<string> { "AFH", "BDG" };
            TestPerceptionMemoire target = new TestPerceptionMemoire(reponsesTest, lettresTest);

            // Paramètres
            List<string> erreurs = new List<string> { "AH", "31", "25" };

            // Réel et attendu
            string actual = target.AfficherErreur(erreurs);
            string expected = "Vous avez commis des erreurs. Vous avez répondu :\r\n";
            expected += "  –  en A, 2 au lieu de 3\r\n";
            expected += "  –  en H, 5 au lieu de 1\r\n";

            // Vérification
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour CalculerResultat
        ///</summary>
        [TestMethod()]
        public void CalculerResultatTest()
        {
            // Création d’un test
            List<string> reponsesTest = new List<string> { "341", "532" };
            List<string> lettresTest = new List<string> { "AFH", "BDG" };
            TestPerceptionMemoire target = new TestPerceptionMemoire(reponsesTest, lettresTest);

            // Pré-requis
            target.VerifierReponse("245", 0);
            target.VerifierReponse("531", 1);

            // Réel et attendu
            double expected = 50;
            double actual = target.CalculerResultat();

            // Vérification
            Assert.AreEqual(expected, actual);
        }
    }
}
