using EMACClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EMACTest
{
    
    
    /// <summary>
    ///Classe de test pour TestAttentionConcentrationTest, destinée à contenir tous
    ///les tests unitaires TestAttentionConcentrationTest
    ///</summary>
    [TestClass()]
    public class TestAttentionConcentrationTest
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
            List<string> reponsesTest = new List<string> { "31221", "31322", "32131" };
            TestAttentionConcentration target = new TestAttentionConcentration(reponsesTest);

            // Paramètres
            string reponse = "3";
            int numQuestion = 2;

            // Réel et attendu
            List<string> expected = new List<string> { "2", "3" };
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
            List<string> reponsesTest = new List<string> { "31221", "31322", "32131" };
            TestAttentionConcentration target = new TestAttentionConcentration(reponsesTest);

            // Paramètres
            List<string> erreur = new List<string> { "2", "3" };

            // Réel et attendu
            string expected = "Vous avez cliqué sur le bouton 3 au lieu du bouton 2.";
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
            List<string> reponsesTest = new List<string> { "31221", "31322", "32131" };
            TestAttentionConcentration target = new TestAttentionConcentration(reponsesTest);

            // Paramètres
            target.VerifierReponse("3", 0);
            target.VerifierReponse("1", 1);
            target.VerifierReponse("3", 2);
            target.VerifierReponse("2", 3);
            target.VerifierReponse("1", 4);

            target.VerifierReponse("3", 5);
            target.VerifierReponse("2", 6);
            target.VerifierReponse("3", 7);
            target.VerifierReponse("1", 8);
            target.VerifierReponse("2", 9);

            target.VerifierReponse("3", 10);
            target.VerifierReponse("3", 11);
            target.VerifierReponse("1", 12);
            target.VerifierReponse("3", 13);
            target.VerifierReponse("1", 14);

            // Réel et attendu
            double expected = 73.33;
            double actual = target.CalculerResultat();

            // Vérification
            Assert.AreEqual(expected, actual);
        }
    }
}
