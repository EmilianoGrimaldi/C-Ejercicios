namespace Forms
{
    partial class FrmMostrar
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
            lbl_Nombre = new Label();
            SuspendLayout();
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nombre.Location = new Point(12, 52);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(203, 65);
            lbl_Nombre.TabIndex = 0;
            lbl_Nombre.Text = "Nombre";
            // 
            // FrmMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 186);
            Controls.Add(lbl_Nombre);
            Name = "FrmMostrar";
            Text = "Mostrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nombre;
    }
}