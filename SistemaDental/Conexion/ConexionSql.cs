using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDental.Conexion
{
    internal class ConexionSql
    {
        public static string conectar()
        {
            string con = @"Data Source=EMILIO\SQLEXPRESS;Initial Catalog=Dental_Db;User ID=sa;Password=6870021;TrustServerCertificate=True";

            return con;
        }
    }
}
