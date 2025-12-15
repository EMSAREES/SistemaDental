namespace SistemaDental.Forms
{
    partial class cobrar
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
            Cantidad = new Label();
            dgvTratamientos = new DataGridView();
            N = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            btnCobrar = new Button();
            lblTotal = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTotal = new TextBox();
            txtSaldoPendiente = new TextBox();
            dataGridView1 = new DataGridView();
            txtCantidad = new TextBox();
            label1 = new Label();
            txtValorUnitario = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtSubtotal = new TextBox();
            btnAnadir = new Button();
            txtTratamiento = new TextBox();
            btnEliminar = new Button();
            label7 = new Label();
            lblNombre = new Label();
            lblEdad = new Label();
            lblSexo = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtSexo = new TextBox();
            dtpFecha = new DateTimePicker();
            txtValorCobrar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTratamientos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cantidad.Location = new Point(24, 133);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(64, 20);
            Cantidad.TabIndex = 10;
            Cantidad.Text = "Cantidad";
            // 
            // dgvTratamientos
            // 
            dgvTratamientos.BackgroundColor = Color.White;
            dgvTratamientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTratamientos.Columns.AddRange(new DataGridViewColumn[] { N, Column1, Column2, Column3, Column4 });
            dgvTratamientos.GridColor = Color.White;
            dgvTratamientos.Location = new Point(24, 196);
            dgvTratamientos.Name = "dgvTratamientos";
            dgvTratamientos.Size = new Size(1028, 279);
            dgvTratamientos.TabIndex = 13;
            // 
            // N
            // 
            N.HeaderText = "N°";
            N.Name = "N";
            // 
            // Column1
            // 
            Column1.HeaderText = "Cantidad";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tratamiento";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Valor Uni.";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Subtotal";
            Column4.Name = "Column4";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Crimson;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.ForeColor = Color.Transparent;
            btnCancelar.Location = new Point(24, 481);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 38);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.DarkCyan;
            btnCobrar.Cursor = Cursors.Hand;
            btnCobrar.ForeColor = Color.Transparent;
            btnCobrar.Location = new Point(896, 525);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(156, 54);
            btnCobrar.TabIndex = 16;
            btnCobrar.Text = "COBRAR";
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(239, 538);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 20);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(382, 538);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 18;
            label3.Text = "Valor Cobrado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(634, 541);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 19;
            label4.Text = "Saldo Pendiente:";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(289, 538);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(78, 23);
            txtTotal.TabIndex = 20;
            // 
            // txtSaldoPendiente
            // 
            txtSaldoPendiente.Enabled = false;
            txtSaldoPendiente.Location = new Point(751, 542);
            txtSaldoPendiente.Name = "txtSaldoPendiente";
            txtSaldoPendiente.Size = new Size(128, 23);
            txtSaldoPendiente.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(305, 97);
            dataGridView1.TabIndex = 23;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(24, 156);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 24;
            txtCantidad.Text = "1";
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 133);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 25;
            label1.Text = "Tratamiento";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(591, 156);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.Size = new Size(100, 23);
            txtValorUnitario.TabIndex = 29;
            txtValorUnitario.TextChanged += txtValorUnitario_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(591, 133);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 28;
            label5.Text = "Valor Uni.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(697, 133);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 30;
            label6.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(697, 156);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(95, 23);
            txtSubtotal.TabIndex = 32;
            txtSubtotal.Text = "0.00";
            txtSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnAnadir
            // 
            btnAnadir.BackColor = Color.DarkCyan;
            btnAnadir.Cursor = Cursors.Hand;
            btnAnadir.ForeColor = Color.Transparent;
            btnAnadir.Location = new Point(814, 144);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(134, 35);
            btnAnadir.TabIndex = 33;
            btnAnadir.Text = "AÑADIR";
            btnAnadir.UseVisualStyleBackColor = false;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(130, 156);
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(455, 23);
            txtTratamiento.TabIndex = 34;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.ForeColor = Color.Transparent;
            btnEliminar.Location = new Point(979, 142);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(73, 38);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(782, 15);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 36;
            label7.Text = "Fecha:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(39, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 38;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(39, 54);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 39;
            lblEdad.Text = "Edad";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(39, 83);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(31, 15);
            lblSexo.TabIndex = 40;
            lblSexo.Text = "Sexo";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(113, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 41;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(113, 51);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 42;
            // 
            // txtSexo
            // 
            txtSexo.Enabled = false;
            txtSexo.Location = new Point(113, 80);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(100, 23);
            txtSexo.TabIndex = 43;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(838, 13);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(214, 23);
            dtpFecha.TabIndex = 44;
            dtpFecha.Value = new DateTime(2025, 11, 30, 0, 27, 45, 0);
            // 
            // txtValorCobrar
            // 
            txtValorCobrar.Location = new Point(479, 539);
            txtValorCobrar.Name = "txtValorCobrar";
            txtValorCobrar.Size = new Size(149, 23);
            txtValorCobrar.TabIndex = 45;
            // 
            // cobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1066, 606);
            Controls.Add(txtValorCobrar);
            Controls.Add(dtpFecha);
            Controls.Add(txtSexo);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblSexo);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(label7);
            Controls.Add(btnEliminar);
            Controls.Add(txtTratamiento);
            Controls.Add(btnAnadir);
            Controls.Add(txtSubtotal);
            Controls.Add(label6);
            Controls.Add(txtValorUnitario);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txtCantidad);
            Controls.Add(dataGridView1);
            Controls.Add(txtSaldoPendiente);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblTotal);
            Controls.Add(btnCobrar);
            Controls.Add(btnCancelar);
            Controls.Add(dgvTratamientos);
            Controls.Add(Cantidad);
            Name = "cobrar";
            Text = "Cobrar";
            Load += cobrarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTratamientos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Cantidad;
        private DataGridView dgvTratamientos;
        private Button btnCancelar;
        private Button btnCobrar;
        private Label lblTotal;
        private Label label3;
        private Label label4;
        private TextBox txtTotal;
        private TextBox txtSaldoPendiente;
        private DataGridView dataGridView1;
        private TextBox txtCantidad;
        private TextBox txtValorUnitario;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox txtSubtotal;
        private Button btnAnadir;
        private TextBox txtTratamiento;
        private Button btnEliminar;
        private Label label7;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblSexo;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtSexo;
        private DateTimePicker dtpFecha;
        private DataGridViewTextBoxColumn N;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txtValorCobrar;
    }
}