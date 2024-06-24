namespace InterfazPokedex
{
    partial class FrmSerializacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerializacion));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.rdbJSON = new System.Windows.Forms.RadioButton();
            this.rdbXML = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnConfirmar.Location = new System.Drawing.Point(79, 153);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(127, 38);
            this.btnConfirmar.TabIndex = 56;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(60, 50);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.PlaceholderText = "Nombre del archivo...";
            this.txtNombreArchivo.Size = new System.Drawing.Size(182, 23);
            this.txtNombreArchivo.TabIndex = 57;
            // 
            // rdbJSON
            // 
            this.rdbJSON.AutoSize = true;
            this.rdbJSON.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbJSON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.rdbJSON.Location = new System.Drawing.Point(62, 100);
            this.rdbJSON.Name = "rdbJSON";
            this.rdbJSON.Size = new System.Drawing.Size(55, 19);
            this.rdbJSON.TabIndex = 58;
            this.rdbJSON.TabStop = true;
            this.rdbJSON.Text = "JSON";
            this.rdbJSON.UseVisualStyleBackColor = true;
            // 
            // rdbXML
            // 
            this.rdbXML.AutoSize = true;
            this.rdbXML.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbXML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.rdbXML.Location = new System.Drawing.Point(170, 100);
            this.rdbXML.Name = "rdbXML";
            this.rdbXML.Size = new System.Drawing.Size(50, 19);
            this.rdbXML.TabIndex = 59;
            this.rdbXML.TabStop = true;
            this.rdbXML.Text = "XML";
            this.rdbXML.UseVisualStyleBackColor = true;
            // 
            // FrmSerializacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(285, 254);
            this.Controls.Add(this.rdbXML);
            this.Controls.Add(this.rdbJSON);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSerializacion";
            this.Text = "FrmSerializacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.RadioButton rdbJSON;
        private System.Windows.Forms.RadioButton rdbXML;
    }
}