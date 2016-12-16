using EMACClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EMACTest
{


    /// <summary>
    ///Classe de test pour TestProblemesTest, destinée à contenir tous
    ///les tests unitaires TestProblemesTest
    ///</summary>
    [TestClass()]
    public class TestProblemesTest
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
            // Création d’un test avec 1 comme réponse théorique à la première question
            List<string> reponsesTest = new List<string> { "1" };
            TestProblemes target = new TestProblemes(reponsesTest);

            // Paramètres
            // Le joueur répond 3 à la première question
            string reponse = "3";
            int numQuestion = 0;

            // Réel et attendu
            List<string> actual = target.VerifierReponse(reponse, numQuestion);
            List<string> expected = new List<string> { "1", "3" };

            // Vérifications
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        /// <summary>
        ///Test pour CalculerResultat
        ///</summary>
        [TestMethod()]
        public void CalculerResultatTest()
        {
            // Création d’un test
            List<string> reponsesTest = new List<string> { "1", "3" };
            TestProblemes target = new TestProblemes(reponsesTest);

            // Pré-requis
            target.VerifierReponse("1", 0);
            target.VerifierReponse("2", 1);

            // Réel et attendu
            double expected = 50;
            double actual = target.CalculerResultat();

            // Vérification
            Assert.AreEqual(expected, actual);
        }
    }
}