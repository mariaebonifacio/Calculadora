namespace Calculadora
{
    partial class FrmCentimetrosPolegadas
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
            txtCentimetros = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtPolegadas = new TextBox();
            btnConverter = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtCentimetros
            // 
            txtCentimetros.Location = new Point(32, 75);
            txtCentimetros.Multiline = true;
            txtCentimetros.Name = "txtCentimetros";
            txtCentimetros.Size = new Size(354, 40);
            txtCentimetros.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(32, 52);
            label2.Name = "label2";
            label2.Size = new Size(223, 20);
            label2.TabIndex = 2;
            label2.Text = "Medida em centímetros:";
            // 
            // label1
            // 
            label1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(32, 194);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 3;
            label1.Text = "Medida em polegadas:";
            label1.Click += label1_Click;
            // 
            // txtPolegadas
            // 
            txtPolegadas.Location = new Point(32, 217);
            txtPolegadas.Multiline = true;
            txtPolegadas.Name = "txtPolegadas";
            txtPolegadas.ReadOnly = true;
            txtPolegadas.Size = new Size(354, 40);
            txtPolegadas.TabIndex = 4;
            // 
            // btnConverter
            // 
            btnConverter.BackColor = Color.DarkGreen;
            btnConverter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConverter.ForeColor = SystemColors.HighlightText;
            btnConverter.Location = new Point(32, 135);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(99, 40);
            btnConverter.TabIndex = 5;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Green;
            btnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = SystemColors.HighlightText;
            btnLimpar.Location = new Point(169, 286);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(86, 25);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FrmCentimetrosPolegadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(423, 350);
            Controls.Add(btnLimpar);
            Controls.Add(btnConverter);
            Controls.Add(txtPolegadas);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtCentimetros);
            Name = "FrmCentimetrosPolegadas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCentimetrosPolegadas";
            FormClosed += FrmCentimetrosPolegadas_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCentimetros;
        private Label label2;
        private Label label1;
        private TextBox txtPolegadas;
        private Button btnConverter;
        private Button btnLimpar;
    }
}