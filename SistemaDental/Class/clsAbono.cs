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
    internal class clsAbono
    {
        public int Id { get; set; }
        public int IdPago { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Crear un nuevo abono
        /// </summary>
        public bool Crear(int idPago, decimal monto, out int idAbono)
        {
            idAbono = 0;
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_crear_abono", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPago", idPago);
                cmd.Parameters.AddWithValue("@Monto", monto);
                SqlParameter paramId = cmd.Parameters.Add("@Id", SqlDbType.Int);
                paramId.Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();
                idAbono = (int)paramId.Value;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear abono: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Obtener todos los abonos de un pago específico
        /// </summary>
        public DataTable ObtenerPorPago(int idPago)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_abonos_por_pago", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPago", idPago);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener abonos: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        /// <summary>
        /// Obtener todos los abonos de un paciente
        /// </summary>
        public DataTable ObtenerPorPaciente(int idPaciente)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_abonos_por_paciente", con);
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
                MessageBox.Show($"Error al obtener abonos del paciente: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        /// <summary>
        /// Calcular total de abonos realizados para un pago
        /// </summary>
        public decimal CalcularTotalAbonos(int idPago)
        {
            decimal total = 0;
            try
            {
                DataTable dt = ObtenerPorPago(idPago);
                foreach (DataRow row in dt.Rows)
                {
                    total += Convert.ToDecimal(row["Monto"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular total de abonos: {ex.Message}");
            }
            return total;
        }

        /// <summary>
        /// Eliminar un abono
        /// </summary>
        public bool Eliminar(int id)
        {
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_eliminar_abono", con);
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
                MessageBox.Show($"Error al eliminar abono: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
