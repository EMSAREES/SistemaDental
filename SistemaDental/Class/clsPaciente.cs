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
    internal class clsPaciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Alergias { get; set; }
        public string Hipersensibilidad { get; set; }
        public string SangradoEncias { get; set; }

        public bool Crear(out int idPaciente)
        {
            idPaciente = 0;
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_crear_paciente", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Nombre", Nombre ?? (object)DBNull.Value);
                cmd.Parameters.Add("@Edad", SqlDbType.Int).Value = Edad > 0 ? Edad : (object)DBNull.Value;
                cmd.Parameters.AddWithValue("@Sexo", Sexo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Direccion", Direccion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono", Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Alergias", Alergias ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Hipersensibilidad", Hipersensibilidad ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SangradoEncias", SangradoEncias ?? (object)DBNull.Value);
                SqlParameter paramId = cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int);
                paramId.Direction = System.Data.ParameterDirection.Output;
                con.Open();
                cmd.ExecuteNonQuery();
                idPaciente = (int)paramId.Value;
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al crear paciente: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }

        }

        public bool Eliminar()
        {
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_eliminar_paciente", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al eliminar paciente: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ObtenerTodosYNombre()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConexionSql.conectar()))
            using (SqlCommand cmd = new SqlCommand("sp_buscar_pacientes", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (string.IsNullOrWhiteSpace(Nombre))
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener pacientes: {ex.Message}");
                }
            }
            return dt;
        }

        // Obtener todas las consultas con detalles del paciente por id del paciente
        public DataTable ObtenerConsultasConDetallesPorPaciente()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConexionSql.conectar()))
            using (SqlCommand cmd = new SqlCommand("sp_obtener_Paciente_completa", con)) // <- SP existente
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener consultas con detalles: {ex.Message}");
                }
            }
            return dt;
        }

    }
}
