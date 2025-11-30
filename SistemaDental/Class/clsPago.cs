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
