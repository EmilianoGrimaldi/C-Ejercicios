
namespace Vista
{
    partial class FrmCartelera
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
            pnlCartel = new System.Windows.Forms.Panel();
            lblMensaje = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            dialogFuente = new System.Windows.Forms.FontDialog();
            colorDialog = new System.Windows.Forms.ColorDialog();
            lblMenu = new System.Windows.Forms.Label();
            grpContenido = new System.Windows.Forms.GroupBox();
            lblTxtMensaje = new System.Windows.Forms.Label();
            rtxtMensaje = new System.Windows.Forms.RichTextBox();
            txtTitulo = new System.Windows.Forms.TextBox();
            lblTxtTitulo = new System.Windows.Forms.Label();
            btnColorPanel = new System.Windows.Forms.Button();
            btnGuardarConfiguracion = new System.Windows.Forms.Button();
            btnImportarConfiguracion = new System.Windows.Forms.Button();
            btnColorTitulo = new System.Windows.Forms.Button();
            btnColorMensaje = new System.Windows.Forms.Button();
            btnEliminarConfiguracion = new System.Windows.Forms.Button();
            pnlCartel.SuspendLayout();
            grpContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCartel
            // 
            pnlCartel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlCartel.Controls.Add(lblMensaje);
            pnlCartel.Controls.Add(lblTitulo);
            pnlCartel.Location = new System.Drawing.Point(354, 12);
            pnlCartel.Name = "pnlCartel";
            pnlCartel.Size = new System.Drawing.Size(621, 439);
            pnlCartel.TabIndex = 3;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMensaje.Location = new System.Drawing.Point(26, 103);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new System.Drawing.Size(104, 32);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "Mensaje";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(15, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(161, 65);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMenu.Location = new System.Drawing.Point(13, 13);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new System.Drawing.Size(265, 25);
            lblMenu.TabIndex = 4;
            lblMenu.Text = "Opciones de personalización";
            // 
            // grpContenido
            // 
            grpContenido.Controls.Add(lblTxtMensaje);
            grpContenido.Controls.Add(rtxtMensaje);
            grpContenido.Controls.Add(txtTitulo);
            grpContenido.Controls.Add(lblTxtTitulo);
            grpContenido.Location = new System.Drawing.Point(13, 50);
            grpContenido.Name = "grpContenido";
            grpContenido.Size = new System.Drawing.Size(335, 210);
            grpContenido.TabIndex = 5;
            grpContenido.TabStop = false;
            grpContenido.Text = "Contenido";
            // 
            // lblTxtMensaje
            // 
            lblTxtMensaje.AutoSize = true;
            lblTxtMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTxtMensaje.Location = new System.Drawing.Point(7, 82);
            lblTxtMensaje.Name = "lblTxtMensaje";
            lblTxtMensaje.Size = new System.Drawing.Size(53, 15);
            lblTxtMensaje.TabIndex = 3;
            lblTxtMensaje.Text = "Mensaje";
            // 
            // rtxtMensaje
            // 
            rtxtMensaje.Location = new System.Drawing.Point(7, 100);
            rtxtMensaje.Name = "rtxtMensaje";
            rtxtMensaje.Size = new System.Drawing.Size(322, 96);
            rtxtMensaje.TabIndex = 2;
            rtxtMensaje.Text = "Mensaje";
            rtxtMensaje.TextChanged += rtxtMensaje_TextChanged;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new System.Drawing.Point(7, 42);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Ingrese el título";
            txtTitulo.Size = new System.Drawing.Size(322, 23);
            txtTitulo.TabIndex = 1;
            txtTitulo.Text = "Título";
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // lblTxtTitulo
            // 
            lblTxtTitulo.AutoSize = true;
            lblTxtTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTxtTitulo.Location = new System.Drawing.Point(7, 23);
            lblTxtTitulo.Name = "lblTxtTitulo";
            lblTxtTitulo.Size = new System.Drawing.Size(39, 15);
            lblTxtTitulo.TabIndex = 0;
            lblTxtTitulo.Text = "Título";
            // 
            // btnColorPanel
            // 
            btnColorPanel.Location = new System.Drawing.Point(13, 302);
            btnColorPanel.Name = "btnColorPanel";
            btnColorPanel.Size = new System.Drawing.Size(335, 30);
            btnColorPanel.TabIndex = 5;
            btnColorPanel.Text = "Elegir color de fondo del panel";
            btnColorPanel.UseVisualStyleBackColor = true;
            btnColorPanel.Click += btnColorPanel_Click;
            // 
            // btnGuardarConfiguracion
            // 
            btnGuardarConfiguracion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnGuardarConfiguracion.BackColor = System.Drawing.Color.SteelBlue;
            btnGuardarConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            btnGuardarConfiguracion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGuardarConfiguracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnGuardarConfiguracion.Location = new System.Drawing.Point(13, 373);
            btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            btnGuardarConfiguracion.Size = new System.Drawing.Size(329, 36);
            btnGuardarConfiguracion.TabIndex = 6;
            btnGuardarConfiguracion.Text = "Guardar configuración";
            btnGuardarConfiguracion.UseVisualStyleBackColor = false;
            btnGuardarConfiguracion.Click += btnGuardarConfiguracion_Click;
            // 
            // btnImportarConfiguracion
            // 
            btnImportarConfiguracion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnImportarConfiguracion.BackColor = System.Drawing.Color.DarkGray;
            btnImportarConfiguracion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnImportarConfiguracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnImportarConfiguracion.Location = new System.Drawing.Point(13, 415);
            btnImportarConfiguracion.Name = "btnImportarConfiguracion";
            btnImportarConfiguracion.Size = new System.Drawing.Size(162, 36);
            btnImportarConfiguracion.TabIndex = 7;
            btnImportarConfiguracion.Text = "Importar configuración";
            btnImportarConfiguracion.UseVisualStyleBackColor = false;
            btnImportarConfiguracion.Click += btnImportarConfiguracion_Click;
            // 
            // btnColorTitulo
            // 
            btnColorTitulo.Location = new System.Drawing.Point(13, 266);
            btnColorTitulo.Name = "btnColorTitulo";
            btnColorTitulo.Size = new System.Drawing.Size(162, 30);
            btnColorTitulo.TabIndex = 3;
            btnColorTitulo.Text = "Configurar color título";
            btnColorTitulo.UseVisualStyleBackColor = true;
            btnColorTitulo.Click += btnColorTitulo_Click;
            // 
            // btnColorMensaje
            // 
            btnColorMensaje.Location = new System.Drawing.Point(186, 266);
            btnColorMensaje.Name = "btnColorMensaje";
            btnColorMensaje.Size = new System.Drawing.Size(162, 30);
            btnColorMensaje.TabIndex = 4;
            btnColorMensaje.Text = "Configurar color mensaje";
            btnColorMensaje.UseVisualStyleBackColor = true;
            btnColorMensaje.Click += btnColorMensaje_Click;
            // 
            // btnEliminarConfiguracion
            // 
            btnEliminarConfiguracion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnEliminarConfiguracion.BackColor = System.Drawing.Color.IndianRed;
            btnEliminarConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            btnEliminarConfiguracion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEliminarConfiguracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnEliminarConfiguracion.Location = new System.Drawing.Point(180, 415);
            btnEliminarConfiguracion.Name = "btnEliminarConfiguracion";
            btnEliminarConfiguracion.Size = new System.Drawing.Size(162, 36);
            btnEliminarConfiguracion.TabIndex = 8;
            btnEliminarConfiguracion.Text = "Eliminar configuración";
            btnEliminarConfiguracion.UseVisualStyleBackColor = false;
            btnEliminarConfiguracion.Click += btnEliminarConfiguracion_Click;
            // 
            // FrmCartelera
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(987, 463);
            Controls.Add(btnEliminarConfiguracion);
            Controls.Add(btnColorMensaje);
            Controls.Add(btnColorTitulo);
            Controls.Add(btnImportarConfiguracion);
            Controls.Add(btnGuardarConfiguracion);
            Controls.Add(btnColorPanel);
            Controls.Add(grpContenido);
            Controls.Add(lblMenu);
            Controls.Add(pnlCartel);
            MinimumSize = new System.Drawing.Size(989, 502);
            Name = "FrmCartelera";
            Text = "Cartelera";
            Load += FrmCartelera_Load;
            pnlCartel.ResumeLayout(false);
            pnlCartel.PerformLayout();
            grpContenido.ResumeLayout(false);
            grpContenido.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel pnlCartel;
        private System.Windows.Forms.FontDialog dialogFuente;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.GroupBox grpContenido;
        private System.Windows.Forms.Label lblTxtMensaje;
        private System.Windows.Forms.RichTextBox rtxtMensaje;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTxtTitulo;
        private System.Windows.Forms.Button btnColorPanel;
        private System.Windows.Forms.Button btnGuardarConfiguracion;
        private System.Windows.Forms.Button btnImportarConfiguracion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnColorTitulo;
        private System.Windows.Forms.Button btnColorMensaje;
        private System.Windows.Forms.Button btnEliminarConfiguracion;
    }
}

