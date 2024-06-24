
namespace Vista
{
    partial class FrmAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlta));
            btnGuardar = new System.Windows.Forms.Button();
            txtNombre = new System.Windows.Forms.TextBox();
            txtGenero = new System.Windows.Forms.TextBox();
            nupPrecio = new System.Windows.Forms.NumericUpDown();
            cmbUsuarios = new System.Windows.Forms.ComboBox();
            lblNombre = new System.Windows.Forms.Label();
            lblGenero = new System.Windows.Forms.Label();
            lblPrecio = new System.Windows.Forms.Label();
            lblUsuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nupPrecio).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Location = new System.Drawing.Point(20, 281);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(121, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNombre.Location = new System.Drawing.Point(21, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(120, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtGenero
            // 
            txtGenero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtGenero.Location = new System.Drawing.Point(21, 112);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new System.Drawing.Size(120, 23);
            txtGenero.TabIndex = 2;
            // 
            // nupPrecio
            // 
            nupPrecio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            nupPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nupPrecio.Location = new System.Drawing.Point(21, 172);
            nupPrecio.Name = "nupPrecio";
            nupPrecio.Size = new System.Drawing.Size(120, 23);
            nupPrecio.TabIndex = 3;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.BackColor = System.Drawing.SystemColors.InactiveCaption;
            cmbUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new System.Drawing.Point(20, 234);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new System.Drawing.Size(121, 23);
            cmbUsuarios.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = System.Drawing.Color.Transparent;
            lblNombre.Location = new System.Drawing.Point(21, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(38, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Juego";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.BackColor = System.Drawing.Color.Transparent;
            lblGenero.Location = new System.Drawing.Point(21, 94);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new System.Drawing.Size(45, 15);
            lblGenero.TabIndex = 6;
            lblGenero.Text = "Genero";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = System.Drawing.Color.Transparent;
            lblPrecio.Location = new System.Drawing.Point(21, 154);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(40, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.BackColor = System.Drawing.Color.Transparent;
            lblUsuarios.Location = new System.Drawing.Point(21, 216);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new System.Drawing.Size(52, 15);
            lblUsuarios.TabIndex = 8;
            lblUsuarios.Text = "Usuarios";
            // 
            // FrmAlta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(165, 321);
            Controls.Add(lblUsuarios);
            Controls.Add(lblPrecio);
            Controls.Add(lblGenero);
            Controls.Add(lblNombre);
            Controls.Add(cmbUsuarios);
            Controls.Add(nupPrecio);
            Controls.Add(txtGenero);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmAlta";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmAlta";
            Load += FrmAlta_Load;
            ((System.ComponentModel.ISupportInitialize)nupPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.TextBox txtNombre;
        protected System.Windows.Forms.TextBox txtGenero;
        protected System.Windows.Forms.NumericUpDown nupPrecio;
        protected System.Windows.Forms.ComboBox cmbUsuarios;
        protected System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.Label lblGenero;
        protected System.Windows.Forms.Label lblPrecio;
        protected System.Windows.Forms.Label lblUsuarios;
    }
}