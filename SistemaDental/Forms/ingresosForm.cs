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
    public partial class ingresosForm : Form
    {
        public ingresosForm()
        {
            InitializeComponent();
            ConfigurarDataGridViewIngresos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarIngresos();
        }

        private void ConfigurarDataGridViewIngresos()
        {
            dgvIngresos.AutoGenerateColumns = false;
            dgvIngresos.Columns.Clear();

            dgvIngresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha",
                HeaderText = "Fecha",
                DataPropertyName = "Fecha",
                Width = 90,
                ReadOnly = true
            });

            dgvIngresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MotivoConsulta",
                HeaderText = "Motivo Consulta",
                DataPropertyName = "MotivoConsulta",
                Width = 180,
                ReadOnly = true
            });

            dgvIngresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombrePaciente",
                HeaderText = "Nombre Paciente",
                DataPropertyName = "NombrePaciente",
                Width = 150,
                ReadOnly = true
            });

            dgvIngresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Numero",
                HeaderText = "N°",
                DataPropertyName = "Numero",
                Width = 40,
                ReadOnly = true
            });

            dgvIngresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cant.",
                DataPropertyName = "Cantidad",
                Width = 50,
                ReadOnly = true
            });

            dgvIngresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tratamiento",
                HeaderText = "Tratamiento",
                DataPropertyName = "Tratamiento",
                Width = 200,
                ReadOnly = true
            });

            dgvIngresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ValorUnitario",
                HeaderText = "Valor Uni",
                DataPropertyName = "ValorUnitario",
                Width = 80,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvIngresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SubTotal",
                HeaderText = "Sub Total",
                DataPropertyName = "SubTotal",
                Width = 90,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvIngresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Total",
                HeaderText = "Total",
                DataPropertyName = "Total",
                Width = 90,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvIngresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ValorCobrado",
                HeaderText = "Valor Cobra.",
                DataPropertyName = "ValorCobrado",
                Width = 90,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvIngresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SaldoPendiente",
                HeaderText = "Saldo Pend.",
                DataPropertyName = "SaldoPendiente",
                Width = 90,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvIngresos.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvIngresos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvIngresos.EnableHeadersVisualStyles = false;
        }


        private void CargarIngresos()
        {
            try
            {
                clsIngresos ingresos = new clsIngresos
                {
                    fechaInicio = dtpInicio.Value.Date,
                    fechaFinal = dtpFinal.Value.Date
                };

                DataTable dt = ingresos.ObtenerIngresosPorRango();

                if (dt.Rows.Count == 0)
                {
                    dgvIngresos.DataSource = null;
                    txtTotal.Text = "0.00";
                    MessageBox.Show("No hay datos");
                    return;
                }

                dgvIngresos.DataSource = dt;

                // 🔥 SUMAR SOLO UNA VEZ POR CONSULTA
                decimal totalCobrado = dt.AsEnumerable()
                    .GroupBy(r => r["Fecha"].ToString() + r["MotivoConsulta"].ToString() + r["NombrePaciente"].ToString())
                    .Select(g => Convert.ToDecimal(g.First()["ValorCobrado"]))
                    .Sum();

                txtTotal.Text = totalCobrado.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ingresos: " + ex.Message);
            }
        }


    }
}
