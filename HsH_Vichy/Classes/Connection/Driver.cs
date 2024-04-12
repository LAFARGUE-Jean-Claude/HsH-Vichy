using Microsoft.SqlServer.Server;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsH_Vichy.Classes.Connection
{
    public class Driver
    {
        // Attributs
        string serveur;
        string baseDeDonnees;
        string utilisateur;
        string motDePasse;

        // Constructeur vide
        public Driver() { }

        // Constructeur surchargé
        public Driver(string serveur, string baseDeDonnees, string utilisateur, string motDePasse)
        {
            this.serveur = serveur;
            this.baseDeDonnees = baseDeDonnees;
            this.utilisateur = utilisateur;
            this.motDePasse = motDePasse;
        }

        // Accesseur en Lecture
        public string getServeur() {  return this.serveur; }
        public string getBaseDeDonnees() {  return this.baseDeDonnees; }
        public string getUtilisateur() {  return this.utilisateur; }
        public string getMotDePasse() {  return this.motDePasse; }

        // Accesseur en Ecriture
        public void setServeur(string serveur) {  this.serveur = serveur; }
        public void setBaseDeDonnees(string baseDeDonnees) { this.baseDeDonnees=baseDeDonnees; }
        public void setUtilisateur(string utilisateur) { this.utilisateur=utilisateur; }
        public void setMotDePasse(string motDePasse) { this.motDePasse=motDePasse; }
    }
}
