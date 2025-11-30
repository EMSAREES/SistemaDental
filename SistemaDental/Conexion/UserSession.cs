using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDental.Conexion
{
    internal class UserSession
    {
        public static int Id { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static bool EsAdmin { get; set; }
        public static string Usuario { get; set; }

        public static void CerrarSesion()
        {
            Id = 0;
            Nombre = null;
            Apellido = null;
            EsAdmin = false;
            Usuario = null;
        }
    }
}
