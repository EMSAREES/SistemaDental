namespace SistemaDental.Forms
{
    partial class agendaForm
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
            dgvHistorial = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            btnCita = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 5;
            label1.Text = "AGENDA";
            // 
            // dgvHistorial
            // 
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.GridColor = Color.White;
            dgvHistorial.Location = new Point(219, 78);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(814, 330);
            dgvHistorial.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(13, 131);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // btnCita
            // 
            btnCita.BackColor = Color.DarkCyan;
            btnCita.Cursor = Cursors.Hand;
            btnCita.ForeColor = Color.Transparent;
            btnCita.Location = new Point(34, 173);
            btnCita.Name = "btnCita";
            btnCita.Size = new Size(156, 54);
            btnCita.TabIndex = 33;
            btnCita.Text = "VER CITAS";
            btnCita.UseVisualStyleBackColor = false;
            btnCita.Click += btnCita_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(456, 449);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 39);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "ELIMINAR CITA";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Location = new Point(662, 449);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(138, 39);
            btnActualizar.TabIndex = 35;
            btnActualizar.Text = "ACTUALIZAR CITA";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 108);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 36;
            label2.Text = "Fecha:";
            // 
            // agendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 542);
            Controls.Add(label2);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCita);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgvHistorial);
            Controls.Add(label1);
            Name = "agendaForm";
            Text = "agenda";
            Load += agendaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvHistorial;
        private DateTimePicker dateTimePicker1;
        private Button btnCita;
        private Button btnEliminar;
        private Button btnActualizar;
        private Label label2;
    }
}