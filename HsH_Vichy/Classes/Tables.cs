using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HsH_Vichy.Classes.Connection.ConnectionMySQL;
using MySql.Data.MySqlClient;

namespace HsH_Vichy.Classes.Tables
{
    public class Tables
    {
        public List<string> tables = new List<string>();
        public List<string> colonne = new List<string>();
        public void RecupererTables()
        { 
            ConnectionMySQL.Connection();
            string req = "SELECT TABLE_NAME AS tables FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='"+ConnectionMySQL.unDriver.getBaseDeDonnees()+"'";
            MySqlCommand cmd = new MySqlCommand(req, ConnectionMySQL.Conn);
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
            ConnectionMySQL.Connection();
            string req = "SELECT COLUMN_NAME AS colonnes FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '"+tables+"'";
            MySqlCommand cmd = new MySqlCommand(req, ConnectionMySQL.Conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Depth <= 1)
            {
                colonne.Add(dr["colonnes"].ToString());
            }
            else
            {
                while (dr.Read())
                {
                    colonne.Add(dr["colonnes"].ToString());
                }
            }
        }
    }
}
