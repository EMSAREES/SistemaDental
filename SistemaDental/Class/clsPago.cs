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
    internal class clsPago
    {
        public int Id { get; set; }
        public int IdConsulta { get; set; }
        public int IdPaciente { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPagado { get; set; }
        public decimal SaldoPendiente { get; set; }
        public string Deuda { get; set; }
        public string NombrePaciente { get; set; }

        // Crear pago (original)
        public bool Crear(int idConsulta, int idPaciente, decimal valorTotal, decimal valorPagado, string deuda, out int idPago)
        {
            idPago = 0;
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_crear_pago", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdConsulta", idConsulta);
                cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                cmd.Parameters.AddWithValue("@ValorTotal", valorTotal);
                cmd.Parameters.AddWithValue("@ValorPagado", valorPagado);
                cmd.Parameters.AddWithValue("@Deuda", deuda);
                SqlParameter paramId = cmd.Parameters.Add("@Id", SqlDbType.Int);
                paramId.Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();
                idPago = (int)paramId.Value;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear pago: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        // NUEVO: Guardar pago completo (crear o actualizar)
        public bool GuardarPagoCompleto(int idConsulta, int idPaciente, decimal valorTotal, decimal valorCobrado, out int idPago, out string mensaje)
        {
            idPago = 0;
            mensaje = "";
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_guardar_pago_completo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdConsulta", idConsulta);
                cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                cmd.Parameters.AddWithValue("@ValorTotal", valorTotal);
                cmd.Parameters.AddWithValue("@ValorCobrado", valorCobrado);

                SqlParameter paramIdPago = cmd.Parameters.Add("@IdPago", SqlDbType.Int);
                paramIdPago.Direction = ParameterDirection.Output;

                SqlParameter paramMensaje = cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 200);
                paramMensaje.Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();

                idPago = (int)paramIdPago.Value;
                mensaje = paramMensaje.Value.ToString();

                return idPago > 0;
            }
            catch (Exception ex)
            {
                mensaje = $"Error: {ex.Message}";
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        // Actualizar pago
        public bool Actualizar(int id, decimal valorPagado, string deuda)
        {
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_actualizar_pago", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@ValorPagado", valorPagado);
                cmd.Parameters.AddWithValue("@Deuda", deuda);

                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar pago: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        // Obtener pago por consulta
        public DataTable ObtenerPorConsulta(int idConsulta)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_buscar_pago_por_consulta", con);
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
                MessageBox.Show($"Error al obtener pago: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        // NUEVO: Obtener resumen de pago
        public DataTable ObtenerResumenPago(int idConsulta)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_resumen_pago", con);
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
                MessageBox.Show($"Error al obtener resumen: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        // NUEVO: Verificar si existe pago
        public bool VerificarPagoExistente(int idConsulta, out int idPago)
        {
            idPago = 0;
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_verificar_pago_existente", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdConsulta", idConsulta);

                SqlParameter paramExiste = cmd.Parameters.Add("@Existe", SqlDbType.Bit);
                paramExiste.Direction = ParameterDirection.Output;

                SqlParameter paramIdPago = cmd.Parameters.Add("@IdPago", SqlDbType.Int);
                paramIdPago.Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();

                bool existe = (bool)paramExiste.Value;
                idPago = (int)paramIdPago.Value;

                return existe;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar pago: {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        // NUEVO: Obtener datos para cobro
        public DataTable ObtenerDatosCobro(int idConsulta)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_datos_cobro", con);
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
                MessageBox.Show($"Error al obtener datos de cobro: {ex.Message}");
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
            SqlCommand cmd = new SqlCommand("sp_obtener_pagos_por_paciente", con);
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
                MessageBox.Show($"Error al obtener pagos: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable ObtenerTodos()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_todos_pagos", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener pagos: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
