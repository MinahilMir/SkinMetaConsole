using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinMetaConsole
{
    internal class DatabaseHelper
    {
        private static readonly string connectionString = "Data Source=DESKTOP-D41EMMQ;Initial Catalog=SkinMeta;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
