
namespace Presentacion
{
    partial class FrmIdentificacionComputadora
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
            picboxSistemaOperativo = new System.Windows.Forms.PictureBox();
            lblNombreMaquina = new System.Windows.Forms.Label();
            lblSistemaOperativo = new System.Windows.Forms.Label();
            lblArquitectura = new System.Windows.Forms.Label();
            lblCantProcesadores = new System.Windows.Forms.Label();
            lblDirectorioActual = new System.Windows.Forms.Label();
            lblEspacioTotal = new System.Windows.Forms.Label();
            lblEspacioDisponible = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)picboxSistemaOperativo).BeginInit();
            SuspendLayout();
            // 
            // picboxSistemaOperativo
            // 
            picboxSistemaOperativo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picboxSistemaOperativo.Location = new System.Drawing.Point(746, 37);
            picboxSistemaOperativo.Name = "picboxSistemaOperativo";
            picboxSistemaOperativo.Size = new System.Drawing.Size(225, 225);
            picboxSistemaOperativo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picboxSistemaOperativo.TabIndex = 0;
            picboxSistemaOperativo.TabStop = false;
            // 
            // lblNombreMaquina
            // 
            lblNombreMaquina.AutoSize = true;
            lblNombreMaquina.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombreMaquina.Location = new System.Drawing.Point(12, 52);
            lblNombreMaquina.Name = "lblNombreMaquina";
            lblNombreMaquina.Size = new System.Drawing.Size(227, 16);
            lblNombreMaquina.TabIndex = 1;
            lblNombreMaquina.Text = "Nombre de la máquina: ";
            // 
            // lblSistemaOperativo
            // 
            lblSistemaOperativo.AutoSize = true;
            lblSistemaOperativo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSistemaOperativo.Location = new System.Drawing.Point(12, 12);
            lblSistemaOperativo.Name = "lblSistemaOperativo";
            lblSistemaOperativo.Size = new System.Drawing.Size(187, 16);
            lblSistemaOperativo.TabIndex = 2;
            lblSistemaOperativo.Text = "Sistema Operativo:";
            // 
            // lblArquitectura
            // 
            lblArquitectura.AutoSize = true;
            lblArquitectura.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblArquitectura.Location = new System.Drawing.Point(13, 92);
            lblArquitectura.Name = "lblArquitectura";
            lblArquitectura.Size = new System.Drawing.Size(137, 16);
            lblArquitectura.TabIndex = 3;
            lblArquitectura.Text = "Arquitectura:";
            // 
            // lblCantProcesadores
            // 
            lblCantProcesadores.AutoSize = true;
            lblCantProcesadores.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCantProcesadores.Location = new System.Drawing.Point(13, 132);
            lblCantProcesadores.Name = "lblCantProcesadores";
            lblCantProcesadores.Size = new System.Drawing.Size(197, 16);
            lblCantProcesadores.TabIndex = 4;
            lblCantProcesadores.Text = "Cant. procesadores:";
            // 
            // lblDirectorioActual
            // 
            lblDirectorioActual.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblDirectorioActual.AutoSize = true;
            lblDirectorioActual.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblDirectorioActual.Location = new System.Drawing.Point(13, 287);
            lblDirectorioActual.Name = "lblDirectorioActual";
            lblDirectorioActual.Size = new System.Drawing.Size(231, 13);
            lblDirectorioActual.TabIndex = 5;
            lblDirectorioActual.Text = "Identificación ejecutada en:";
            lblDirectorioActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEspacioTotal
            // 
            lblEspacioTotal.AutoSize = true;
            lblEspacioTotal.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEspacioTotal.Location = new System.Drawing.Point(13, 172);
            lblEspacioTotal.Name = "lblEspacioTotal";
            lblEspacioTotal.Size = new System.Drawing.Size(147, 16);
            lblEspacioTotal.TabIndex = 6;
            lblEspacioTotal.Text = "Espacio total:";
            // 
            // lblEspacioDisponible
            // 
            lblEspacioDisponible.AutoSize = true;
            lblEspacioDisponible.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEspacioDisponible.Location = new System.Drawing.Point(13, 212);
            lblEspacioDisponible.Name = "lblEspacioDisponible";
            lblEspacioDisponible.Size = new System.Drawing.Size(197, 16);
            lblEspacioDisponible.TabIndex = 7;
            lblEspacioDisponible.Text = "Espacio disponible:";
            // 
            // FrmIdentificacionComputadora
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.GhostWhite;
            ClientSize = new System.Drawing.Size(983, 337);
            Controls.Add(lblEspacioDisponible);
            Controls.Add(lblEspacioTotal);
            Controls.Add(lblDirectorioActual);
            Controls.Add(lblCantProcesadores);
            Controls.Add(lblArquitectura);
            Controls.Add(lblSistemaOperativo);
            Controls.Add(lblNombreMaquina);
            Controls.Add(picboxSistemaOperativo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmIdentificacionComputadora";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Compu de [USUARIO]";
            Load += FrmIdentificacionComputadora_Load;
            ((System.ComponentModel.ISupportInitialize)picboxSistemaOperativo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picboxSistemaOperativo;
        private System.Windows.Forms.Label lblNombreMaquina;
        private System.Windows.Forms.Label lblSistemaOperativo;
        private System.Windows.Forms.Label lblArquitectura;
        private System.Windows.Forms.Label lblCantProcesadores;
        private System.Windows.Forms.Label lblDirectorioActual;
        private System.Windows.Forms.Label lblEspacioTotal;
        private System.Windows.Forms.Label lblEspacioDisponible;
    }
}