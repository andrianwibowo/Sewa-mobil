using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AplikasiSewaMobilku
{
    class Koneksi
    {

        private static String connString;
        public static SqlConnection conn;

        public static void Open()
        {
            connString = @"data source=.; initial catalog = SEWA_MOBILKU; "
                + "integrated security = true";

            conn = new SqlConnection(connString);

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void Close()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
