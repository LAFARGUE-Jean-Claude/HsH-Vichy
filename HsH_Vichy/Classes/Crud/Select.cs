using HsH_Vichy.Classes.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using HsH_Vichy.Classes.Naviguation;
using MySqlX.XDevAPI.Relational;
using System.Security.Cryptography;

namespace HsH_Vichy.Classes.Crud
{
    public class Select
    {
        Naviguation.Naviguation navig = new Naviguation.Naviguation();
        Dictionary<string, List<string>> contenuTables = new Dictionary<string, List<string>>();
        List<string> str = new List<string>();
       
        public Select(string tableActive)
        {
            for (int i = 0; i < navig.colonne.Count; i++)
                contenuTables.Keys.Append(navig.colonne[i]);

            ConnectionMySQL.Connection();
            string req = "SELECT * FROM " + tableActive;
            MySqlCommand cmd = new MySqlCommand(req, ConnectionMySQL.Conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Depth <= 1)
            {
                for (int i = 0; i < navig.colonne.Count; i++)
                {
                    str.Clear();
                    str.Add(dr[navig.colonne[i]].ToString());
                    contenuTables.Values.Append(str);
                }
            }
            else
            {
                for (int i = 0; i < navig.colonne.Count; i++)
                {
                    str.Clear();
                    while (dr.Read())
                    {
                        str.Add(dr[navig.colonne[i]].ToString());
                    }
                    contenuTables.Values.Append(str);
                }
            }
        }
    }
}
