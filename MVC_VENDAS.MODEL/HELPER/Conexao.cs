using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MVC_VENDAS.MODEL.HELPER
{
    public class Conexao
    {
        public static SqlConnection getConnection()
        {
            string StringConnection;
            StringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=banco_desenvolvimento_desktop;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection oCn = new SqlConnection(StringConnection);
            oCn.Open();
            return oCn;
        }
    }
}
