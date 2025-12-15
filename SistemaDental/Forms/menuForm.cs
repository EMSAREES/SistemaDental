using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDental.Forms;

namespace SistemaDental.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            AbrirFormulario(new agendaForm());
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new agendaForm());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Consulta(this));
        }

        public void AbrirFormulario(Form formHijo)
        {
            panelContenedor.Controls.Clear();   // Limpia el panel
            formHijo.TopLevel = false;          // Importante: NO es una ventana
            formHijo.FormBorderStyle = FormBorderStyle.None; // Sin borde
            formHijo.Dock = DockStyle.Fill;     // Que ocupe todo el panel
            panelContenedor.Controls.Add(formHijo); // Añadir al panel
            formHijo.Show();                    // Mostrar dentro del panel
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ingresosForm());
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Paciente(this));
        }
    }
}
