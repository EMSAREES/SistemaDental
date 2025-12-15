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

namespace SistemaDental.Forms
{
    public partial class agendarCitaForm : Form
    {
        clsCita cita = new clsCita();

        private int IdPaciente;
        private int IdCita;
        private bool accionEditar;

        public agendarCitaForm(int idPaciente, int idCita = 0, bool accionEditar = false)
        {
            InitializeComponent();

            IdPaciente = idPaciente;
            IdCita = idCita;
            this.accionEditar = accionEditar;

            if (accionEditar)
            {
                CargarDatosCita();
            }
        }

        private void agendarCitaForm_Load(object sender, EventArgs e)
        {
            if (accionEditar)
            {
                CargarDatosCita();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void CargarDatosCita()
        {
            if (!cita.ObtenerCitaPorId(IdCita))
            {
                MessageBox.Show("No se pudo cargar la cita");
                Close();
                return;
            }

            fechadate.Value = cita.FechaCita;
            txtHora.Text = cita.Hora.ToString(@"hh\:mm");
            TextDetalle.Text = cita.Detalle;
        }

        private void Guardar()
        {
            // Validar fecha
            if (fechadate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha no puede ser anterior a hoy");
                return;
            }

            // Validar hora
            if (string.IsNullOrWhiteSpace(txtHora.Text))
            {
                MessageBox.Show("Agregue una hora");
                return;
            }

            if (!TimeSpan.TryParse(txtHora.Text, out TimeSpan hora))
            {
                MessageBox.Show("Formato de hora inválido (HH:mm)");
                return;
            }

            // Validar detalle
            if (string.IsNullOrWhiteSpace(TextDetalle.Text))
            {
                MessageBox.Show("Agregue un detalle");
                return;
            }

            // Asignar datos
            cita.IdPaciente = IdPaciente;
            cita.FechaCita = fechadate.Value;
            cita.Hora = hora;
            cita.Detalle = TextDetalle.Text;

            bool resultado;

            if (accionEditar)
            {
                cita.Id = IdCita;
                resultado = cita.Editar();
            }
            else
            {
                resultado = cita.Crear();
            }

            if (resultado)
            {
                MessageBox.Show(accionEditar
                    ? "Cita actualizada correctamente"
                    : "Cita guardada correctamente");

                limpiar();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar la cita");
            }
        }


        //private void Guardar()
        //{
        //    // Verificar que haya tratamientos
        //    if (fechadate.Value == null) // DateTimePicker siempre tiene un valor
        //    {
        //        MessageBox.Show("Agregue una Fecha");
        //        return;
        //    }
        //    else if (string.IsNullOrWhiteSpace(txtHora.Text))
        //    {
        //        MessageBox.Show("Agregue una Hora");
        //        return;
        //    }

        //    cita.IdPaciente = IdPaciente;
        //    cita.FechaCita = fechadate.Value;
        //    cita.Hora = TimeSpan.Parse(txtHora.Text);
        //    cita.Detalle = TextDetalle.Text.ToString();

        //    if(accionEditar)
        //    {
        //        cita.Id = IdCita;
        //        if (cita.Editar() == true)
        //        {
        //            MessageBox.Show("Sus datos se a Actualizado correctamente");
        //            limpiar();
        //            this.Hide();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Sus datos no se a Actualizado correctamente");
        //        }
        //    }
        //    else
        //    {
        //        if (cita.Crear() == true)
        //        {
        //            MessageBox.Show("Sus datos se a Guardado correctamente");
        //            limpiar();
        //            this.Hide();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Sus datos no se a Guardado correctamente");
        //        }
        //    }


        //}

        private void limpiar()
        {
            fechadate.Value = DateTime.Now;      
            txtHora.Clear();                     
            TextDetalle.Clear();
        }
    }
}
