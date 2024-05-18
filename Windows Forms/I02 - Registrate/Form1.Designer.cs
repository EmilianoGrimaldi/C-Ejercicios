namespace I02___Registrate
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
            gb_Datos = new GroupBox();
            nud_Edad = new NumericUpDown();
            txt_Nombre = new TextBox();
            txt_Direccion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lbl_Nombre = new Label();
            gb_Genero = new GroupBox();
            rb_Masculino = new RadioButton();
            rb_NoBinario = new RadioButton();
            rb_Femenino = new RadioButton();
            gb_Cursos = new GroupBox();
            cb_CSharp = new CheckBox();
            cb_CMasMas = new CheckBox();
            cb_JavaScript = new CheckBox();
            Paises = new ListBox();
            btn_Ingresar = new Button();
            gb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Edad).BeginInit();
            gb_Genero.SuspendLayout();
            gb_Cursos.SuspendLayout();
            SuspendLayout();
            // 
            // gb_Datos
            // 
            gb_Datos.Controls.Add(nud_Edad);
            gb_Datos.Controls.Add(txt_Nombre);
            gb_Datos.Controls.Add(txt_Direccion);
            gb_Datos.Controls.Add(label3);
            gb_Datos.Controls.Add(label2);
            gb_Datos.Controls.Add(lbl_Nombre);
            gb_Datos.Location = new Point(12, 12);
            gb_Datos.Name = "gb_Datos";
            gb_Datos.Size = new Size(141, 176);
            gb_Datos.TabIndex = 0;
            gb_Datos.TabStop = false;
            gb_Datos.Text = "Datos";
            // 
            // nud_Edad
            // 
            nud_Edad.Location = new Point(6, 139);
            nud_Edad.Name = "nud_Edad";
            nud_Edad.Size = new Size(120, 23);
            nud_Edad.TabIndex = 1;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(6, 46);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 1;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(6, 95);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(100, 23);
            txt_Direccion.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 121);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Direccion";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(6, 28);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 1;
            lbl_Nombre.Text = "Nombre";
            // 
            // gb_Genero
            // 
            gb_Genero.Controls.Add(rb_Masculino);
            gb_Genero.Controls.Add(rb_NoBinario);
            gb_Genero.Controls.Add(rb_Femenino);
            gb_Genero.Location = new Point(159, 12);
            gb_Genero.Name = "gb_Genero";
            gb_Genero.Size = new Size(146, 100);
            gb_Genero.TabIndex = 1;
            gb_Genero.TabStop = false;
            gb_Genero.Text = "Genero";
            // 
            // rb_Masculino
            // 
            rb_Masculino.AutoSize = true;
            rb_Masculino.Location = new Point(6, 22);
            rb_Masculino.Name = "rb_Masculino";
            rb_Masculino.Size = new Size(80, 19);
            rb_Masculino.TabIndex = 1;
            rb_Masculino.TabStop = true;
            rb_Masculino.Text = "Masculino";
            rb_Masculino.UseVisualStyleBackColor = true;
            // 
            // rb_NoBinario
            // 
            rb_NoBinario.AutoSize = true;
            rb_NoBinario.Location = new Point(6, 72);
            rb_NoBinario.Name = "rb_NoBinario";
            rb_NoBinario.Size = new Size(81, 19);
            rb_NoBinario.TabIndex = 3;
            rb_NoBinario.TabStop = true;
            rb_NoBinario.Text = "No binario";
            rb_NoBinario.UseVisualStyleBackColor = true;
            // 
            // rb_Femenino
            // 
            rb_Femenino.AutoSize = true;
            rb_Femenino.Location = new Point(6, 46);
            rb_Femenino.Name = "rb_Femenino";
            rb_Femenino.Size = new Size(78, 19);
            rb_Femenino.TabIndex = 2;
            rb_Femenino.TabStop = true;
            rb_Femenino.Text = "Femenino";
            rb_Femenino.UseVisualStyleBackColor = true;
            // 
            // gb_Cursos
            // 
            gb_Cursos.Controls.Add(cb_CSharp);
            gb_Cursos.Controls.Add(cb_CMasMas);
            gb_Cursos.Controls.Add(cb_JavaScript);
            gb_Cursos.Location = new Point(159, 133);
            gb_Cursos.Name = "gb_Cursos";
            gb_Cursos.Size = new Size(126, 111);
            gb_Cursos.TabIndex = 2;
            gb_Cursos.TabStop = false;
            gb_Cursos.Text = "Cursos";
            // 
            // cb_CSharp
            // 
            cb_CSharp.AutoSize = true;
            cb_CSharp.Location = new Point(17, 23);
            cb_CSharp.Name = "cb_CSharp";
            cb_CSharp.Size = new Size(41, 19);
            cb_CSharp.TabIndex = 3;
            cb_CSharp.Text = "C#";
            cb_CSharp.UseVisualStyleBackColor = true;
            // 
            // cb_CMasMas
            // 
            cb_CMasMas.AutoSize = true;
            cb_CMasMas.Location = new Point(17, 48);
            cb_CMasMas.Name = "cb_CMasMas";
            cb_CMasMas.Size = new Size(50, 19);
            cb_CMasMas.TabIndex = 4;
            cb_CMasMas.Text = "C++";
            cb_CMasMas.UseVisualStyleBackColor = true;
            // 
            // cb_JavaScript
            // 
            cb_JavaScript.AutoSize = true;
            cb_JavaScript.Location = new Point(17, 73);
            cb_JavaScript.Name = "cb_JavaScript";
            cb_JavaScript.Size = new Size(78, 19);
            cb_JavaScript.TabIndex = 5;
            cb_JavaScript.Text = "JavaScript";
            cb_JavaScript.UseVisualStyleBackColor = true;
            // 
            // Paises
            // 
            Paises.FormattingEnabled = true;
            Paises.ItemHeight = 15;
            Paises.Location = new Point(12, 194);
            Paises.Name = "Paises";
            Paises.Size = new Size(120, 94);
            Paises.TabIndex = 3;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Location = new Point(176, 265);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(75, 23);
            btn_Ingresar.TabIndex = 4;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = true;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 314);
            Controls.Add(btn_Ingresar);
            Controls.Add(Paises);
            Controls.Add(gb_Cursos);
            Controls.Add(gb_Genero);
            Controls.Add(gb_Datos);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            gb_Datos.ResumeLayout(false);
            gb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Edad).EndInit();
            gb_Genero.ResumeLayout(false);
            gb_Genero.PerformLayout();
            gb_Cursos.ResumeLayout(false);
            gb_Cursos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Datos;
        private NumericUpDown nud_Edad;
        private TextBox txt_Nombre;
        private TextBox txt_Direccion;
        private Label label3;
        private Label label2;
        private Label lbl_Nombre;
        private GroupBox gb_Genero;
        private RadioButton rb_Masculino;
        private RadioButton rb_NoBinario;
        private RadioButton rb_Femenino;
        private GroupBox gb_Cursos;
        private CheckBox cb_CSharp;
        private CheckBox cb_CMasMas;
        private CheckBox cb_JavaScript;
        private ListBox Paises;
        private Button btn_Ingresar;
    }
}
