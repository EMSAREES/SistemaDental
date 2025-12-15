using Microsoft.Data.SqlClient;
using SistemaDental.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDental.Class
{
    internal class clsIngresos
    {
        public DateTime fechaInicio {  get; set; }
        public DateTime fechaFinal { get; set; }

        public DataTable ObtenerIngresosPorRango()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(ConexionSql.conectar()))
            using (SqlCommand cmd = new SqlCommand("sp_obtener_ingreso", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFinal", fechaFinal);

                try
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener ingresos: {ex.Message}");
                }
            }

            return dt;
        }

    }
}
