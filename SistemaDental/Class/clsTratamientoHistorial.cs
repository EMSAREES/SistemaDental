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
    internal class clsTratamientoHistorial
    {
        public DataTable ObtenerHistorialPaciente(int idPaciente)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_historial_tratamientos_paciente", con);
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
                MessageBox.Show($"Error al obtener historial: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable ObtenerTratamientoporconsulta(int idConsulta)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_tratamientos_por_consulta", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                // CORREGIDO → el parámetro correcto es @IdConsulta
                cmd.Parameters.AddWithValue("@IdConsulta", idConsulta);

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener tratamientos: {ex.Message}");
            }
            finally
            {
                con.Close();
            }

            return dt;
        }


        /// <summary>
        /// Registrar un abono y actualizar el pago
        /// </summary>
        public bool RegistrarAbono(int idPago, decimal montoAbono, out int idAbono, out decimal nuevoSaldo, out string mensaje)
        {
            idAbono = 0;
            nuevoSaldo = 0;
            mensaje = "";

            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_registrar_abono_y_actualizar_pago", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPago", idPago);
                cmd.Parameters.AddWithValue("@MontoAbono", montoAbono);

                SqlParameter paramIdAbono = cmd.Parameters.Add("@IdAbono", SqlDbType.Int);
                paramIdAbono.Direction = ParameterDirection.Output;

                SqlParameter paramNuevoSaldo = cmd.Parameters.Add("@NuevoSaldo", SqlDbType.Decimal);
                paramNuevoSaldo.Direction = ParameterDirection.Output;
                paramNuevoSaldo.Precision = 10;
                paramNuevoSaldo.Scale = 2;

                SqlParameter paramMensaje = cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 200);
                paramMensaje.Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();

                idAbono = (int)paramIdAbono.Value;
                nuevoSaldo = Convert.ToDecimal(paramNuevoSaldo.Value);
                mensaje = paramMensaje.Value.ToString();

                return idAbono > 0;
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

        /// <summary>
        /// Pagar el saldo completo de una deuda
        /// </summary>
        public bool PagarSaldoCompleto(int idPago, out int idAbono, out string mensaje)
        {
            idAbono = 0;
            mensaje = "";

            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_pagar_saldo_completo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPago", idPago);

                SqlParameter paramIdAbono = cmd.Parameters.Add("@IdAbono", SqlDbType.Int);
                paramIdAbono.Direction = ParameterDirection.Output;

                SqlParameter paramMensaje = cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 200);
                paramMensaje.Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();

                idAbono = (int)paramIdAbono.Value;
                mensaje = paramMensaje.Value.ToString();

                return idAbono > 0;
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

        /// <summary>
        /// Obtener información de un pago para abonar
        /// </summary>
        public DataSet ObtenerInfoParaAbono(int idPago)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_info_pago_para_abono", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPago", idPago);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener información: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        /// <summary>
        /// Obtener lista de pagos con deuda de un paciente
        /// </summary>
        public DataTable ObtenerPagosConDeuda(int idPaciente)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConexionSql.conectar());
            SqlCommand cmd = new SqlCommand("sp_obtener_pagos_con_deuda", con);
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
                MessageBox.Show($"Error al obtener pagos con deuda: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
