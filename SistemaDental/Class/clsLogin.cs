using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SistemaDental.Conexion.ConexionSql;
using static SistemaDental.Conexion.Encrypt;
using static SistemaDental.Forms.Login;
using Microsoft.Data.SqlClient;
using SistemaDental.Conexion;

namespace SistemaDental.Class
{
    internal class clsLogin
    {
        public string sUsuario { get; set; }
        public string sContrasena { get; set; }

        // Datos que queremos compartir
        public bool esAdmin { get; set; }
        public bool resultadoInicioSesion { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public bool consultar()
        {
            bool bValidar = false;
            using (SqlConnection con = new SqlConnection(ConexionSql.conectar()))
            using (SqlCommand cmd = new SqlCommand("sp_loginusuario", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Usuario", sUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", sContrasena);

                cmd.Parameters.Add("@result", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@ROL", SqlDbType.Bit).Direction = ParameterDirection.Output;

                cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    bValidar = true;

                    resultadoInicioSesion = cmd.Parameters["@result"].Value != DBNull.Value
                                            && Convert.ToBoolean(cmd.Parameters["@result"].Value);

                    esAdmin = cmd.Parameters["@ROL"].Value != DBNull.Value
                              && Convert.ToBoolean(cmd.Parameters["@ROL"].Value);

                    // outputs: comprobar DBNull antes de convertir
                    if (cmd.Parameters["@Id"].Value != DBNull.Value)
                        IdUsuario = Convert.ToInt32(cmd.Parameters["@Id"].Value);

                    Nombre = cmd.Parameters["@Nombre"].Value != DBNull.Value
                             ? cmd.Parameters["@Nombre"].Value.ToString()
                             : string.Empty;

                    Apellido = cmd.Parameters["@Apellido"].Value != DBNull.Value
                               ? cmd.Parameters["@Apellido"].Value.ToString()
                               : string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al loguear los datos: {ex.Message}");
                    bValidar = false;
                }
            }
            return bValidar;
        }


    }
}
