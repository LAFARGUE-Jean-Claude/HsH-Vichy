using HsH_Vichy.Classes.Connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsH_Vichy.Classes.Crud
{
    public class Delete
    {
        public void DeleteDatabase(string tableActive, string condition) 
        {
            ConnectionMySQL.Connection();
            string req = $"DELETE FROM {tableActive} WHERE {condition}";
            MySqlCommand cmd = new MySqlCommand(req, ConnectionMySQL.Conn);
            cmd.ExecuteNonQuery();
        }
    }
}
