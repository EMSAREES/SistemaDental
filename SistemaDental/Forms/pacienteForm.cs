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
    public partial class Paciente : Form
    {
        private Menu menuPrincipal;
        clsPaciente paciente = new clsPaciente();

        private int idPacienteActual;
        private bool cargandoGrid = false;


        public Paciente(Menu menu)
        {
            InitializeComponent();
            this.menuPrincipal = menu;

            // Cargar Tabla 
            ConfigurarDataGridViewHistorial();

            // Mover la carga al evento Shown para evitar BeginInvoke antes del handle
            this.Shown += Paciente_Shown;

        }

        private void Paciente_Shown(object? sender, EventArgs e)
        {
            // Desuscribimos para que sólo se ejecute la primera vez
            this.Shown -= Paciente_Shown;
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
                Name = "Nombres y Apellido",
                HeaderText = "Nombres y Apellido",
                DataPropertyName = "Nombre",
                Width = 400,
                ReadOnly = true
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Edad",
                HeaderText = "Edad",
                DataPropertyName = "Edad",
                Width = 105,
                ReadOnly = true
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Sexo",
                HeaderText = "Sexo",
                DataPropertyName = "Sexo",
                Width = 110,
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

        private void CargarHistorialTratamientos()
        {
            try
            {
                cargandoGrid = true;

                paciente.Nombre = txtBuscarPaciente.Text.Trim();
                dgvHistorial.DataSource = paciente.ObtenerTodosYNombre();

                // Limpiar selección inmediatamente y asegurar que no quede CurrentCell.
                // Se usa BeginInvoke para que se ejecute después de que el DataGridView procese el DataSource.
                if (dgvHistorial.IsHandleCreated)
                {
                    dgvHistorial.BeginInvoke(new Action(() =>
                    {
                        dgvHistorial.ClearSelection();
                        try { dgvHistorial.CurrentCell = null; } catch { }
                        idPacienteActual = 0;
                    }));
                }
                else
                {
                    // Forzar creación de handle (opcional) — puede tener efectos secundarios
                    var _ = dgvHistorial.Handle;
                    dgvHistorial.BeginInvoke(new Action(() =>
                    {
                        dgvHistorial.ClearSelection();
                        try { dgvHistorial.CurrentCell = null; } catch { }
                        idPacienteActual = 0;
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tratamientos: {ex.Message}");
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
                idPacienteActual = 0;
                return;
            }

            var row = dgvHistorial.Rows[rowIndex];

            // Si el DataSource es un DataTable, el DataBoundItem será DataRowView
            if (row.DataBoundItem is DataRowView drv)
            {
                idPacienteActual = drv.Row["Id"] != DBNull.Value ? Convert.ToInt32(drv.Row["Id"]) : 0;
                return;
            }

            // Si no, intentar leer desde la celda de la columna "N" (que enlaza Id) o desde "Id" si existe
            if (row.Cells["N"]?.Value != null && int.TryParse(row.Cells["N"].Value.ToString(), out int idFromN))
            {
                idPacienteActual = idFromN;
                return;
            }

            if (row.Cells["Id"]?.Value != null && int.TryParse(row.Cells["Id"].Value.ToString(), out int idFromId))
            {
                idPacienteActual = idFromId;
                return;
            }

            idPacienteActual = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarHistorialTratamientos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            paciente.Nombre = txtNombre.Text.Trim();
            paciente.Edad = int.TryParse(txtEdad.Text, out int edad) ? edad : 0;
            paciente.Sexo = cmbSexo.SelectedItem?.ToString();
            paciente.Direccion = txtDireccion.Text.Trim();
            paciente.Telefono = txtTelefono.Text.Trim();
            paciente.Alergias = txtAlergias.Text.Trim();

            // 🔹 HIPERSENSIBILIDAD (CHECKBOX)
            List<string> hiper = new List<string>();
            if (chkFrio.Checked) hiper.Add("Frio");
            if (chkCalor.Checked) hiper.Add("Calor");
            if (chkDulce.Checked) hiper.Add("Dulce");
            if (chkAcido.Checked) hiper.Add("Acido");
            if (chkPercusion.Checked) hiper.Add("Percusion");

            paciente.Hipersensibilidad = hiper.Count > 0 ? string.Join(", ", hiper) : null;

            // 🔹 SANGRADO DE ENCÍAS (RADIOBUTTON)
            if (rbSangradoSi.Checked)
                paciente.SangradoEncias = "Si";
            else if (rbSangradoNo.Checked)
                paciente.SangradoEncias = "No";
            else
                paciente.SangradoEncias = null;

            // --- Si hay una fila seleccionada y un idPacienteActual,
            //     comprobar si los datos en los controles coinciden con esa fila.
            //     Si no coinciden, tratamos el formulario como "nuevo paciente".
            if (dgvHistorial.CurrentRow == null)
            {
                idPacienteActual = 0;
            }
            else if (dgvHistorial.CurrentRow.DataBoundItem is DataRowView sel && idPacienteActual > 0)
            {
                string selNombre = sel.Row.Table.Columns.Contains("Nombre") ? (sel.Row["Nombre"]?.ToString().Trim() ?? "") : "";
                string selTelefono = sel.Row.Table.Columns.Contains("Telefono") ? (sel.Row["Telefono"]?.ToString().Trim() ?? "") : "";

                // Si no coinciden nombre o teléfono, consideramos que se quiere crear uno nuevo
                if (!string.Equals(selNombre, txtNombre.Text.Trim(), StringComparison.OrdinalIgnoreCase)
                    || (!string.IsNullOrWhiteSpace(txtTelefono.Text) && !string.Equals(selTelefono, txtTelefono.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                {
                    idPacienteActual = 0;
                }
            }

            if (idPacienteActual == 0)
            {
                if (paciente.Crear(out int nuevoId))
                {
                    MessageBox.Show("Paciente creado exitosamente ✅");
                    idPacienteActual = nuevoId;
                    CargarHistorialTratamientos();
                    // Asegurar que no quede seleccionada la nueva fila automáticamente
                    dgvHistorial.ClearSelection();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al crear el paciente.");
                }
            }
            else
            {
                // Actualmente no hay método Editar en clsPaciente.  
                // Mejor opción: implementar editar en clsPaciente y actualizar aquí.
                MessageBox.Show("El paciente ya existe. Si desea modificarlo, implemente la edición o pulse 'Nuevo' para crear otro.");
            }
        }


        private void LimpiarFormulario()
        {
            MessageBox.Show("Limpiando formulario");

            // 🔹 TextBox
            txtNombre.Clear();
            txtEdad.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtAlergias.Clear();

            // 🔹 ComboBox
            cmbSexo.SelectedIndex = -1;

            // 🔹 CheckBox (Hipersensibilidad)
            chkFrio.Checked = false;
            chkCalor.Checked = false;
            chkDulce.Checked = false;
            chkAcido.Checked = false;
            chkPercusion.Checked = false;

            // 🔹 RadioButton (Sangrado de encías)
            rbSangradoSi.Checked = false;
            rbSangradoNo.Checked = false;

            // 🔹 Variables de control
            idPacienteActual = 0;

            // 🔹 Limpiar selección del DataGridView
            dgvHistorial.ClearSelection();

            // 🔹 Enfocar primer campo
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            if (idPacienteActual == 0)
            {
                MessageBox.Show("No hay Paciente seleccionada para eliminar");
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
                paciente.Id = idPacienteActual;

                if (paciente.Eliminar())
                {
                    MessageBox.Show("Consulta eliminada exitosamente");
                    CargarHistorialTratamientos();

                }
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (idPacienteActual <= 0)
            {
                MessageBox.Show("Seleccione un paciente antes de agendar una consulta.", "Paciente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de Craer una Consulta?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                var agendarConsulta = new agendarConsultaForm(menuPrincipal, idPacienteActual);
                agendarConsulta.Show();
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (idPacienteActual == 0)
            {
                MessageBox.Show("No hay Paciente seleccionada para eliminar");
                return;
            }

            menuPrincipal.AbrirFormulario(new historialForm(menuPrincipal, idPacienteActual));
        }
    }

}
