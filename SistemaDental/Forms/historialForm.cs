using SistemaDental.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDental.Forms
{
    public partial class historialForm : Form
    {
        private Menu menuPrincipal;
        clsPaciente paciente = new clsPaciente();

        private int idPacienteActual;
        private int idConsulta;
        private bool cargandoGrid = false;
        private clsConsulta consulta = new clsConsulta();

        public historialForm(Menu menu, int idPacienteActual)
        {
            InitializeComponent();
            this.menuPrincipal = menu;
            this.idPacienteActual = idPacienteActual;

            // Cargar Tabla 
            ConfigurarDataGridViewHistorial();

            // Mover la carga al evento Shown para evitar BeginInvoke antes del handle
            this.Shown += Paciente_Shown;
        }

        private void Paciente_Shown(object? sender, EventArgs e)
        {
            this.Shown -= Paciente_Shown;
            CargarHistorialConsulta();
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
                DataPropertyName = "Nombre",
                Width = 400,
                ReadOnly = true
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha",
                HeaderText = "Fecha",
                DataPropertyName = "FechaConsulta",
                Width = 105,
                ReadOnly = true
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Motivo Consulta",
                HeaderText = "Motivo Consulta",
                DataPropertyName = "Motivo",
                Width = 430,
                ReadOnly = true,
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

        private void CargarHistorialConsulta()
        {
            try
            {
                cargandoGrid = true;

                paciente.Id = idPacienteActual;
                dgvHistorial.DataSource = paciente.ObtenerConsultasConDetallesPorPaciente();

                // Limpiar selección después de asignar DataSource
                if (dgvHistorial.IsHandleCreated)
                {
                    dgvHistorial.BeginInvoke(new Action(() =>
                    {
                        dgvHistorial.ClearSelection();
                        try { dgvHistorial.CurrentCell = null; } catch { }
                        idConsulta = 0; // <-- NO resetear idPacienteActual aquí
                    }));
                }
                else
                {
                    var _ = dgvHistorial.Handle;
                    dgvHistorial.BeginInvoke(new Action(() =>
                    {
                        dgvHistorial.ClearSelection();
                        try { dgvHistorial.CurrentCell = null; } catch { }
                        idConsulta = 0;
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar consultas: {ex.Message}");
            }
            finally
            {
                cargandoGrid = false;
            }
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cargandoGrid || e.RowIndex < 0) return;
            GuardarIdDesdeFilaIndex(e.RowIndex);
        }

        private void dgvHistorial_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (cargandoGrid || e.RowIndex < 0) return;
            GuardarIdDesdeFilaIndex(e.RowIndex);
        }

        private void GuardarIdDesdeFilaIndex(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvHistorial.Rows.Count)
            {
                idConsulta = 0;
                return;
            }

            var row = dgvHistorial.Rows[rowIndex];

            // Si el DataSource es un DataTable, el DataBoundItem será DataRowView
            if (row.DataBoundItem is DataRowView drv)
            {
                // Buscar columnas posibles que contengan el id de la consulta
                if (drv.Row.Table.Columns.Contains("Id") && drv.Row["Id"] != DBNull.Value)
                {
                    idConsulta = Convert.ToInt32(drv.Row["Id"]);
                    return;
                }
                if (drv.Row.Table.Columns.Contains("IdConsulta") && drv.Row["IdConsulta"] != DBNull.Value)
                {
                    idConsulta = Convert.ToInt32(drv.Row["IdConsulta"]);
                    return;
                }
                if (drv.Row.Table.Columns.Contains("Id_Consulta") && drv.Row["Id_Consulta"] != DBNull.Value)
                {
                    idConsulta = Convert.ToInt32(drv.Row["Id_Consulta"]);
                    return;
                }

                // ninguna columna encontrada
                idConsulta = 0;
                return;
            }

            // Si no, intentar leer desde las celdas (columna "N" enlaza Id)
            if (row.Cells["N"]?.Value != null && int.TryParse(row.Cells["N"].Value.ToString(), out int idFromN))
            {
                idConsulta = idFromN;
                return;
            }

            if (row.Cells["Id"]?.Value != null && int.TryParse(row.Cells["Id"].Value.ToString(), out int idFromId))
            {
                idConsulta = idFromId;
                return;
            }

            if (row.Cells["IdConsulta"]?.Value != null && int.TryParse(row.Cells["IdConsulta"].Value.ToString(), out int idFromIdConsulta))
            {
                idConsulta = idFromIdConsulta;
                return;
            }

            idConsulta = 0;
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            menuPrincipal.AbrirFormulario(new Paciente(menuPrincipal));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuPrincipal.AbrirFormulario(new Consulta(menuPrincipal, idPacienteActual, idConsulta));
        }
    }
}
