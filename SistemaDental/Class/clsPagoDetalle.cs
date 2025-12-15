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
    internal class clsPagoDetalle
    {
        public int Id { get; set; }
        public int IdTratamiento { get; set; }
        public int IdConsulta { get; set; }
        public int Cantidad { get; set; }
        public string Tratamiento { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Subtotal { get; set; }

        // Crear detalle simple (original)
        public bool Crear(int idTratamiento, int idConsulta, int cantidad, string tratamiento, decimal valorUnitario, out int idDetalle)
        {
            idDetalle = 0;
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_crear_pago_detalle", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdTratamiento", idTratamiento);
                cmd.Parameters.AddWithValue("@IdConsulta", idConsulta);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@Tratamiento", tratamiento);
                cmd.Parameters.AddWithValue("@ValorUnitario", valorUnitario);
                SqlParameter paramId = cmd.Parameters.Add("@Id", SqlDbType.Int);
                paramId.Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();
                idDetalle = (int)paramId.Value;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear detalle de pago: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        // NUEVO: Crear detalle completo (con validación de tratamiento)
        public bool CrearDetalleCompleto(string nombreTratamiento, int idConsulta, int cantidad, decimal valorUnitario, out int idDetalle)
        {
            idDetalle = 0;
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_crear_detalle_completo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@NombreTratamiento", nombreTratamiento);
                cmd.Parameters.AddWithValue("@IdConsulta", idConsulta);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@ValorUnitario", valorUnitario);
                SqlParameter paramId = cmd.Parameters.Add("@IdDetalle", SqlDbType.Int);
                paramId.Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();
                idDetalle = (int)paramId.Value;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear detalle: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        // Obtener detalles por consulta
        public DataTable ObtenerPorConsulta(int idConsulta)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_detalles_por_consulta", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdConsulta", idConsulta);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener detalles: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        // NUEVO: Obtener detalles completos con subtotal
        public DataTable ObtenerDetallesCompletos(int idConsulta)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_detalles_por_consulta_completo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdConsulta", idConsulta);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener detalles: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        // Eliminar detalle
        public bool Eliminar(int id)
        {
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_eliminar_pago_detalle", con);
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
                MessageBox.Show($"Error al eliminar detalle: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        // NUEVO: Eliminar todos los detalles de una consulta
        public bool EliminarTodosLosDetalles(int idConsulta)
        {
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_eliminar_todos_detalles_consulta", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdConsulta", idConsulta);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar detalles: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        // NUEVO: Calcular total de la consulta
        public decimal CalcularTotalConsulta(int idConsulta)
        {
            decimal total = 0;
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_calcular_total_consulta", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdConsulta", idConsulta);
                SqlParameter paramTotal = cmd.Parameters.Add("@Total", SqlDbType.Decimal);
                paramTotal.Direction = ParameterDirection.Output;
                paramTotal.Precision = 10;
                paramTotal.Scale = 2;

                con.Open();
                cmd.ExecuteNonQuery();
                total = Convert.ToDecimal(paramTotal.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular total: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return total;
        }

        // NUEVO: Listar tratamientos disponibles
        public DataTable ListarTratamientos()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_listar_tratamientos", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar tratamientos: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
