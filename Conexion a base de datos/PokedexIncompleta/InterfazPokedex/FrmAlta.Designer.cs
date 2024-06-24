namespace InterfazPokedex
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nupId = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.lblEntrnador = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDireccionImagen = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtEntrenador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Silver;
            this.txtNombre.Location = new System.Drawing.Point(52, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // nupId
            // 
            this.nupId.BackColor = System.Drawing.Color.Silver;
            this.nupId.Location = new System.Drawing.Point(215, 30);
            this.nupId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupId.Name = "nupId";
            this.nupId.Size = new System.Drawing.Size(58, 23);
            this.nupId.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.Yellow;
            this.lblId.Location = new System.Drawing.Point(52, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 28);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.Yellow;
            this.lblNombre.Location = new System.Drawing.Point(52, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 28);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.Color.Yellow;
            this.lblTipo.Location = new System.Drawing.Point(52, 154);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(54, 28);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbTipos
            // 
            this.cmbTipos.BackColor = System.Drawing.Color.Silver;
            this.cmbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(52, 202);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(221, 23);
            this.cmbTipos.TabIndex = 9;
            // 
            // lblEntrnador
            // 
            this.lblEntrnador.AutoSize = true;
            this.lblEntrnador.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEntrnador.ForeColor = System.Drawing.Color.Yellow;
            this.lblEntrnador.Location = new System.Drawing.Point(52, 243);
            this.lblEntrnador.Name = "lblEntrnador";
            this.lblEntrnador.Size = new System.Drawing.Size(117, 28);
            this.lblEntrnador.TabIndex = 10;
            this.lblEntrnador.Text = "Entrenador";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImagen.ForeColor = System.Drawing.Color.Yellow;
            this.lblImagen.Location = new System.Drawing.Point(52, 327);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(82, 28);
            this.lblImagen.TabIndex = 13;
            this.lblImagen.Text = "Imagen";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnBuscar.Location = new System.Drawing.Point(156, 327);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 31);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDireccionImagen
            // 
            this.txtDireccionImagen.BackColor = System.Drawing.Color.Silver;
            this.txtDireccionImagen.Location = new System.Drawing.Point(52, 375);
            this.txtDireccionImagen.Name = "txtDireccionImagen";
            this.txtDireccionImagen.ReadOnly = true;
            this.txtDireccionImagen.Size = new System.Drawing.Size(221, 23);
            this.txtDireccionImagen.TabIndex = 53;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(201)))), ((int)(((byte)(38)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnConfirmar.Location = new System.Drawing.Point(52, 425);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(221, 48);
            this.btnConfirmar.TabIndex = 54;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtEntrenador
            // 
            this.txtEntrenador.BackColor = System.Drawing.Color.Silver;
            this.txtEntrenador.Location = new System.Drawing.Point(52, 283);
            this.txtEntrenador.Name = "txtEntrenador";
            this.txtEntrenador.ReadOnly = true;
            this.txtEntrenador.Size = new System.Drawing.Size(221, 23);
            this.txtEntrenador.TabIndex = 55;
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(324, 485);
            this.Controls.Add(this.txtEntrenador);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtDireccionImagen);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblEntrnador);
            this.Controls.Add(this.cmbTipos);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.nupId);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlta";
            this.Text = "FrmAlta";
            this.Load += new System.EventHandler(this.FrmAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nupId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.Label lblEntrnador;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDireccionImagen;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtEntrenador;
    }
}