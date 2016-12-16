using EMACClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EMACTest
{
    
    
    /// <summary>
    ///Classe de test pour TestCalculMentalTest, destinée à contenir tous
    ///les tests unitaires TestCalculMentalTest
    ///</summary>
    [TestClass()]
    public class TestCalculMentalTest
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
            List<string> reponsesTest = new List<string> { "128", "745", "500" };
            TestCalculMental target = new TestCalculMental(reponsesTest);

            // Paramètres
            string reponse = "124";
            int numQuestion = 0;

            // Réel et attendu
            List<string> expected = new List<string> { "128", "124" };
            List<string> actual = target.VerifierReponse(reponse, numQuestion);

            // Vérifications
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
            List<string> reponsesTest = new List<string> { "128", "745", "500" };
            TestCalculMental target = new TestCalculMental(reponsesTest);

            // Paramètres
            List<string> erreur = new List<string> { "128", "124" };

            // Réel et attendu
            string expected = "Vous avez calculé 124 et il fallait calculer 128.";
            string actual = target.AfficherErreur(erreur);

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
            List<string> reponsesTest = new List<string> { "128", "745", "500" };
            TestCalculMental target = new TestCalculMental(reponsesTest);

            // Paramètres
            target.VerifierReponse("124", 0);
            target.VerifierReponse("745", 1);
            target.VerifierReponse("500", 2);

            // Réel et attendu
            double expected = 66.67;
            double actual = target.CalculerResultat();

            // Vérification
            Assert.AreEqual(expected, actual);
        }
    }
}
