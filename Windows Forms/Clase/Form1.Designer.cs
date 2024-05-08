namespace Clase
{
    partial class Form1
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
            btn_Cerrar = new Button();
            btn_Saludar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.BackColor = Color.Chocolate;
            btn_Cerrar.ForeColor = Color.Black;
            btn_Cerrar.Location = new Point(133, 140);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(162, 57);
            btn_Cerrar.TabIndex = 0;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.UseVisualStyleBackColor = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // btn_Saludar
            // 
            btn_Saludar.BackColor = SystemColors.ActiveCaption;
            btn_Saludar.Location = new Point(484, 140);
            btn_Saludar.Name = "btn_Saludar";
            btn_Saludar.Size = new Size(128, 57);
            btn_Saludar.TabIndex = 1;
            btn_Saludar.Text = "Saludar";
            btn_Saludar.UseVisualStyleBackColor = false;
            btn_Saludar.Click += btn_Saludar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(323, 44);
            button1.Name = "button1";
            button1.Size = new Size(133, 50);
            button1.TabIndex = 2;
            button1.Text = "Abrir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn_Saludar);
            Controls.Add(btn_Cerrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Cerrar;
        private Button btn_Saludar;
        private Button button1;
    }
}
