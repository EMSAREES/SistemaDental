using iTextSharp.text;
using iTextSharp.text.pdf;
using SistemaDental.Class;
using SistemaDental.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//imprimir pdf 
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;


namespace SistemaDental.Forms
{
    public partial class Consulta : Form
    {
        private Menu menuPrincipal;
        private clsConsulta objConsulta = new clsConsulta();



        private int idConsultaActual;
        private int idPacienteActual;



        public Consulta(Menu menu, int idPaciente = 0, int idConsultaActual = 0)
        {

            InitializeComponent();
            this.menuPrincipal = menu;
            this.idPacienteActual = idPaciente;
            this.idConsultaActual = idConsultaActual;

            // Cargar datos del paciente
            CargarDatosPaciente(idConsultaActual);

            // Cargar datos historial
            ConfigurarDataGridViewHistorial();
            CargarHistorialTratamientos();

        }


        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (idConsultaActual == 0)
            {
                MessageBox.Show("Debe crear una consulta primero");
                return;
            }

            // Pasar el ID de la consulta al formulario de cobrar
            menuPrincipal.AbrirFormulario(new cobrar(menuPrincipal, idConsultaActual, idPacienteActual));

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            agendarCitaForm agendarCita = new agendarCitaForm(idPacienteActual);
            //this.Hide();
            agendarCita.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        // Método para cargar los datos del paciente en el GroupBox
        private void CargarDatosPaciente(int idConsulta)
        {
            try
            {
                DataTable dt = objConsulta.ObtenerConsultaCompleta(idConsulta);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Asignar valores a los Labels dentro del GroupBox
                    txtMotivo.Text = row["Motivo"].ToString();

                    txtNombre.Text = row["Nombre"].ToString();
                    txtEdad.Text = row["Edad"].ToString();
                    txtSexo.Text = row["Sexo"].ToString();
                    txtDireccion.Text = row["Direccion"].ToString();
                    txtTelefono.Text = row["Telefono"].ToString();
                    txtAlergias.Text = row["Alergias"].ToString();
                    txtHipersensibilidad.Text = row["Hipersensibilidad"].ToString();
                    txtSangrado.Text = row["SangradoEncias"].ToString();

                }
                else
                {
                    MessageBox.Show("No se encontró el paciente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del paciente: {ex.Message}");
            }
        }

        // Método para cargar consulta completa (con datos del paciente)
        //private void CargarConsultaCompleta(int idConsulta)
        //{
        //    try
        //    {
        //        DataTable dt = objConsulta.ObtenerConsultaCompleta(idConsulta);

        //        if (dt.Rows.Count > 0)
        //        {
        //            DataRow row = dt.Rows[0];

        //            // Mostrar el motivo
        //            txtMotivo.Text = row["Motivo"].ToString();

        //            // Actualizar datos del paciente en el GroupBox
        //            lblNombre.Text = row["Nombre"].ToString();
        //            lblEdad.Text = row["Edad"].ToString();
        //            lblSexo.Text = row["Sexo"].ToString();
        //            lblDireccion.Text = row["Direccion"].ToString();
        //            lblTelefono.Text = row["Telefono"].ToString();
        //            lblAlergias.Text = row["Alergias"].ToString();
        //            lblSangrado.Text = row["SangradoEncias"].ToString();

        //            // Guardar IDs
        //            idConsultaActual = Convert.ToInt32(row["IdConsulta"]);
        //            idPacienteActual = Convert.ToInt32(row["IdPaciente"]);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al cargar consulta: {ex.Message}");
        //    }
        //}

        // Método para eliminar consulta
        private void eliminar()
        {
            if (idConsultaActual == 0)
            {
                MessageBox.Show("No hay consulta seleccionada para eliminar");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar esta consulta?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                if (objConsulta.Eliminar(idConsultaActual))
                {
                    MessageBox.Show("Consulta eliminada exitosamente");
                    LimpiarFormulario();
                }
            }
        }


        // Método para limpiar el formulario
        private void LimpiarFormulario()
        {
            // Limpiar todos los TextBox
            txtMotivo.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtSexo.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtAlergias.Clear();
            txtHipersensibilidad.Clear();
            txtSangrado.Clear();

            // Limpiar Labels (si los usas para mostrar datos cargados)
            //lblNombre.Text = string.Empty;
            //lblEdad.Text = string.Empty;
            //lblSexo.Text = string.Empty;
            //lblDireccion.Text = string.Empty;
            //lblTelefono.Text = string.Empty;
            //lblAlergias.Text = string.Empty;
            //lblSangrado.Text = string.Empty;

            // Resetear IDs
            idConsultaActual = 0;
            idPacienteActual = 0;

            txtMotivo.Clear();
            idConsultaActual = 0;
            // Mantener los datos del paciente

        }

        // Si quieres cargar una consulta existente al abrir el form
        public void CargarConsultaExistente(int idConsulta)
        {
            //CargarConsultaCompleta(idConsulta);
        }


        /*------------------Parte de Tratamiento -----------------------------------*/
        private clsTratamientoHistorial objHistorial = new clsTratamientoHistorial();
        private clsPago objPago = new clsPago();
        private clsAbono objAbono = new clsAbono();

        private decimal totalGeneral = 0;
        private int idPago = 0;

        private void ConfigurarDataGridViewHistorial()
        {
            dgvHistorial.AutoGenerateColumns = false;
            dgvHistorial.Columns.Clear();

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "N",
                HeaderText = "N°",
                DataPropertyName = "IdDetalle",
                Width = 40,
                ReadOnly = true
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                Width = 60,
                ReadOnly = true
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tratamiento",
                HeaderText = "Tratamiento",
                DataPropertyName = "Tratamiento",
                Width = 320,
                ReadOnly = true
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ValorUnitario",
                HeaderText = "Valor Uni.",
                DataPropertyName = "ValorUnitario",
                Width = 90,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Subtotal",
                HeaderText = "Subtotal",
                DataPropertyName = "Subtotal",
                Width = 90,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha",
                HeaderText = "Fecha",
                DataPropertyName = "FechaCreacion",
                Width = 100,
                ReadOnly = true
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Motivo",
                HeaderText = "Motivo",
                DataPropertyName = "NombreTratamiento", // o MotivoConsulta si lo agregas al SP
                Width = 200,
                ReadOnly = true
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado",
                Width = 80,
                ReadOnly = true
            });

            // Estilos del encabezado
            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistorial.EnableHeadersVisualStyles = false;

            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.MultiSelect = false;
            dgvHistorial.AllowUserToAddRows = false;
        }


        private decimal totalConsulta = 0;
        private decimal saldoPendiente = 0;

        private void CargarHistorialTratamientos()
        {
            try
            {
                DataTable dt = objHistorial.ObtenerTratamientoporconsulta(idConsultaActual);
                dgvHistorial.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    txtTotal.Text = "0.00";
                    txtSaldoPendiente.Text = "0.00";
                    return;
                }

                DataRow row = dt.Rows[0];

                // ID del pago si ya existe
                idPago = row["IdPago"] != DBNull.Value ? Convert.ToInt32(row["IdPago"]) : 0;

                // TOTAL REAL DE LA CONSULTA
                totalConsulta = row["TotalConsulta"] != DBNull.Value
                    ? Convert.ToDecimal(row["TotalConsulta"])
                    : 0;

                // SALDO REAL
                saldoPendiente = row["SaldoPendiente"] != DBNull.Value
                    ? Convert.ToDecimal(row["SaldoPendiente"])
                    : totalConsulta;

                // Mostramos los valores correctos
                txtTotal.Text = totalConsulta.ToString("0.00");
                txtSaldoPendiente.Text = saldoPendiente.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tratamientos: {ex.Message}");
            }
        }


        private void btnCo_Click(object sender, EventArgs e)
        {
            cobrar();
        }


        private void cobrar()
        {
            try
            {
                // VALIDACIÓN: Valor ingresado
                if (!decimal.TryParse(txtValorCobrado.Text, out decimal pagado) || pagado <= 0)
                {
                    MessageBox.Show("Ingrese un valor cobrado válido", "Validación");
                    return;
                }

                // VALIDACIÓN: No pagar más del saldo
                if (pagado > saldoPendiente)
                {
                    MessageBox.Show("El valor cobrado no puede ser mayor al saldo pendiente", "Validación");
                    return;
                }

                decimal nuevoSaldo = saldoPendiente - pagado;

                // CONFIRMAR
                DialogResult confirmar = MessageBox.Show(
                    $"¿Confirma el pago?\n\n" +
                    $"Total Consulta: {totalConsulta:C2}\n" +
                    $"Saldo Actual: {saldoPendiente:C2}\n" +
                    $"Pago: {pagado:C2}\n" +
                    $"Saldo Restante: {nuevoSaldo:C2}",
                    "Confirmar Pago",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmar != DialogResult.Yes)
                    return;

                // GUARDAR EL PAGO O ACTUALIZARLO
                if (!objPago.GuardarPagoCompleto(idConsultaActual, idPacienteActual, totalConsulta,
                                                 pagado, out idPago, out string mensaje))
                {
                    MessageBox.Show($"Error al guardar el pago:\n{mensaje}", "Error");
                    return;
                }

                // CREAR EL ABONO
                if (!objAbono.Crear(idPago, pagado, out int idAbono))
                {
                    MessageBox.Show("Error al registrar el abono", "Error");
                    return;
                }

                // MOSTRAR RESULTADO
                string estado = nuevoSaldo > 0 ? "TIENE DEUDA PENDIENTE" : "SIN DEUDA";

                MessageBox.Show(
                    $"{mensaje}\n\n" +
                    $"Total: {totalConsulta:C2}\n" +
                    $"Pagado ahora: {pagado:C2}\n" +
                    $"Saldo pendiente: {nuevoSaldo:C2}\n" +
                    $"Estado: {estado}",
                    "Pago registrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // RECARGAR DATOS
                RefrescarPantalla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void RefrescarPantalla()
        {
            CargarHistorialTratamientos();   // Recarga la tabla y los totales desde BD
            txtValorCobrado.Text = "";       // Limpia el valor cobrado
        }

        /*------------------Parte de Imprimir -----------------------------------*/
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            GenerarPDF();
        }

        private void GenerarPDF()
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = $"Recibo_{idPago}.pdf";

                if (save.ShowDialog() != DialogResult.OK)
                    return;

                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));

                doc.Open();

                // ------------------------------------------
                // FUENTES
                // ------------------------------------------
                Font fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Font fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                Font fontBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                // ------------------------------------------
                // ENCABEZADO
                // ------------------------------------------
                Paragraph titulo = new Paragraph("CLÍNICA DENTAL\nRECIBO DE PAGO\n\n", fontTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                doc.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}\n", fontNormal));
                doc.Add(new Paragraph($"Número de Recibo: {idPago}\n", fontNormal));
                doc.Add(new Paragraph("---------------------------------------------\n", fontNormal));

                // ------------------------------------------
                // DATOS DEL PACIENTE
                // ------------------------------------------
                doc.Add(new Paragraph($"Paciente: {txtNombre.Text}", fontNormal));
                doc.Add(new Paragraph($"Consulta ID: {idConsultaActual}\n", fontNormal));
                doc.Add(new Paragraph($"Motivo: {txtMotivo.Text}\n\n", fontNormal));

                // ------------------------------------------
                // TABLA
                // ------------------------------------------
                PdfPTable tabla = new PdfPTable(4);
                tabla.WidthPercentage = 100;

                tabla.AddCell("Tratamiento");
                tabla.AddCell("Cant");
                tabla.AddCell("Valor Uni");
                tabla.AddCell("Subtotal");

                foreach (DataGridViewRow row in dgvHistorial.Rows)
                {
                    tabla.AddCell(row.Cells["Tratamiento"].Value.ToString());
                    tabla.AddCell(row.Cells["Cantidad"].Value.ToString());
                    tabla.AddCell(Convert.ToDecimal(row.Cells["ValorUnitario"].Value).ToString("C2"));
                    tabla.AddCell(Convert.ToDecimal(row.Cells["Subtotal"].Value).ToString("C2"));
                }

                doc.Add(tabla);
                doc.Add(new Paragraph("\n"));

                // ------------------------------------------
                // TOTALES
                // ------------------------------------------
                doc.Add(new Paragraph($"TOTAL CONSULTA: {totalConsulta:C2}", fontBold));
                doc.Add(new Paragraph($"TOTAL PAGADO: {(totalConsulta - saldoPendiente):C2}", fontNormal));
                doc.Add(new Paragraph($"SALDO PENDIENTE: {saldoPendiente:C2}\n\n", fontBold));

                doc.Add(new Paragraph("---------------------------------------------\n", fontNormal));
                doc.Add(new Paragraph("Gracias por su preferencia.\n\n", fontNormal));
                doc.Add(new Paragraph("Firma del Doctor: _______________________\n\n", fontNormal));

                doc.Close();

                MessageBox.Show("PDF generado correctamente.", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar PDF: {ex.Message}");
            }
        }

    }
}
