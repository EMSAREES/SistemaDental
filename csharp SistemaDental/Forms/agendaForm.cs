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
    public partial class agendaForm : Form
    {
        clsCita cita = new clsCita();
        private int idConsultaActual = 0;

        public agendaForm()
        {
            InitializeComponent();

            ConfigurarDataGridViewHistorial();

        }

        private void agendaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            CargarHistorialTratamientos();
        }

        private void ConfigurarDataGridViewHistorial()
        {
            dgvHistorial.AutoGenerateColumns = false;
            dgvHistorial.Columns.Clear();

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "N",
                HeaderText = "N°",
                DataPropertyName = "Id",
                Width = 40,
                ReadOnly = true
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Paciente",
                HeaderText = "Paciente",
                DataPropertyName = "NombrePaciente",
                Width = 130,
                ReadOnly = true
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha",
                HeaderText = "Fecha",
                DataPropertyName = "FechaCita",
                Width = 180,
                ReadOnly = true
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Hora",
                HeaderText = "Hora",
                DataPropertyName = "Hora",
                Width = 90,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = @"hh\:mm" } // si es TimeSpan
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Asunto",
                HeaderText = "Asunto",
                DataPropertyName = "Detalle",
                Width = 330,
                ReadOnly = true,
            });


            // Estilos del encabezado
            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistorial.EnableHeadersVisualStyles = false;

            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.MultiSelect = false;
            dgvHistorial.AllowUserToAddRows = false;

            // Suscribir eventos para capturar selección
            dgvHistorial.CellClick += dgvHistorial_CellClick;
            dgvHistorial.SelectionChanged += dgvHistorial_SelectionChanged;
        }

        private void CargarHistorialTratamientos()
        {
            try
            {
                cita.FechaCita = dateTimePicker1.Value;

                DataTable dt = cita.ObtenerCita();
                dgvHistorial.DataSource = dt;

                // Seleccionar la primera fila por defecto (si existe) y guardar su Id
                if (dgvHistorial.Rows.Count > 0)
                {
                    dgvHistorial.ClearSelection();
                    dgvHistorial.Rows[0].Selected = true;
                    GuardarIdDesdeFilaIndex(0);
                }
                else
                {
                    idConsultaActual = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tratamientos: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cita seleccionada: {idConsultaActual}");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cita.");
                return;
            }

            var row = dgvHistorial.CurrentRow;
            if (!(row.DataBoundItem is DataRowView drv))
            {
                MessageBox.Show("No se pudieron leer los datos de la cita seleccionada.");
                return;
            }

            int idCita = drv.Row.Table.Columns.Contains("Id") && drv.Row["Id"] != DBNull.Value
                ? Convert.ToInt32(drv.Row["Id"])
                : 0;

            int idPaciente = drv.Row.Table.Columns.Contains("IdPaciente") && drv.Row["IdPaciente"] != DBNull.Value
                ? Convert.ToInt32(drv.Row["IdPaciente"])
                : 0;

            DateTime fecha = drv.Row.Table.Columns.Contains("FechaCita") && drv.Row["FechaCita"] != DBNull.Value
                ? Convert.ToDateTime(drv.Row["FechaCita"])
                : DateTime.Now;

            TimeSpan hora = TimeSpan.Zero;
            if (drv.Row.Table.Columns.Contains("Hora") && drv.Row["Hora"] != DBNull.Value)
            {
                // Si la columna Hora viene como TimeSpan en la BD
                if (drv.Row["Hora"] is TimeSpan ts) hora = ts;
                else TimeSpan.TryParse(drv.Row["Hora"].ToString(), out hora);
            }

            string detalle = drv.Row.Table.Columns.Contains("Detalle") && drv.Row["Detalle"] != DBNull.Value
                ? drv.Row["Detalle"].ToString()
                : string.Empty;

            if (idCita == 0)
            {
                MessageBox.Show("Id de cita inválido.");
                return;
            }

            var agendarCita = new agendarCitaForm(idPaciente, idCita, true);
            agendarCita.CargarDatosParaEditar(fecha, hora, detalle, idCita);
            agendarCita.ShowDialog(); // o Show() según tu flujo
        }

        // --- Nuevos handlers y utilidades para guardar la Id según la fila seleccionada ---

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            GuardarIdDesdeFilaIndex(e.RowIndex);
        }

        private void dgvHistorial_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistorial.CurrentRow != null)
            {
                GuardarIdDesdeFilaIndex(dgvHistorial.CurrentRow.Index);
            }
        }

        private void GuardarIdDesdeFilaIndex(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvHistorial.Rows.Count)
            {
                idConsultaActual = 0;
                return;
            }

            var row = dgvHistorial.Rows[rowIndex];

            // Si el DataSource es un DataTable, el DataBoundItem será DataRowView
            if (row.DataBoundItem is DataRowView drv)
            {
                idConsultaActual = drv.Row["Id"] != DBNull.Value ? Convert.ToInt32(drv.Row["Id"]) : 0;
                return;
            }

            // Si no, intentar leer desde la celda de la columna "N" (que enlaza Id) o desde "Id" si existe
            if (row.Cells["N"]?.Value != null && int.TryParse(row.Cells["N"].Value.ToString(), out int idFromN))
            {
                idConsultaActual = idFromN;
                return;
            }

            if (row.Cells["Id"]?.Value != null && int.TryParse(row.Cells["Id"].Value.ToString(), out int idFromId))
            {
                idConsultaActual = idFromId;
                return;
            }

            idConsultaActual = 0;
        }
    }
}