using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDental.Conexion
{
    internal class ConexionSql
    {
        public static string conectar()
        {
            string con = @"Data Source=EMILIO\SQLEXPRESS;Initial Catalog=DentalDB;User ID=sa;Password=6870021;TrustServerCertificate=True";

            using (SqlConnection conexion = new SqlConnection(con))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("sp_crear_admin_si_no_existe", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear usuario por defecto: " + ex.Message);
                }
            }


            return con;

        }
    }
}
