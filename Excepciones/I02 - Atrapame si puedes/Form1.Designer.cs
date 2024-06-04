namespace I02___Atrapame_si_puedes
{
    partial class formCalculador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblKilometros = new Label();
            lblLitros = new Label();
            txtKilometros = new TextBox();
            txtLitros = new TextBox();
            btnCalcular = new Button();
            rtbResultado = new RichTextBox();
            SuspendLayout();
            // 
            // lblKilometros
            // 
            lblKilometros.AutoSize = true;
            lblKilometros.Location = new Point(12, 9);
            lblKilometros.Name = "lblKilometros";
            lblKilometros.Size = new Size(64, 15);
            lblKilometros.TabIndex = 0;
            lblKilometros.Text = "Kilometros";
            // 
            // lblLitros
            // 
            lblLitros.AutoSize = true;
            lblLitros.Location = new Point(12, 69);
            lblLitros.Name = "lblLitros";
            lblLitros.Size = new Size(36, 15);
            lblLitros.TabIndex = 1;
            lblLitros.Text = "Litros";
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(12, 27);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(157, 23);
            txtKilometros.TabIndex = 2;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(12, 87);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(157, 23);
            txtLitros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 147);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(157, 27);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rtbResultado
            // 
            rtbResultado.Location = new Point(258, 9);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.ReadOnly = true;
            rtbResultado.Size = new Size(192, 165);
            rtbResultado.TabIndex = 5;
            rtbResultado.Text = "";
            // 
            // formCalculador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(494, 208);
            Controls.Add(rtbResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtLitros);
            Controls.Add(txtKilometros);
            Controls.Add(lblLitros);
            Controls.Add(lblKilometros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formCalculador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKilometros;
        private Label lblLitros;
        private TextBox txtKilometros;
        private TextBox txtLitros;
        private Button btnCalcular;
        private RichTextBox rtbResultado;
    }
}
