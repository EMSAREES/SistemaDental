using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDental.Class;
using SistemaDental.Conexion;

namespace SistemaDental.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            entrar();
            //MessageBox.Show(Encrypt.GetSHA256("admin"));

        }


        private void entrar()
        {
            clsLogin log = new clsLogin();

            // Datos ingresados
            log.sUsuario = txtUsuario.Text.Trim();
            log.sContrasena = Encrypt.GetSHA256(txtContrasena.Text); // ← corregido

            // Consultar en BD
            if (log.consultar())
            {
                if (log.resultadoInicioSesion)
                {
                    // Guardar sesión global
                    UserSession.Id = log.IdUsuario;
                    UserSession.Nombre = log.Nombre;
                    UserSession.Apellido = log.Apellido;
                    UserSession.EsAdmin = log.esAdmin;
                    UserSession.Usuario = log.sUsuario;

                    // Abrir menú principal
                    Menu mainf = new Menu();
                    this.Hide();
                    mainf.Show();
                }
                else
                {
                    MessageBox.Show("El Usuario o la Contraseña son incorrectos, intenta de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("No se pudo iniciar sesión correctamente.");
            }
        }


    }
}
