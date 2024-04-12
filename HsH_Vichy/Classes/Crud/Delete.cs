using HsH_Vichy.Classes.Connection.ConnectionMySQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types;

namespace HsH_Vichy.Classes.Crud
{
    internal class Delete
    {
        public Delete(string tableActive, string condition) 
        {
            ConnectionMySQL.Connection();
            string req = "DELETE FROM "+tableActive+" WHERE "+condition;
            MySqlCommand cmd = new MySqlCommand(req, ConnectionMySQL.Conn);
            cmd.ExecuteNonQuery();
        }
    }
}
