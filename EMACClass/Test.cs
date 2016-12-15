using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public abstract class Test
    {
        // Lien vers la base de données
        protected const string BDD = "|DataDirectory|\\AppData\\EMAC.mdb";

        // Attributs
        public string nom { get; protected set; }
        public string consigne { get; protected set; }
        public List<string> imagesDemo { get; protected set; }
        public bool difficulte { get; protected set; }
        public List<string> questions { get; protected set; }
        public List<string> imagesQuestion { get; protected set; }
        public List<string> reponses { get; protected set; }
        public int score { get; protected set; }
        public int intervalle { get; protected set; }

        // Méthodes
        public abstract List<string> VerifierReponse(string reponse, int numQuestion);
        public abstract string AfficherErreur(List<string> erreurs);
        public abstract double CalculerResultat();
        protected abstract void RecupererDemonstration();
        protected abstract void GenererListeQuestions();
    }
}
