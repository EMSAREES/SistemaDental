namespace SistemaDental.Forms
{
    partial class agendarConsultaForm
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtMotivo = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkCyan;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.ForeColor = Color.Transparent;
            btnGuardar.Location = new Point(346, 26);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 44);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkCyan;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.ForeColor = Color.Transparent;
            btnCancelar.Location = new Point(346, 76);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 44);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(259, 25);
            label1.TabIndex = 31;
            label1.Text = "Ingrese el motivo de consulta";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(12, 144);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(477, 23);
            txtMotivo.TabIndex = 32;
           
            // 
            // agendarConsultaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 179);
            Controls.Add(txtMotivo);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "agendarConsultaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "agendarConsultaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtMotivo;
    }
}