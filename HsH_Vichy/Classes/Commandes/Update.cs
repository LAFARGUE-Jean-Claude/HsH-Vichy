﻿using HsH_Vichy.Classes.Connection;
using HsH_Vichy.Classes.Naviguation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI.Relational;

namespace HsH_Vichy.Classes.Crud
{
    public class Update
    {
        public void UpdateDatabase(string tableActive, string colonneSelectionne, string nouvelleValeur, string condition) 
        {
            ConnectionMySQL.Connection();
            string req = $"UPDATE {tableActive} SET {colonneSelectionne} = {nouvelleValeur} WHERE {condition}";
            MySqlCommand cmd = new MySqlCommand(req, ConnectionMySQL.Conn);
            cmd.ExecuteNonQuery();
        }
    }
}
