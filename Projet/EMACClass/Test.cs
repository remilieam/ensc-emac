using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMACClass
{
    public abstract class Test
    {
        // Attributs
        protected string nom;
        protected string consigne;
        protected List<string> demonstration;
        protected bool difficulte;
        protected List<string> questions;
        protected List<string> ecrans;
        protected List<string> reponses;
        protected int score;
        protected int intervalle;

        // Méthodes
        public abstract void Jouer();
        public abstract void AfficherDemonstration();
        public abstract List<Object> VerifierReponse(string reponse);
        public abstract void AfficherErreurs(List<Object> erreurs);
        public abstract void ModifierScore(List<Object> erreurs);
        public abstract double CalculerResultat();
    }
}
