namespace InterfazPokedex
{
    partial class FrmFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltro));
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.nupDesde = new System.Windows.Forms.NumericUpDown();
            this.nupHasta = new System.Windows.Forms.NumericUpDown();
            this.txtQuery = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(26, 37);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(229, 23);
            this.cmbFiltro.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnConfirmar.Location = new System.Drawing.Point(78, 90);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(127, 38);
            this.btnConfirmar.TabIndex = 55;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // nupDesde
            // 
            this.nupDesde.Location = new System.Drawing.Point(26, 37);
            this.nupDesde.Name = "nupDesde";
            this.nupDesde.Size = new System.Drawing.Size(82, 23);
            this.nupDesde.TabIndex = 56;
            this.nupDesde.Visible = false;
            // 
            // nupHasta
            // 
            this.nupHasta.Location = new System.Drawing.Point(173, 37);
            this.nupHasta.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nupHasta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupHasta.Name = "nupHasta";
            this.nupHasta.Size = new System.Drawing.Size(82, 23);
            this.nupHasta.TabIndex = 57;
            this.nupHasta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupHasta.Visible = false;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(26, 37);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(229, 23);
            this.txtQuery.TabIndex = 58;
            this.txtQuery.Visible = false;
            // 
            // FrmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(282, 173);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.nupHasta);
            this.Controls.Add(this.nupDesde);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cmbFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFiltro";
            this.Text = "Filtro";
            ((System.ComponentModel.ISupportInitialize)(this.nupDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.NumericUpDown nupDesde;
        private System.Windows.Forms.NumericUpDown nupHasta;
        private System.Windows.Forms.TextBox txtQuery;
    }
}