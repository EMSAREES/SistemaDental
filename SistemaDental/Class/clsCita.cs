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
    internal class clsCita
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public DateTime FechaCita { get; set; }
        public TimeSpan Hora { get; set; }
        public string Detalle { get; set; }
        public DateTime Fechacreacion { get; set; }

        public bool Crear()
        {
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_crear_cita", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPaciente", IdPaciente);
                cmd.Parameters.AddWithValue("@FechaCita", FechaCita);
                cmd.Parameters.AddWithValue("@Hora", Hora);
                cmd.Parameters.AddWithValue("@Detalle", Detalle ?? (object)DBNull.Value);

                // Agregar parámetro de salida
                cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();

                // Recuperar el ID generado
                Id = Convert.ToInt32(cmd.Parameters["@Id"].Value);

                return true;
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear consulta: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool Editar()
        {
            using SqlConnection con = new SqlConnection(ConexionSql.conectar());
            using SqlCommand cmd = new SqlCommand("sp_actualizar_cita", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@FechaCita", FechaCita);
                cmd.Parameters.AddWithValue("@Hora", Hora);
                cmd.Parameters.AddWithValue("@Detalle", Detalle ?? (object)DBNull.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar cita: {ex.Message}");
                return false;
            }
        }


        public bool Eliminar()
        {
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_eliminar_cita", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cita: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }


        public DataTable ObtenerCita()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_reporte_citas", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@FechaCita", FechaCita);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener pago: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool ObtenerCitaPorId(int idCita)
        {
            using SqlConnection con = new SqlConnection(ConexionSql.conectar());
            using SqlCommand cmd = new SqlCommand("sp_buscar_cita_por_id", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", idCita);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Id = Convert.ToInt32(dr["Id"]);
                    IdPaciente = Convert.ToInt32(dr["IdPaciente"]);
                    FechaCita = Convert.ToDateTime(dr["FechaCita"]);
                    Hora = (TimeSpan)dr["Hora"];
                    Detalle = dr["Detalle"]?.ToString();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }


    }
}
