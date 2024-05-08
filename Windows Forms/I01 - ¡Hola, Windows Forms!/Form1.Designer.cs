namespace I01____Hola__Windows_Forms_
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
            lbl_Nombre = new Label();
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            lbl_Apellido = new Label();
            btn_Saludar = new Button();
            SuspendLayout();
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.BackColor = SystemColors.Highlight;
            lbl_Nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombre.Location = new Point(56, 9);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(53, 15);
            lbl_Nombre.TabIndex = 0;
            lbl_Nombre.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(23, 27);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(116, 23);
            txt_Nombre.TabIndex = 1;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(161, 27);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(116, 23);
            txt_Apellido.TabIndex = 3;
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Apellido.Location = new Point(194, 9);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(52, 15);
            lbl_Apellido.TabIndex = 2;
            lbl_Apellido.Text = "Apellido";
            // 
            // btn_Saludar
            // 
            btn_Saludar.Location = new Point(202, 67);
            btn_Saludar.Name = "btn_Saludar";
            btn_Saludar.Size = new Size(75, 23);
            btn_Saludar.TabIndex = 4;
            btn_Saludar.Text = "Saludar";
            btn_Saludar.UseVisualStyleBackColor = true;
            btn_Saludar.Click += btn_Saludar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(299, 122);
            Controls.Add(btn_Saludar);
            Controls.Add(txt_Apellido);
            Controls.Add(lbl_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_Nombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¡Hola, Windows Forms!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private Label lbl_Apellido;
        private Label lbl_Nombre;
        private Button btn_Saludar;
    }
}
