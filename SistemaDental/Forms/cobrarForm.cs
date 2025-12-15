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
    public partial class cobrar : Form
    {
        private Menu menuPrincipal;
        private clsPago objPago = new clsPago();
        private clsPagoDetalle objDetalle = new clsPagoDetalle();
        private clsAbono objAbono = new clsAbono();

        private int idConsultaActual = 0;
        private int idPacienteActual = 0;
        private decimal totalGeneral = 0;
        private bool pagoGuardado = false; // Para controlar si ya se guardó el pago

        public cobrar(Menu menu, int idConsulta, int idPaciente)
        {
            InitializeComponent();
            this.menuPrincipal = menu;
            this.idConsultaActual = idConsulta;
            this.idPacienteActual = idPaciente;

            // Configurar fecha actual
            dtpFecha.Value = DateTime.Now;
            dtpFecha.Enabled = false;
        }

        private void cobrarForm_Load(object sender, EventArgs e)
        {
            // Cargar datos del paciente y consulta
            CargarDatosPaciente();

            // Configurar DataGridView
            ConfigurarDataGridView();

            // Cargar detalles de tratamientos si existen
            CargarDetallesTratamientos();

            // Calcular total
            CalcularTotal();

            // Cargar pago existente (si ya existe uno para esta consulta)
            VerificarYCargarPagoExistente();
        }

        private void CargarDatosPaciente()
        {
            try
            {
                DataTable dt = objPago.ObtenerDatosCobro(idConsultaActual);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Mostrar datos del paciente en el GroupBox
                    txtNombre.Text = row["Nombre"].ToString();
                    txtEdad.Text = row["Edad"].ToString();
                    txtSexo.Text = row["Sexo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del paciente: {ex.Message}");
            }
        }

        private void ConfigurarDataGridView()
        {
            // Configurar columnas del DataGridView
            dgvTratamientos.AutoGenerateColumns = false;
            dgvTratamientos.Columns.Clear();

            dgvTratamientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "N",
                HeaderText = "N°",
                DataPropertyName = "Id",
                Width = 50,
                ReadOnly = true
            });

            dgvTratamientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                Width = 80,
                ReadOnly = true
            });

            dgvTratamientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tratamiento",
                HeaderText = "Tratamiento",
                DataPropertyName = "Tratamiento",
                Width = 300,
                ReadOnly = true
            });

            dgvTratamientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ValorUni",
                HeaderText = "Valor Uni.",
                DataPropertyName = "ValorUnitario",
                Width = 100,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvTratamientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Subtotal",
                HeaderText = "Subtotal",
                DataPropertyName = "Subtotal",
                Width = 100,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvTratamientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTratamientos.MultiSelect = false;
            dgvTratamientos.AllowUserToAddRows = false;
        }

        private void CargarDetallesTratamientos()
        {
            try
            {
                DataTable dt = objDetalle.ObtenerDetallesCompletos(idConsultaActual);
                dgvTratamientos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tratamientos: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de cancelar? Se perderán todos los cambios no guardados.",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                menuPrincipal.AbrirFormulario(new Consulta(menuPrincipal, idPacienteActual, idConsultaActual));
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            // Verificar si el pago ya fue guardado
            if (pagoGuardado)
            {
                MessageBox.Show("El pago ya fue guardado. No se pueden agregar más tratamientos.",
                    "Pago Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            agregar();
        }

        private void agregar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTratamiento.Text))
                {
                    MessageBox.Show("Ingrese el nombre del tratamiento", "Validación");
                    txtTratamiento.Focus();
                    return;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida", "Validación");
                    txtCantidad.Focus();
                    return;
                }

                if (!decimal.TryParse(txtValorUnitario.Text, out decimal valorUnitario) || valorUnitario <= 0)
                {
                    MessageBox.Show("Ingrese un valor unitario válido", "Validación");
                    txtValorUnitario.Focus();
                    return;
                }

                // Crear el detalle en la base de datos
                if (objDetalle.CrearDetalleCompleto(txtTratamiento.Text.Trim(), idConsultaActual, cantidad, valorUnitario, out int idDetalle))
                {
                    // Recargar la tabla desde la base de datos
                    CargarDetallesTratamientos();

                    // Calcular total
                    CalcularTotal();

                    // Limpiar campos
                    LimpiarCamposTratamiento();

                    MessageBox.Show("Tratamiento agregado exitosamente", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tratamiento: " + ex.Message, "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si el pago ya fue guardado
            if (pagoGuardado)
            {
                MessageBox.Show("El pago ya fue guardado. No se pueden eliminar tratamientos.",
                    "Pago Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            eliminar();
        }

        private void eliminar()
        {
            try
            {
                if (dgvTratamientos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un tratamiento para eliminar", "Validación");
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de eliminar este tratamiento?\nEsto eliminará el registro de la base de datos.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    // Obtener el ID del detalle seleccionado
                    int idDetalle = Convert.ToInt32(dgvTratamientos.SelectedRows[0].Cells["N"].Value);

                    // Eliminar de la base de datos
                    if (objDetalle.Eliminar(idDetalle))
                    {
                        MessageBox.Show("Tratamiento eliminado de la base de datos", "Éxito");

                        // Recargar tabla desde la base de datos
                        CargarDetallesTratamientos();

                        // Recalcular total
                        CalcularTotal();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error");
            }
        }

        private void CalcularTotal()
        {
            try
            {
                // Obtener total desde la base de datos
                totalGeneral = objDetalle.CalcularTotalConsulta(idConsultaActual);

                // Mostrar en textbox
                txtTotal.Text = totalGeneral.ToString("0.00");

                // Calcular saldo pendiente
                CalcularSaldoPendiente();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular total: {ex.Message}");
            }
        }

        private void CalcularSubtotal()
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad) &&
                decimal.TryParse(txtValorUnitario.Text, out decimal valorUni))
            {
                decimal subtotal = cantidad * valorUni;
                txtSubtotal.Text = subtotal.ToString("0.00");
            }
            else
            {
                txtSubtotal.Text = "0.00";
            }
        }

        private void CalcularSaldoPendiente()
        {
            try
            {
                decimal total = 0;
                decimal pagado = 0;

                // Total general
                decimal.TryParse(txtTotal.Text, out total);

                // Lo que paga el cliente
                decimal.TryParse(txtValorCobrar.Text, out pagado);

                // Calcular diferencia
                decimal saldo = total - pagado;

                if (saldo < 0)
                    saldo = 0; // No permitir saldo negativo

                txtSaldoPendiente.Text = saldo.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular saldo: {ex.Message}");
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya tratamientos
                if (dgvTratamientos.Rows.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un tratamiento antes de cobrar", "Validación");
                    return;
                }

                // Validar valor cobrado
                if (!decimal.TryParse(txtValorCobrar.Text, out decimal pagado) || pagado < 0)
                {
                    MessageBox.Show("Ingrese un valor cobrado válido", "Validación");
                    txtValorCobrar.Focus();
                    return;
                }

                if (pagado > totalGeneral)
                {
                    MessageBox.Show("El valor cobrado no puede ser mayor al total", "Validación");
                    return;
                }

                // Confirmar el pago
                DialogResult confirmar = MessageBox.Show(
                    $"¿Confirma el registro del pago?\n\nTotal: {totalGeneral:C2}\nPagado: {pagado:C2}\nSaldo: {(totalGeneral - pagado):C2}",
                    "Confirmar Pago",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmar == DialogResult.Yes)
                {
                    // Guardar pago en la base de datos
                    if (objPago.GuardarPagoCompleto(idConsultaActual, idPacienteActual, totalGeneral, pagado, out int idPago, out string mensaje) && objAbono.Crear( idPago, pagado, out int idAbono))
                    {
                        decimal saldo = totalGeneral - pagado;
                        string estadoDeuda = saldo > 0 ? "TIENE DEUDA PENDIENTE" : "SIN DEUDA";

                        MessageBox.Show(
                            $"{mensaje}\n\n" +
                            $"Total: {totalGeneral:C2}\n" +
                            $"Pagado: {pagado:C2}\n" +
                            $"Saldo: {saldo:C2}\n\n" +
                            $"Estado: {estadoDeuda}",
                            "Pago Guardado Exitosamente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        // Marcar como guardado y bloquear controles
                        BloquearControlesDespuesDePago();
                        pagoGuardado = true;
                        CalcularSaldoPendiente();

                        // Opcional: Cerrar y regresar después de un momento
                        // this.Close();
                        // menuPrincipal.AbrirFormulario(new Consulta(menuPrincipal, idPacienteActual));


                    }
                    else
                    {
                        MessageBox.Show($"Error al guardar el pago:\n{mensaje}", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar pago: " + ex.Message, "Error");
            }
        }

        // NUEVO MÉTODO: Bloquear controles después de guardar el pago
        private void BloquearControlesDespuesDePago()
        {
            // Bloquear botón cobrar
            btnCobrar.Enabled = false;
            btnCobrar.BackColor = System.Drawing.Color.Gray;

            // Bloquear valor cobrado
            txtValorCobrar.ReadOnly = true;
            txtValorCobrar.BackColor = System.Drawing.SystemColors.Control;

            // Bloquear campos de agregar tratamiento
            txtCantidad.ReadOnly = true;
            txtTratamiento.ReadOnly = true;
            txtValorUnitario.ReadOnly = true;
            btnAnadir.Enabled = false;
            btnEliminar.Enabled = false;

            // Cambiar color de botones deshabilitados
            btnAnadir.BackColor = System.Drawing.Color.Gray;
            btnEliminar.BackColor = System.Drawing.Color.Gray;
        }

        // NUEVO MÉTODO: Verificar si existe un pago guardado
        private void VerificarYCargarPagoExistente()
        {
            try
            {
                // Verificar si existe pago
                if (objPago.VerificarPagoExistente(idConsultaActual, out int idPago))
                {
                    // Cargar datos del pago
                    DataTable dtPago = objPago.ObtenerPorConsulta(idConsultaActual);

                    if (dtPago.Rows.Count > 0)
                    {
                        DataRow row = dtPago.Rows[0];
                        txtValorCobrar.Text = row["ValorPagado"].ToString();
                        CalcularSaldoPendiente();

                        // Marcar como guardado y bloquear controles
                        pagoGuardado = true;
                        BloquearControlesDespuesDePago();

                        MessageBox.Show(
                            "Esta consulta ya tiene un pago registrado.\nNo se pueden realizar modificaciones.",
                            "Pago Existente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar pago: {ex.Message}");
            }
        }

        private void LimpiarCamposTratamiento()
        {
            txtCantidad.Text = "1";
            txtTratamiento.Clear();
            txtValorUnitario.Clear();
            txtSubtotal.Clear();
            txtTratamiento.Focus();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }

        private void txtValorCobrado_TextChanged(object sender, EventArgs e)
        {
            CalcularSaldoPendiente();
        }
    }
}
