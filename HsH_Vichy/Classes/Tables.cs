using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HsH_Vichy.Classes.Connexion.ConnexionMySQL;
using HsH_Vichy.Classes.Connexion.Driver;
using MySql.Data.MySqlClient;

namespace HsH_Vichy.Classes.Tables
{
    public class Tables
    {
        List<string> tables = new List<string>();
        public void RecupererTables()
        { 
            ConnexionMySQL.Connexion();
            string req = "SELECT TABLE_NAME AS tables FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='"+ConnexionMySQL.unDriver.getBaseDeDonnees()+"'";
            MySqlCommand cmd = new MySqlCommand(req, ConnexionMySQL.Conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Depth <= 1 ) 
            {
                tables.Add(dr["tables"].ToString());
            }
            else
            {
                while (dr.Read())
                {
                    tables.Add(dr["tables"].ToString());
                }
            }
        }
        public void RecupererColonne(string tables)
        {
            List<string> colonne = new List<string>();

            ConnexionMySQL.Connexion();
            string req = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '"+tables+"'";
            MySqlCommand cmd = new MySqlCommand(req, ConnexionMySQL.Conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Depth <= 1)
            {
                colonne.Add(dr["tables"].ToString());
            }
            else
            {
                while (dr.Read())
                {
                    colonne.Add(dr["tables"].ToString());
                }
            }
        }
    }
}
