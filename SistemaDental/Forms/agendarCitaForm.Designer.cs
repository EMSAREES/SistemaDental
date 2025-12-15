namespace SistemaDental.Forms
{
    partial class agendarCitaForm
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
            fechadate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtHora = new TextBox();
            label3 = new Label();
            label4 = new Label();
            TextDetalle = new RichTextBox();
            label5 = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // fechadate
            // 
            fechadate.Location = new Point(80, 64);
            fechadate.Name = "fechadate";
            fechadate.Size = new Size(158, 23);
            fechadate.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 66);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(288, 66);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Hora:";
            // 
            // txtHora
            // 
            txtHora.Location = new Point(349, 64);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(107, 23);
            txtHora.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 36);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 4;
            label3.Text = "dd/mm/yyyy";
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(379, 36);
            label4.Name = "label4";
            label4.Size = new Size(75, 16);
            label4.TabIndex = 5;
            label4.Text = "hh/ss";
            // 
            // TextDetalle
            // 
            TextDetalle.Location = new Point(108, 125);
            TextDetalle.Name = "TextDetalle";
            TextDetalle.Size = new Size(348, 109);
            TextDetalle.TabIndex = 6;
            TextDetalle.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 125);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 7;
            label5.Text = "Detalles:";
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Location = new Point(173, 261);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 55);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // agendarCitaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 328);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(TextDetalle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtHora);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fechadate);
            Name = "agendarCitaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Cita";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker fechadate;
        private Label label1;
        private Label label2;
        private TextBox txtHora;
        private Label label3;
        private Label label4;
        private RichTextBox TextDetalle;
        private Label label5;
        private Button btnGuardar;
    }
}