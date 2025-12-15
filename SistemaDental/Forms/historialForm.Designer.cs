namespace SistemaDental.Forms
{
    partial class historialForm
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
            btnCita = new Button();
            dgvHistorial = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // btnCita
            // 
            btnCita.BackColor = Color.DarkCyan;
            btnCita.Cursor = Cursors.Hand;
            btnCita.ForeColor = Color.Transparent;
            btnCita.Location = new Point(12, 455);
            btnCita.Name = "btnCita";
            btnCita.Size = new Size(156, 54);
            btnCita.TabIndex = 40;
            btnCita.Text = "REGRESAR";
            btnCita.UseVisualStyleBackColor = false;
            btnCita.Click += btnCita_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.GridColor = Color.White;
            dgvHistorial.Location = new Point(12, 58);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(1021, 391);
            dgvHistorial.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 37;
            label1.Text = "HISTORIAL";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(877, 455);
            button1.Name = "button1";
            button1.Size = new Size(156, 54);
            button1.TabIndex = 41;
            button1.Text = "CONSULTA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // historialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 542);
            Controls.Add(button1);
            Controls.Add(btnCita);
            Controls.Add(dgvHistorial);
            Controls.Add(label1);
            Name = "historialForm";
            Text = "historial";
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCita;
        private DataGridView dgvHistorial;
        private Label label1;
        private Button button1;
    }
}