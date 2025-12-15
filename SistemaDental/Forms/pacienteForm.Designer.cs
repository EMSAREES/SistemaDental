namespace SistemaDental.Forms
{
    partial class Paciente
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbSexo = new ComboBox();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            chkFrio = new CheckBox();
            rbSangradoSi = new RadioButton();
            label6 = new Label();
            chkCalor = new CheckBox();
            chkAcido = new CheckBox();
            chkDulce = new CheckBox();
            chkPercusion = new CheckBox();
            label7 = new Label();
            rbSangradoNo = new RadioButton();
            dgvHistorial = new DataGridView();
            txtBuscarPaciente = new TextBox();
            label8 = new Label();
            btnConsulta = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnHistorial = new Button();
            btnBuscar = new Button();
            txtAlergias = new TextBox();
            Alergias = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(131, 16);
            label1.TabIndex = 0;
            label1.Text = "Nombres y Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(12, 166);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(241, 23);
            txtEdad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(39, 16);
            label2.TabIndex = 2;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 201);
            label3.Name = "label3";
            label3.Size = new Size(40, 16);
            label3.TabIndex = 4;
            label3.Text = "Sexo";
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            cmbSexo.Location = new Point(12, 220);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(241, 23);
            cmbSexo.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 271);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(241, 23);
            txtDireccion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 250);
            label4.Name = "label4";
            label4.Size = new Size(67, 16);
            label4.TabIndex = 7;
            label4.Text = "Direccion";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(12, 324);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(241, 23);
            txtTelefono.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 303);
            label5.Name = "label5";
            label5.Size = new Size(62, 16);
            label5.TabIndex = 9;
            label5.Text = "Telefono";
            // 
            // chkFrio
            // 
            chkFrio.AutoSize = true;
            chkFrio.Location = new Point(12, 429);
            chkFrio.Name = "chkFrio";
            chkFrio.Size = new Size(46, 19);
            chkFrio.TabIndex = 11;
            chkFrio.Text = "Frio";
            chkFrio.UseVisualStyleBackColor = true;
            // 
            // rbSangradoSi
            // 
            rbSangradoSi.AutoSize = true;
            rbSangradoSi.Location = new Point(12, 479);
            rbSangradoSi.Name = "rbSangradoSi";
            rbSangradoSi.Size = new Size(34, 19);
            rbSangradoSi.TabIndex = 12;
            rbSangradoSi.TabStop = true;
            rbSangradoSi.Text = "Si";
            rbSangradoSi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 410);
            label6.Name = "label6";
            label6.Size = new Size(117, 16);
            label6.TabIndex = 13;
            label6.Text = "Hipersensibilidad";
            // 
            // chkCalor
            // 
            chkCalor.AutoSize = true;
            chkCalor.Location = new Point(64, 429);
            chkCalor.Name = "chkCalor";
            chkCalor.Size = new Size(54, 19);
            chkCalor.TabIndex = 14;
            chkCalor.Text = "Calor";
            chkCalor.UseVisualStyleBackColor = true;
            // 
            // chkAcido
            // 
            chkAcido.AutoSize = true;
            chkAcido.Location = new Point(186, 429);
            chkAcido.Name = "chkAcido";
            chkAcido.Size = new Size(57, 19);
            chkAcido.TabIndex = 16;
            chkAcido.Text = "Acido";
            chkAcido.UseVisualStyleBackColor = true;
            // 
            // chkDulce
            // 
            chkDulce.AutoSize = true;
            chkDulce.Location = new Point(124, 429);
            chkDulce.Name = "chkDulce";
            chkDulce.Size = new Size(56, 19);
            chkDulce.TabIndex = 15;
            chkDulce.Text = "Dulce";
            chkDulce.UseVisualStyleBackColor = true;
            // 
            // chkPercusion
            // 
            chkPercusion.AutoSize = true;
            chkPercusion.Location = new Point(249, 429);
            chkPercusion.Name = "chkPercusion";
            chkPercusion.Size = new Size(78, 19);
            chkPercusion.TabIndex = 17;
            chkPercusion.Text = "Percusion";
            chkPercusion.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 460);
            label7.Name = "label7";
            label7.Size = new Size(134, 16);
            label7.TabIndex = 18;
            label7.Text = "Sangrado de Encias";
            // 
            // rbSangradoNo
            // 
            rbSangradoNo.AutoSize = true;
            rbSangradoNo.Location = new Point(64, 479);
            rbSangradoNo.Name = "rbSangradoNo";
            rbSangradoNo.Size = new Size(41, 19);
            rbSangradoNo.TabIndex = 19;
            rbSangradoNo.TabStop = true;
            rbSangradoNo.Text = "No";
            rbSangradoNo.UseVisualStyleBackColor = true;
            // 
            // dgvHistorial
            // 
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.GridColor = Color.White;
            dgvHistorial.Location = new Point(333, 89);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(714, 359);
            dgvHistorial.TabIndex = 25;
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Location = new Point(333, 60);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.Size = new Size(319, 23);
            txtBuscarPaciente.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(333, 39);
            label8.Name = "label8";
            label8.Size = new Size(131, 16);
            label8.TabIndex = 26;
            label8.Text = "Nombres y Apellido";
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = Color.DarkCyan;
            btnConsulta.Cursor = Cursors.Hand;
            btnConsulta.ForeColor = Color.Transparent;
            btnConsulta.Location = new Point(631, 509);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(156, 54);
            btnConsulta.TabIndex = 31;
            btnConsulta.Text = "CONSULTA";
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkCyan;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.ForeColor = Color.Transparent;
            btnLimpiar.Location = new Point(469, 509);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(156, 54);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkCyan;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.ForeColor = Color.Transparent;
            btnEliminar.Location = new Point(310, 509);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(156, 54);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkCyan;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.ForeColor = Color.Transparent;
            btnGuardar.Location = new Point(148, 509);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(156, 54);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.DarkCyan;
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.ForeColor = Color.Transparent;
            btnHistorial.Location = new Point(793, 509);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(156, 54);
            btnHistorial.TabIndex = 32;
            btnHistorial.Text = "HISTORIAL";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkCyan;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.ForeColor = Color.Transparent;
            btnBuscar.Location = new Point(672, 39);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 44);
            btnBuscar.TabIndex = 33;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(12, 375);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(241, 23);
            txtAlergias.TabIndex = 35;
            // 
            // Alergias
            // 
            Alergias.AutoSize = true;
            Alergias.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Alergias.Location = new Point(12, 354);
            Alergias.Name = "Alergias";
            Alergias.Size = new Size(59, 16);
            Alergias.TabIndex = 34;
            Alergias.Text = "Alergias";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(136, 28);
            label9.TabIndex = 36;
            label9.Text = "PACIENTE";
            // 
            // Paciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 606);
            Controls.Add(label9);
            Controls.Add(txtAlergias);
            Controls.Add(Alergias);
            Controls.Add(btnBuscar);
            Controls.Add(btnHistorial);
            Controls.Add(btnConsulta);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtBuscarPaciente);
            Controls.Add(label8);
            Controls.Add(dgvHistorial);
            Controls.Add(rbSangradoNo);
            Controls.Add(label7);
            Controls.Add(chkPercusion);
            Controls.Add(chkAcido);
            Controls.Add(chkDulce);
            Controls.Add(chkCalor);
            Controls.Add(label6);
            Controls.Add(rbSangradoSi);
            Controls.Add(chkFrio);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(cmbSexo);
            Controls.Add(label3);
            Controls.Add(txtEdad);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Paciente";
            Text = "pacienteForm";
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label label2;
        private Label label3;
        private ComboBox cmbSexo;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private CheckBox chkFrio;
        private RadioButton rbSangradoSi;
        private Label label6;
        private CheckBox chkCalor;
        private CheckBox chkAcido;
        private CheckBox chkDulce;
        private CheckBox chkPercusion;
        private Label label7;
        private RadioButton rbSangradoNo;
        private DataGridView dgvHistorial;
        private TextBox txtBuscarPaciente;
        private Label label8;
        private Button btnConsulta;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnHistorial;
        private Button btnBuscar;
        private TextBox txtAlergias;
        private Label Alergias;
        private Label label9;
    }
}