using HsH_Vichy.Classes.Connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsH_Vichy.Classes.Commandes
{
    internal class Insert
    {
        Naviguation.Naviguation navig = new Naviguation.Naviguation();
        public void InsertDatabase(string tableActive, string commande)
        {
            string colonnes = navig.colonne[0];
            for (int i = 1; i < navig.colonne.Count; i++)
                colonnes += ","+navig.colonne[i];

            ConnectionMySQL.Connection();
            string req = $"INSERT INTO {tableActive} ({colonnes}) values ({commande})";
            MySqlCommand cmd = new MySqlCommand(req, ConnectionMySQL.Conn);
            cmd.ExecuteNonQuery();
        }
    }
}
