namespace SistemaDental.Forms
{
    partial class Menu
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnIngresos = new Button();
            btnConsulta = new Button();
            btnPaciente = new Button();
            btnAgendar = new Button();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnIngresos);
            panel1.Controls.Add(btnConsulta);
            panel1.Controls.Add(btnPaciente);
            panel1.Controls.Add(btnAgendar);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 616);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(197, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 1;
            // 
            // btnIngresos
            // 
            btnIngresos.BackColor = Color.FromArgb(0, 122, 204);
            btnIngresos.Cursor = Cursors.Hand;
            btnIngresos.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresos.ForeColor = Color.Transparent;
            btnIngresos.Location = new Point(11, 221);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(180, 46);
            btnIngresos.TabIndex = 4;
            btnIngresos.Text = "Ingresos";
            btnIngresos.UseVisualStyleBackColor = false;
            btnIngresos.Click += btnIngresos_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = Color.FromArgb(0, 122, 204);
            btnConsulta.Cursor = Cursors.Hand;
            btnConsulta.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsulta.ForeColor = Color.Transparent;
            btnConsulta.Location = new Point(11, 158);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(180, 46);
            btnConsulta.TabIndex = 3;
            btnConsulta.Text = "Consulta";
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnPaciente
            // 
            btnPaciente.BackColor = Color.FromArgb(0, 122, 204);
            btnPaciente.Cursor = Cursors.Hand;
            btnPaciente.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaciente.ForeColor = Color.Transparent;
            btnPaciente.Location = new Point(11, 95);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new Size(180, 46);
            btnPaciente.TabIndex = 2;
            btnPaciente.Text = "Paciente";
            btnPaciente.UseVisualStyleBackColor = false;
            btnPaciente.Click += btnPaciente_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.FromArgb(0, 122, 204);
            btnAgendar.Cursor = Cursors.Hand;
            btnAgendar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgendar.ForeColor = Color.Transparent;
            btnAgendar.Location = new Point(11, 32);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(180, 46);
            btnAgendar.TabIndex = 1;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(201, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1084, 613);
            panelContenedor.TabIndex = 1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 611);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAgendar;
        private Button btnIngresos;
        private Button btnConsulta;
        private Button btnPaciente;
        private Panel panel2;
        private Panel panelContenedor;
    }
}