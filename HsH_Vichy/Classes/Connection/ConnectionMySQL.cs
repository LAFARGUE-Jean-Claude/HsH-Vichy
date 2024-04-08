using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HsH_Vichy.Classes.Connection.Driver;

namespace HsH_Vichy.Classes.Connection.ConnectionMySQL
{
    public class ConnectionMySQL
    {
        // Valeur par défaut d'un driver
        public static Driver.Driver unDriver = new Driver.Driver("localhost", "avions", "root", "");

        // Modification du driver
        public void Authentification(string serveur, string baseDeDonnees, string utilisateur, string motDePasse)
        {
            
            unDriver.setServeur(serveur);
            unDriver.setBaseDeDonnees(baseDeDonnees);
            unDriver.setUtilisateur(utilisateur);
            unDriver.setMotDePasse(motDePasse);
        }

        // Instantiation d'un objet MySqlConnection
        public static MySqlConnection Conn;

        public static void Connection()
        {
            // Création de la requête et ouverture de la connexion
            string req = "server='" + unDriver.getServeur() + "';initial catalog='" + unDriver.getBaseDeDonnees() + "';user id='" + unDriver.getUtilisateur() + "';password ='" + unDriver.getMotDePasse() + "'";
            Conn = new MySqlConnection(req);
            Conn.Open();
        }
    }
}
