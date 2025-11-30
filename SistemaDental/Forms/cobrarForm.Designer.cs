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
            tablaPaceinte = new DataGridView();
            btnCancelar = new Button();
            btnCobrar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTotal = new TextBox();
            txtCobrado = new TextBox();
            txtPendiente = new TextBox();
            dataGridView1 = new DataGridView();
            txtCantidad = new TextBox();
            label1 = new Label();
            txtTratamiento = new ComboBox();
            txtValor = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtSubtotal = new TextBox();
            btnAnadir = new Button();
            ((System.ComponentModel.ISupportInitialize)tablaPaceinte).BeginInit();
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
            // tablaPaceinte
            // 
            tablaPaceinte.BackgroundColor = Color.White;
            tablaPaceinte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaPaceinte.GridColor = Color.White;
            tablaPaceinte.Location = new Point(24, 196);
            tablaPaceinte.Name = "tablaPaceinte";
            tablaPaceinte.Size = new Size(1028, 279);
            tablaPaceinte.TabIndex = 13;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 538);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 17;
            label2.Text = "Total:";
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
            // txtCobrado
            // 
            txtCobrado.Enabled = false;
            txtCobrado.Location = new Point(487, 538);
            txtCobrado.Name = "txtCobrado";
            txtCobrado.Size = new Size(128, 23);
            txtCobrado.TabIndex = 21;
            // 
            // txtPendiente
            // 
            txtPendiente.Enabled = false;
            txtPendiente.Location = new Point(751, 542);
            txtPendiente.Name = "txtPendiente";
            txtPendiente.Size = new Size(128, 23);
            txtPendiente.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(377, 65);
            dataGridView1.TabIndex = 23;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(24, 156);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 24;
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
            // txtTratamiento
            // 
            txtTratamiento.FormattingEnabled = true;
            txtTratamiento.Location = new Point(130, 156);
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(455, 23);
            txtTratamiento.TabIndex = 27;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(591, 156);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 29;
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
            label6.Size = new Size(71, 20);
            label6.TabIndex = 30;
            label6.Text = "Valor Uni.";
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
            btnAnadir.Text = "Añadir";
            btnAnadir.UseVisualStyleBackColor = false;
            // 
            // cobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1066, 606);
            Controls.Add(btnAnadir);
            Controls.Add(txtSubtotal);
            Controls.Add(label6);
            Controls.Add(txtValor);
            Controls.Add(label5);
            Controls.Add(txtTratamiento);
            Controls.Add(label1);
            Controls.Add(txtCantidad);
            Controls.Add(dataGridView1);
            Controls.Add(txtPendiente);
            Controls.Add(txtCobrado);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCobrar);
            Controls.Add(btnCancelar);
            Controls.Add(tablaPaceinte);
            Controls.Add(Cantidad);
            Name = "cobrar";
            Text = "Cobrar";
            Load += cobrarForm_Load;
            ((System.ComponentModel.ISupportInitialize)tablaPaceinte).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Cantidad;
        private DataGridView tablaPaceinte;
        private Button btnCancelar;
        private Button btnCobrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTotal;
        private TextBox txtCobrado;
        private TextBox txtPendiente;
        private DataGridView dataGridView1;
        private TextBox txtCantidad;
        private TextBox txtValor;
        private Label label1;
        private ComboBox txtTratamiento;
        private Label label5;
        private Label label6;
        private TextBox txtSubtotal;
        private Button btnAnadir;
    }
}