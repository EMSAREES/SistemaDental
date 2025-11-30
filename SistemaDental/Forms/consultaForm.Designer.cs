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
            btnCobrar = new Button();
            btnEliminar = new Button();
            btnAgendar = new Button();
            textBox1 = new TextBox();
            tablaPaceinte = new DataGridView();
            label1 = new Label();
            motivodeconsulta = new Label();
            tratamientos = new TabPage();
            txtPendiente = new TextBox();
            txtCobrado = new TextBox();
            txtTotal = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            contextMenuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabControl2.SuspendLayout();
            paciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaPaceinte).BeginInit();
            tratamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            paciente.Controls.Add(btnCobrar);
            paciente.Controls.Add(btnEliminar);
            paciente.Controls.Add(btnAgendar);
            paciente.Controls.Add(textBox1);
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
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.DarkCyan;
            btnCobrar.Cursor = Cursors.Hand;
            btnCobrar.ForeColor = Color.Transparent;
            btnCobrar.Location = new Point(594, 474);
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
            btnEliminar.Location = new Point(435, 474);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(156, 54);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "ELIMINAR CONSULTA";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.DarkCyan;
            btnAgendar.Cursor = Cursors.Hand;
            btnAgendar.ForeColor = Color.Transparent;
            btnAgendar.Location = new Point(273, 474);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(156, 54);
            btnAgendar.TabIndex = 7;
            btnAgendar.Text = "AGENDAR CITA";
            btnAgendar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(163, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 23);
            textBox1.TabIndex = 5;
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
            motivodeconsulta.Click += motivodeconsulta_Click;
            // 
            // tratamientos
            // 
            tratamientos.Controls.Add(txtPendiente);
            tratamientos.Controls.Add(txtCobrado);
            tratamientos.Controls.Add(txtTotal);
            tratamientos.Controls.Add(label4);
            tratamientos.Controls.Add(label3);
            tratamientos.Controls.Add(label2);
            tratamientos.Controls.Add(button1);
            tratamientos.Controls.Add(dataGridView1);
            tratamientos.Location = new Point(4, 24);
            tratamientos.Name = "tratamientos";
            tratamientos.Padding = new Padding(3);
            tratamientos.Size = new Size(1061, 581);
            tratamientos.TabIndex = 1;
            tratamientos.Text = "Tratamientos";
            tratamientos.UseVisualStyleBackColor = true;
            // 
            // txtPendiente
            // 
            txtPendiente.Enabled = false;
            txtPendiente.Location = new Point(662, 426);
            txtPendiente.Name = "txtPendiente";
            txtPendiente.Size = new Size(128, 23);
            txtPendiente.TabIndex = 31;
            // 
            // txtCobrado
            // 
            txtCobrado.Enabled = false;
            txtCobrado.Location = new Point(398, 422);
            txtCobrado.Name = "txtCobrado";
            txtCobrado.Size = new Size(128, 23);
            txtCobrado.TabIndex = 30;
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
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(807, 409);
            button1.Name = "button1";
            button1.Size = new Size(156, 54);
            button1.TabIndex = 25;
            button1.Text = "COBRAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1028, 346);
            dataGridView1.TabIndex = 23;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 606);
            Controls.Add(tabControl2);
            Controls.Add(tabControl1);
            Name = "Consulta";
            Text = "consultaForm";
            contextMenuStrip1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            paciente.ResumeLayout(false);
            paciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaPaceinte).EndInit();
            tratamientos.ResumeLayout(false);
            tratamientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox textBox1;
        private Label label1;
        private Label motivodeconsulta;
        private TabPage tratamientos;
        private DataGridView tablaPaceinte;
        private Button btnAgendar;
        private Button btnCobrar;
        private Button btnEliminar;
        private TextBox txtPendiente;
        private TextBox txtCobrado;
        private TextBox txtTotal;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}