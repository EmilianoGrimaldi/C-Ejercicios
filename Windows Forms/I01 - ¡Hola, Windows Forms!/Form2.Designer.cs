namespace I01____Hola__Windows_Forms_
{
    partial class Form2
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
            lbl_Hola = new Label();
            lbl_Presentacion = new Label();
            SuspendLayout();
            // 
            // lbl_Hola
            // 
            lbl_Hola.AutoSize = true;
            lbl_Hola.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Hola.Location = new Point(12, 9);
            lbl_Hola.Name = "lbl_Hola";
            lbl_Hola.RightToLeft = RightToLeft.No;
            lbl_Hola.Size = new Size(64, 23);
            lbl_Hola.TabIndex = 0;
            lbl_Hola.Text = "Titulo";
            // 
            // lbl_Presentacion
            // 
            lbl_Presentacion.AutoSize = true;
            lbl_Presentacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Presentacion.Location = new Point(12, 50);
            lbl_Presentacion.Name = "lbl_Presentacion";
            lbl_Presentacion.Size = new Size(174, 21);
            lbl_Presentacion.TabIndex = 1;
            lbl_Presentacion.Text = "Soy {nombre} {apellido}";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(549, 154);
            Controls.Add(lbl_Presentacion);
            Controls.Add(lbl_Hola);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saludo";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Hola;
        private Label lbl_Presentacion;
    }
}