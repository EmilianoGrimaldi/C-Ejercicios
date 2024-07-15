
namespace Vista
{
    partial class FrmBacklog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBacklog));
            lstbBacklog = new System.Windows.Forms.ListBox();
            lstbParaVer = new System.Windows.Forms.ListBox();
            lblBackLog = new System.Windows.Forms.Label();
            lblParaVer = new System.Windows.Forms.Label();
            btnSerializar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lstbBacklog
            // 
            lstbBacklog.BackColor = System.Drawing.Color.LightSteelBlue;
            lstbBacklog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lstbBacklog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstbBacklog.FormattingEnabled = true;
            lstbBacklog.ItemHeight = 20;
            lstbBacklog.Location = new System.Drawing.Point(12, 74);
            lstbBacklog.Name = "lstbBacklog";
            lstbBacklog.Size = new System.Drawing.Size(332, 260);
            lstbBacklog.TabIndex = 0;
            // 
            // lstbParaVer
            // 
            lstbParaVer.BackColor = System.Drawing.Color.LightSteelBlue;
            lstbParaVer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lstbParaVer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstbParaVer.FormattingEnabled = true;
            lstbParaVer.ItemHeight = 20;
            lstbParaVer.Location = new System.Drawing.Point(492, 74);
            lstbParaVer.Name = "lstbParaVer";
            lstbParaVer.Size = new System.Drawing.Size(332, 260);
            lstbParaVer.TabIndex = 1;
            // 
            // lblBackLog
            // 
            lblBackLog.AutoSize = true;
            lblBackLog.BackColor = System.Drawing.Color.Transparent;
            lblBackLog.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBackLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblBackLog.Location = new System.Drawing.Point(12, 46);
            lblBackLog.Name = "lblBackLog";
            lblBackLog.Size = new System.Drawing.Size(78, 25);
            lblBackLog.TabIndex = 2;
            lblBackLog.Text = "Backlog";
            // 
            // lblParaVer
            // 
            lblParaVer.AutoSize = true;
            lblParaVer.BackColor = System.Drawing.Color.Transparent;
            lblParaVer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblParaVer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblParaVer.Location = new System.Drawing.Point(492, 46);
            lblParaVer.Name = "lblParaVer";
            lblParaVer.Size = new System.Drawing.Size(136, 25);
            lblParaVer.TabIndex = 3;
            lblParaVer.Text = "Series para ver";
            // 
            // btnSerializar
            // 
            btnSerializar.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnSerializar.BackgroundImage");
            btnSerializar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerializar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSerializar.ForeColor = System.Drawing.Color.DarkOrchid;
            btnSerializar.Location = new System.Drawing.Point(731, 369);
            btnSerializar.Name = "btnSerializar";
            btnSerializar.Size = new System.Drawing.Size(93, 39);
            btnSerializar.TabIndex = 4;
            btnSerializar.Text = "Serializar";
            btnSerializar.UseVisualStyleBackColor = true;
            btnSerializar.Click += btnSerializar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.ForeColor = System.Drawing.Color.DarkOrchid;
            btnSalir.Location = new System.Drawing.Point(809, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(37, 39);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmBacklog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(849, 438);
            Controls.Add(btnSalir);
            Controls.Add(btnSerializar);
            Controls.Add(lblParaVer);
            Controls.Add(lblBackLog);
            Controls.Add(lstbParaVer);
            Controls.Add(lstbBacklog);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmBacklog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmBacklog";
            Load += FrmBacklog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstbBacklog;
        private System.Windows.Forms.ListBox lstbParaVer;
        private System.Windows.Forms.Label lblBackLog;
        private System.Windows.Forms.Label lblParaVer;
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Button btnSalir;
    }
}

