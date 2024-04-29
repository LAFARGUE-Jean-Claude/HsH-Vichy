﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HsH_Vichy.Classes.Connection;
using MySql.Data.MySqlClient;

namespace HsH_Vichy.Classes.Naviguation
{

    public class Naviguation
    {
        public List<string> tables = new List<string>();
        public List<string> colonne = new List<string>();
        public void AllTable()
        { 
            ConnectionMySQL.Connection();
            string req = "SELECT TABLE_NAME AS tables FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='"+ConnectionMySQL.unDriver.getBaseDeDonnees()+"'";
            MySqlCommand cmd = new MySqlCommand(req, ConnectionMySQL.Conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tables.Add(dr["tables"].ToString());
            }
            
            ConnectionMySQL.Disconnect();
        }
        public void RecupererColonne(string tables)
        {
            ConnectionMySQL.Connection();
            string req = "SELECT COLUMN_NAME AS colonnes FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '"+tables+"'";
            MySqlCommand cmd = new MySqlCommand(req, ConnectionMySQL.Conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                colonne.Add(dr["colonnes"].ToString());
            }

            ConnectionMySQL.Disconnect();
        }
    }
}
