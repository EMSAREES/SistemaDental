using SistemaDental.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaDental.Forms
{
    public partial class agendarConsultaForm : Form
    {
        private Menu menuPrincipal;
        clsConsulta consulta = new clsConsulta();

        private int IdPaciente;
        private int IdConsulta;
        public agendarConsultaForm(Menu menu, int idPaciente)
        {
            InitializeComponent();
            this.menuPrincipal = menu;
            IdPaciente = idPaciente;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            limpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

        }

        private void Guardar()
        {
            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Agregue un detalle");
                return;
            }

            // Asignar datos
            consulta.IdPaciente = IdPaciente;
            consulta.Motivo = txtMotivo.Text;

            int idConsulta;
            if (consulta.Crear(out idConsulta))
            {
                // Guardar el Id en la propiedad del formulario
                IdConsulta = idConsulta;

                MessageBox.Show($"Consulta creada correctamente con Id: {IdConsulta}");

                if (IdConsulta == 0)
                {
                    MessageBox.Show("Debe crear una consulta primero");
                    return;
                }

                // Pasar el ID de la consulta al formulario de cobrar
                menuPrincipal.AbrirFormulario(new Consulta(menuPrincipal, IdPaciente, IdConsulta));

                this.Hide();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar la cita");
            }
        }

        private void limpiarCampos()
        {
            txtMotivo.Clear();
            IdPaciente = 0;
        }

        
    }
}
