namespace SistemaDental.Forms
{
    partial class Consulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabControl2 = new TabControl();
            paciente = new TabPage();
            btnImprimir = new Button();
            txtSangrado = new TextBox();
            txtHipersensibilidad = new TextBox();
            txtAlergias = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtSexo = new TextBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblSangrado = new Label();
            lblHipersensibilidad = new Label();
            lblAlergias = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblSexo = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            btnCobrar = new Button();
            btnEliminar = new Button();
            btnAgendar = new Button();
            txtMotivo = new TextBox();
            tablaPaceinte = new DataGridView();
            label1 = new Label();
            motivodeconsulta = new Label();
            tratamientos = new TabPage();
            btnCo = new Button();
            txtSaldoPendiente = new TextBox();
            txtValorCobrado = new TextBox();
            txtTotal = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvHistorial = new DataGridView();
            contextMenuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabControl2.SuspendLayout();
            paciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaPaceinte).BeginInit();
            tratamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(20, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(8, 8);
            tabControl1.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(0, 0);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(0, 0);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(paciente);
            tabControl2.Controls.Add(tratamientos);
            tabControl2.Location = new Point(1, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1069, 609);
            tabControl2.TabIndex = 4;
            // 
            // paciente
            // 
            paciente.Controls.Add(btnImprimir);
            paciente.Controls.Add(txtSangrado);
            paciente.Controls.Add(txtHipersensibilidad);
            paciente.Controls.Add(txtAlergias);
            paciente.Controls.Add(txtTelefono);
            paciente.Controls.Add(txtDireccion);
            paciente.Controls.Add(txtSexo);
            paciente.Controls.Add(txtEdad);
            paciente.Controls.Add(txtNombre);
            paciente.Controls.Add(lblSangrado);
            paciente.Controls.Add(lblHipersensibilidad);
            paciente.Controls.Add(lblAlergias);
            paciente.Controls.Add(lblTelefono);
            paciente.Controls.Add(lblDireccion);
            paciente.Controls.Add(lblSexo);
            paciente.Controls.Add(lblEdad);
            paciente.Controls.Add(lblNombre);
            paciente.Controls.Add(btnCobrar);
            paciente.Controls.Add(btnEliminar);
            paciente.Controls.Add(btnAgendar);
            paciente.Controls.Add(txtMotivo);
            paciente.Controls.Add(tablaPaceinte);
            paciente.Controls.Add(label1);
            paciente.Controls.Add(motivodeconsulta);
            paciente.Location = new Point(4, 24);
            paciente.Name = "paciente";
            paciente.Padding = new Padding(3);
            paciente.Size = new Size(1061, 581);
            paciente.TabIndex = 0;
            paciente.Text = "Paciente";
            paciente.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.DarkCyan;
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.ForeColor = Color.Transparent;
            btnImprimir.Location = new Point(705, 471);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(156, 54);
            btnImprimir.TabIndex = 26;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtSangrado
            // 
            txtSangrado.Enabled = false;
            txtSangrado.Location = new Point(107, 356);
            txtSangrado.Name = "txtSangrado";
            txtSangrado.Size = new Size(150, 23);
            txtSangrado.TabIndex = 25;
            // 
            // txtHipersensibilidad
            // 
            txtHipersensibilidad.Enabled = false;
            txtHipersensibilidad.Location = new Point(154, 322);
            txtHipersensibilidad.Name = "txtHipersensibilidad";
            txtHipersensibilidad.Size = new Size(150, 23);
            txtHipersensibilidad.TabIndex = 24;
            // 
            // txtAlergias
            // 
            txtAlergias.Enabled = false;
            txtAlergias.Location = new Point(105, 289);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(150, 23);
            txtAlergias.TabIndex = 23;
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(105, 261);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 23);
            txtTelefono.TabIndex = 22;
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(107, 232);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 23);
            txtDireccion.TabIndex = 21;
            // 
            // txtSexo
            // 
            txtSexo.Enabled = false;
            txtSexo.Location = new Point(107, 200);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(150, 23);
            txtSexo.TabIndex = 20;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(107, 168);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(150, 23);
            txtEdad.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(107, 133);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 18;
            // 
            // lblSangrado
            // 
            lblSangrado.AutoSize = true;
            lblSangrado.Location = new Point(37, 359);
            lblSangrado.Name = "lblSangrado";
            lblSangrado.Size = new Size(57, 15);
            lblSangrado.TabIndex = 17;
            lblSangrado.Text = "Sangrado";
            // 
            // lblHipersensibilidad
            // 
            lblHipersensibilidad.AutoSize = true;
            lblHipersensibilidad.Location = new Point(37, 325);
            lblHipersensibilidad.Name = "lblHipersensibilidad";
            lblHipersensibilidad.Size = new Size(98, 15);
            lblHipersensibilidad.TabIndex = 16;
            lblHipersensibilidad.Text = "Hipersensibilidad";
            // 
            // lblAlergias
            // 
            lblAlergias.AutoSize = true;
            lblAlergias.Location = new Point(37, 292);
            lblAlergias.Name = "lblAlergias";
            lblAlergias.Size = new Size(49, 15);
            lblAlergias.TabIndex = 15;
            lblAlergias.Text = "Alergias";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(33, 266);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 14;
            lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(37, 235);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 13;
            lblDireccion.Text = "Direccion";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(37, 203);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(31, 15);
            lblSexo.TabIndex = 12;
            lblSexo.Text = "Sexo";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(37, 171);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 11;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 136);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.DarkCyan;
            btnCobrar.Cursor = Cursors.Hand;
            btnCobrar.ForeColor = Color.Transparent;
            btnCobrar.Location = new Point(543, 471);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(156, 54);
            btnCobrar.TabIndex = 9;
            btnCobrar.Text = "COBRAR";
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkCyan;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.ForeColor = Color.Transparent;
            btnEliminar.Location = new Point(384, 471);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(156, 54);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "ELIMINAR CONSULTA";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.DarkCyan;
            btnAgendar.Cursor = Cursors.Hand;
            btnAgendar.ForeColor = Color.Transparent;
            btnAgendar.Location = new Point(222, 471);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(156, 54);
            btnAgendar.TabIndex = 7;
            btnAgendar.Text = "AGENDAR CITA";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // txtMotivo
            // 
            txtMotivo.Enabled = false;
            txtMotivo.Location = new Point(163, 79);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(322, 23);
            txtMotivo.TabIndex = 5;
            // 
            // tablaPaceinte
            // 
            tablaPaceinte.BackgroundColor = SystemColors.Control;
            tablaPaceinte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaPaceinte.Location = new Point(21, 120);
            tablaPaceinte.Name = "tablaPaceinte";
            tablaPaceinte.Size = new Size(1028, 325);
            tablaPaceinte.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 4;
            label1.Text = "CONSULTA";
            // 
            // motivodeconsulta
            // 
            motivodeconsulta.AutoSize = true;
            motivodeconsulta.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            motivodeconsulta.Location = new Point(21, 79);
            motivodeconsulta.Name = "motivodeconsulta";
            motivodeconsulta.Size = new Size(133, 20);
            motivodeconsulta.TabIndex = 3;
            motivodeconsulta.Text = "Motivo de Consulta:";
            // 
            // tratamientos
            // 
            tratamientos.Controls.Add(btnCo);
            tratamientos.Controls.Add(txtSaldoPendiente);
            tratamientos.Controls.Add(txtValorCobrado);
            tratamientos.Controls.Add(txtTotal);
            tratamientos.Controls.Add(label4);
            tratamientos.Controls.Add(label3);
            tratamientos.Controls.Add(label2);
            tratamientos.Controls.Add(dgvHistorial);
            tratamientos.Location = new Point(4, 24);
            tratamientos.Name = "tratamientos";
            tratamientos.Padding = new Padding(3);
            tratamientos.Size = new Size(1061, 581);
            tratamientos.TabIndex = 1;
            tratamientos.Text = "Tratamientos";
            tratamientos.UseVisualStyleBackColor = true;
            // 
            // btnCo
            // 
            btnCo.BackColor = Color.DarkCyan;
            btnCo.Cursor = Cursors.Hand;
            btnCo.ForeColor = Color.Transparent;
            btnCo.Location = new Point(832, 405);
            btnCo.Name = "btnCo";
            btnCo.Size = new Size(156, 54);
            btnCo.TabIndex = 32;
            btnCo.Text = "COBRAR";
            btnCo.UseVisualStyleBackColor = false;
            btnCo.Click += btnCo_Click;
            // 
            // txtSaldoPendiente
            // 
            txtSaldoPendiente.Enabled = false;
            txtSaldoPendiente.Location = new Point(662, 426);
            txtSaldoPendiente.Name = "txtSaldoPendiente";
            txtSaldoPendiente.Size = new Size(128, 23);
            txtSaldoPendiente.TabIndex = 31;
            // 
            // txtValorCobrado
            // 
            txtValorCobrado.Location = new Point(398, 422);
            txtValorCobrado.Name = "txtValorCobrado";
            txtValorCobrado.Size = new Size(128, 23);
            txtValorCobrado.TabIndex = 30;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(200, 422);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(78, 23);
            txtTotal.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(545, 425);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 28;
            label4.Text = "Saldo Pendiente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(293, 422);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 27;
            label3.Text = "Valor Cobrado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 422);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 26;
            label2.Text = "Total:";
            // 
            // dgvHistorial
            // 
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.GridColor = Color.White;
            dgvHistorial.Location = new Point(3, 24);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(1028, 346);
            dgvHistorial.TabIndex = 23;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 606);
            Controls.Add(tabControl2);
            Controls.Add(tabControl1);
            Name = "Consulta";
            Text = "Consulta";
            contextMenuStrip1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            paciente.ResumeLayout(false);
            paciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaPaceinte).EndInit();
            tratamientos.ResumeLayout(false);
            tratamientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabControl tabControl2;
        private TabPage paciente;
        private TextBox txtMotivo;
        private Label label1;
        private Label motivodeconsulta;
        private TabPage tratamientos;
        private DataGridView tablaPaceinte;
        private Button btnAgendar;
        private Button btnCobrar;
        private Button btnEliminar;
        private TextBox txtSaldoPendiente;
        private TextBox txtValorCobrado;
        private TextBox txtTotal;
        private Label label4;
        private Label label3;
        private Label label2;
    
        private DataGridView dgvHistorial;
        private Label lblSangrado;
        private Label lblHipersensibilidad;
        private Label lblAlergias;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblSexo;
        private Label lblEdad;
        private Label lblNombre;
        private TextBox txtSangrado;
        private TextBox txtHipersensibilidad;
        private TextBox txtAlergias;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtSexo;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Button btnCo;
        private Button btnImprimir;
    }
}