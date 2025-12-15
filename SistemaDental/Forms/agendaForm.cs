using SistemaDental.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDental.Forms
{
    public partial class agendaForm : Form
    {
        clsCita cita = new clsCita();
        private int idConsultaActual = 0;
        private int idPacienteActual = 0;

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

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdPaciente",
                HeaderText = "IdPaciente",
                DataPropertyName = "IdPaciente",
                Visible = false // columna oculta para acceso directo
            });


            // Estilos del encabezado
            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistorial.EnableHeadersVisualStyles = false;

            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.MultiSelect = false;
            dgvHistorial.AllowUserToAddRows = false;

            // Suscribir eventos robustos para captura de selección
            dgvHistorial.RowEnter += dgvHistorial_RowEnter;
            dgvHistorial.CellClick += dgvHistorial_CellClick;
        }

        private void CargarHistorialTratamientos()
        {
            try
            {
                cita.FechaCita = dateTimePicker1.Value;

                DataTable dt = cita.ObtenerCita();
                dgvHistorial.DataSource = dt;

                // Si hay filas, seleccionar la primera (opcional)
                if (dgvHistorial.Rows.Count > 0)
                {
                    dgvHistorial.ClearSelection();
                    dgvHistorial.Rows[0].Selected = true;
                    GuardarIdDesdeFilaIndex(0);
                }
                else
                {
                    idConsultaActual = 0;
                    idPacienteActual = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tratamientos: {ex.Message}");
            }
        }

       
        // --- Handlers robustos para guardar la Id según la fila seleccionada ---

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            GuardarIdDesdeFilaIndex(e.RowIndex);
        }

        // Se dispara cuando la fila gana foco (teclado o ratón)
        private void dgvHistorial_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            GuardarIdDesdeFilaIndex(e.RowIndex);
        }

        private void GuardarIdDesdeFilaIndex(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvHistorial.Rows.Count)
            {
                idConsultaActual = 0;
                idPacienteActual = 0;
                return;
            }

            var row = dgvHistorial.Rows[rowIndex];

            // Si el DataSource es un DataTable, el DataBoundItem será DataRowView
            if (row.DataBoundItem is DataRowView drv)
            {
                idConsultaActual = drv.Row["Id"] != DBNull.Value ? Convert.ToInt32(drv.Row["Id"]) : 0;
                idPacienteActual = drv.Row["IdPaciente"] != DBNull.Value ? Convert.ToInt32(drv.Row["IdPaciente"]) : 0;
                return;
            }

            // Si no, intentar leer desde la celda de la columna "N" (que enlaza Id) o desde "Id" si existe
            if (row.Cells["N"]?.Value != null && int.TryParse(row.Cells["N"].Value.ToString(), out int idFromN))
            {
                idConsultaActual = idFromN;
                idPacienteActual = idFromN;
                return;
            }

            if (row.Cells["Id"]?.Value != null && int.TryParse(row.Cells["Id"].Value.ToString(), out int idFromId))
            {
                idConsultaActual = idFromId;
                idPacienteActual = idFromId;
                return;
            }

            idConsultaActual = 0;
            idPacienteActual = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Asegurar la obtención de la Id desde la fila seleccionada en el DataGridView
            //if (dgvHistorial.SelectedRows.Count > 0)
            //{
            //    var selRow = dgvHistorial.SelectedRows[0];
            //    if (selRow.DataBoundItem is DataRowView drv)
            //    {
            //        idConsultaActual = drv.Row["Id"] != DBNull.Value ? Convert.ToInt32(drv.Row["Id"]) : 0;
            //    }
            //    else if (selRow.Cells["N"]?.Value != null && int.TryParse(selRow.Cells["N"].Value.ToString(), out int idFromN))
            //    {
            //        idConsultaActual = idFromN;
            //    }
            //}

            //MessageBox.Show($"Cita seleccionada: {idConsultaActual}");

            eliminar();
        }

        private void eliminar()
        {
            if (idConsultaActual == 0)
            {
                MessageBox.Show("No hay Cita seleccionada para eliminar");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar esta Cita?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                cita.Id = idConsultaActual;

                if (cita.Eliminar())
                {
                    MessageBox.Show("Consulta eliminada exitosamente");
                    CargarHistorialTratamientos();

                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!TryObtenerIdsSeleccionados(out int idCita, out int idPaciente))
            {
                MessageBox.Show("Seleccione una cita válida.");
                return;
            }

            var agendar = new agendarCitaForm(idPaciente, idCita, true);
            agendar.ShowDialog();

            // Refrescar grid después de editar
            CargarHistorialTratamientos();


        }

        // Método seguro para obtener ids desde la fila seleccionada
        private bool TryObtenerIdsSeleccionados(out int idCita, out int idPaciente)
        {
            idCita = 0;
            idPaciente = 0;

            if (dgvHistorial.CurrentRow == null) return false;

            var row = dgvHistorial.CurrentRow;
            // Si está vinculado a un DataTable
            if (row.DataBoundItem is DataRowView drv)
            {
                if (drv.Row.Table.Columns.Contains("Id"))
                    idCita = drv.Row["Id"] != DBNull.Value ? Convert.ToInt32(drv.Row["Id"]) : 0;
                if (drv.Row.Table.Columns.Contains("IdPaciente"))
                    idPaciente = drv.Row["IdPaciente"] != DBNull.Value ? Convert.ToInt32(drv.Row["IdPaciente"]) : 0;
                return idCita != 0 || idPaciente != 0;
            }

            // Si se lee por celdas (usar la columna oculta "IdPaciente" y "N")
            if (row.Cells["N"]?.Value != null && int.TryParse(row.Cells["N"].Value.ToString(), out int idFromN))
                idCita = idFromN;
            if (row.Cells["IdPaciente"]?.Value != null && int.TryParse(row.Cells["IdPaciente"].Value.ToString(), out int idFromPaciente))
                idPaciente = idFromPaciente;

            return idCita != 0 || idPaciente != 0;
        }
    }
}
