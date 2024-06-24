namespace FormAvisador
{
    partial class frmAvisador
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
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            lbl_Nombre = new Label();
            lbl_Apellido = new Label();
            btn_Crear = new Button();
            lbl_NombreApellido = new Label();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(130, 44);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(102, 23);
            txt_Nombre.TabIndex = 0;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(130, 117);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(102, 23);
            txt_Apellido.TabIndex = 1;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nombre.Location = new Point(39, 47);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(57, 17);
            lbl_Nombre.TabIndex = 2;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Apellido.Location = new Point(39, 120);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(56, 17);
            lbl_Apellido.TabIndex = 3;
            lbl_Apellido.Text = "Apellido";
            // 
            // btn_Crear
            // 
            btn_Crear.Location = new Point(39, 202);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(193, 23);
            btn_Crear.TabIndex = 4;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = true;
            btn_Crear.Click += btn_Actualizar_Click;
            // 
            // lbl_NombreApellido
            // 
            lbl_NombreApellido.AutoSize = true;
            lbl_NombreApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NombreApellido.Location = new Point(55, 257);
            lbl_NombreApellido.Name = "lbl_NombreApellido";
            lbl_NombreApellido.Size = new Size(159, 25);
            lbl_NombreApellido.TabIndex = 5;
            lbl_NombreApellido.Text = "Nombre_Apellido";
            // 
            // frmAvisador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(260, 307);
            Controls.Add(lbl_NombreApellido);
            Controls.Add(btn_Crear);
            Controls.Add(lbl_Apellido);
            Controls.Add(lbl_Nombre);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Name = "frmAvisador";
            Text = "El Avisador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Button btn_Crear;
        private Label lbl_NombreApellido;
    }
}
