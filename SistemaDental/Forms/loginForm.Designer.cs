namespace SistemaDental.Forms
{
    partial class Login
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
            Dental = new Label();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            label3 = new Label();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // Dental
            // 
            Dental.AutoSize = true;
            Dental.Font = new Font("Britannic Bold", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dental.ForeColor = Color.Transparent;
            Dental.Location = new Point(12, 19);
            Dental.Name = "Dental";
            Dental.Size = new Size(133, 44);
            Dental.TabIndex = 0;
            Dental.Text = "Dental";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 1;
            label1.Text = "Inicia sesion para continuar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 137);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(307, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(12, 188);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(307, 23);
            txtContrasena.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(38, 94, 247);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.Transparent;
            btnEntrar.Location = new Point(12, 230);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(307, 32);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Ingresar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(331, 276);
            Controls.Add(btnEntrar);
            Controls.Add(txtContrasena);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Dental);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Dental;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label label3;
        private Button btnEntrar;
    }
}