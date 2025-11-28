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
            string con = @"DATA Source=EMILIO\SQLEXPRESS;INITIAL CATALOG=Dental_Db;USER=sa;PASSWORD=tucontraseña";

            return con;
        }
    }
}
