

using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp4.Database
{
    public class DB
    {
        private static string connectionString =
            @"Server=DESKTOP-VJI1C1U\SQLEXPRESS;
              Database=ClinicDB;
              Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}