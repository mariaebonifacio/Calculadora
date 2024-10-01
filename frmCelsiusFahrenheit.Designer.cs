namespace Calculadora
{
    partial class frmCelsiusFahrenheit
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
            txtCelsius = new TextBox();
            label1 = new Label();
            btnConverter = new Button();
            label3 = new Label();
            txtFahrenheit = new TextBox();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(34, 71);
            txtCelsius.Multiline = true;
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(223, 40);
            txtCelsius.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(34, 48);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 1;
            label1.Text = "Temperatura em Celsius:";
            // 
            // btnConverter
            // 
            btnConverter.BackColor = Color.IndianRed;
            btnConverter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConverter.ForeColor = SystemColors.HighlightText;
            btnConverter.Location = new Point(263, 71);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(88, 40);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(34, 155);
            label3.Name = "label3";
            label3.Size = new Size(223, 22);
            label3.TabIndex = 4;
            label3.Text = "Temperatura em Fahrenheit";
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.BackColor = SystemColors.Window;
            txtFahrenheit.Location = new Point(34, 180);
            txtFahrenheit.Multiline = true;
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.ReadOnly = true;
            txtFahrenheit.Size = new Size(317, 49);
            txtFahrenheit.TabIndex = 5;
            txtFahrenheit.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.IndianRed;
            btnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = SystemColors.HighlightText;
            btnLimpar.Location = new Point(34, 117);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(86, 25);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmCelsiusFahrenheit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(389, 294);
            Controls.Add(btnLimpar);
            Controls.Add(txtFahrenheit);
            Controls.Add(label3);
            Controls.Add(btnConverter);
            Controls.Add(label1);
            Controls.Add(txtCelsius);
            Name = "frmCelsiusFahrenheit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConversor";
            FormClosed += frmConversor_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCelsius;
        private Label label1;
        private Button btnConverter;
        private Label label3;
        private TextBox txtFahrenheit;
        private Button btnLimpar;
    }
}