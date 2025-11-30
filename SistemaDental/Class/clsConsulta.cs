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
    internal class clsConsulta
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public string Motivo { get; set; }
        public DateTime Fecha { get; set; }
        public string NombrePaciente { get; set; }

        public bool Crear(int idPaciente, string motivo, out int idConsulta)
        {
            idConsulta = 0;
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_crear_consulta", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                cmd.Parameters.AddWithValue("@Motivo", motivo ?? (object)DBNull.Value);
                SqlParameter paramId = cmd.Parameters.Add("@Id", SqlDbType.Int);
                paramId.Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();
                idConsulta = (int)paramId.Value;
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

        public bool Actualizar(int id, string motivo)
        {
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_actualizar_consulta", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Motivo", motivo ?? (object)DBNull.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar consulta: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ObtenerPorId(int id)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_buscar_consulta_por_id", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener consulta: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable ObtenerPorPaciente(int idPaciente)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_consultas_por_paciente", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener consultas: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable ObtenerTodas()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_todas_consultas", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener consultas: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool Eliminar(int id)
        {
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_eliminar_consulta", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar consulta: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
