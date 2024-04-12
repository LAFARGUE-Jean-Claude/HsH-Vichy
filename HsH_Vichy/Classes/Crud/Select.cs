using HsH_Vichy.Classes.Connection.ConnectionMySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using HsH_Vichy.Classes.Tables;
using Org.BouncyCastle.Ocsp;
using MySqlX.XDevAPI.Relational;

namespace HsH_Vichy.Classes.Crud
{
    public class Select
    {
        public Select(string tableActive)
        {
            ConnectionMySQL.Connection();
            string req = "SELECT * FROM " + tableActive;
            MySqlCommand cmd = new MySqlCommand(req, ConnectionMySQL.Conn);
            MySqlDataReader dr = cmd.ExecuteReader();

        }
    }
}
