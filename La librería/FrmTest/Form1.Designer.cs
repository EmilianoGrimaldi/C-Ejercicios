using Entidades;

namespace FrmTest
{
    partial class FrmTest
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
            btnVender = new Button();
            btnVerInforme = new Button();
            btnSalir = new Button();
            rtbInforme = new RichTextBox();
            lstStock = new ListBox();
            SuspendLayout();
            // 
            // btnVender
            // 
            btnVender.Location = new Point(12, 302);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(276, 39);
            btnVender.TabIndex = 1;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnVerInforme
            // 
            btnVerInforme.Location = new Point(12, 347);
            btnVerInforme.Name = "btnVerInforme";
            btnVerInforme.Size = new Size(276, 39);
            btnVerInforme.TabIndex = 2;
            btnVerInforme.Text = "Ver Informe";
            btnVerInforme.UseVisualStyleBackColor = true;
            btnVerInforme.Click += btnVerInforme_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 392);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(276, 39);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // rtbInforme
            // 
            rtbInforme.Location = new Point(294, 12);
            rtbInforme.Name = "rtbInforme";
            rtbInforme.Size = new Size(276, 419);
            rtbInforme.TabIndex = 4;
            rtbInforme.Text = "";
            // 
            // lstStock
            // 
            lstStock.FormattingEnabled = true;
            lstStock.ItemHeight = 15;
            lstStock.Location = new Point(12, 12);
            lstStock.Name = "lstStock";
            lstStock.Size = new Size(267, 274);
            lstStock.TabIndex = 5;
            // 
            // FrmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 450);
            Controls.Add(lstStock);
            Controls.Add(rtbInforme);
            Controls.Add(btnSalir);
            Controls.Add(btnVerInforme);
            Controls.Add(btnVender);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tester App";
            FormClosing += FrmTest_FormClosing;
            Load += TesterApp_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnVender;
        private Button btnVerInforme;
        private Button btnSalir;
        private RichTextBox rtbInforme;
        private ListBox lstStock;
    }
}
