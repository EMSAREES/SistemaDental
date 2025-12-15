namespace SistemaDental.Forms
{
    partial class ingresosForm
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
            dgvIngresos = new DataGridView();
            label2 = new Label();
            txtTotal = new TextBox();
            label4 = new Label();
            label1 = new Label();
            dtpInicio = new DateTimePicker();
            dtpFinal = new DateTimePicker();
            btnConsultar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            SuspendLayout();
            // 
            // dgvIngresos
            // 
            dgvIngresos.BackgroundColor = Color.White;
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresos.GridColor = Color.White;
            dgvIngresos.Location = new Point(26, 100);
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.Size = new Size(1028, 391);
            dgvIngresos.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(149, 54);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 31;
            label2.Text = "Fecha Inicio";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(957, 509);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(97, 23);
            txtTotal.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(826, 509);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 35;
            label4.Text = "TOTAL COBRADO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(519, 56);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 38;
            label1.Text = "Fecha Fin";
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(271, 56);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(200, 23);
            dtpInicio.TabIndex = 39;
            // 
            // dtpFinal
            // 
            dtpFinal.Location = new Point(621, 58);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(200, 23);
            dtpFinal.TabIndex = 40;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(889, 45);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(114, 48);
            btnConsultar.TabIndex = 41;
            btnConsultar.Text = "CONSULTAR";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(141, 28);
            label3.TabIndex = 42;
            label3.Text = "INGRESOS";
            // 
            // ingresosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1066, 606);
            Controls.Add(label3);
            Controls.Add(btnConsultar);
            Controls.Add(dtpFinal);
            Controls.Add(dtpInicio);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dgvIngresos);
            Name = "ingresosForm";
            Text = "Ingresos";
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvIngresos;
        private Label label2;
        private TextBox txtTotal;
        private Label label4;
        private Label label1;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFinal;
        private Button btnConsultar;
        private Label label3;
    }
}