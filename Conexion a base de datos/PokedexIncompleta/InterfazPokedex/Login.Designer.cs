namespace InterfazPokedex
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            rdbAsh = new System.Windows.Forms.RadioButton();
            rdbBrock = new System.Windows.Forms.RadioButton();
            rdbMisty = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(255, 183, 3);
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogin.ForeColor = System.Drawing.Color.FromArgb(0, 53, 102);
            btnLogin.Location = new System.Drawing.Point(139, 174);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(127, 38);
            btnLogin.TabIndex = 56;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(27, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(93, 74);
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox2.Location = new System.Drawing.Point(151, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(93, 74);
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox3.Location = new System.Drawing.Point(271, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(93, 74);
            pictureBox3.TabIndex = 59;
            pictureBox3.TabStop = false;
            // 
            // rdbAsh
            // 
            rdbAsh.AutoSize = true;
            rdbAsh.Checked = true;
            rdbAsh.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rdbAsh.ForeColor = System.Drawing.Color.FromArgb(255, 183, 3);
            rdbAsh.Location = new System.Drawing.Point(40, 120);
            rdbAsh.Name = "rdbAsh";
            rdbAsh.Size = new System.Drawing.Size(62, 29);
            rdbAsh.TabIndex = 60;
            rdbAsh.TabStop = true;
            rdbAsh.Text = "Ash";
            rdbAsh.UseVisualStyleBackColor = true;
            // 
            // rdbBrock
            // 
            rdbBrock.AutoSize = true;
            rdbBrock.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rdbBrock.ForeColor = System.Drawing.Color.FromArgb(255, 183, 3);
            rdbBrock.Location = new System.Drawing.Point(161, 120);
            rdbBrock.Name = "rdbBrock";
            rdbBrock.Size = new System.Drawing.Size(79, 29);
            rdbBrock.TabIndex = 61;
            rdbBrock.TabStop = true;
            rdbBrock.Text = "Brock";
            rdbBrock.UseVisualStyleBackColor = true;
            // 
            // rdbMisty
            // 
            rdbMisty.AutoSize = true;
            rdbMisty.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rdbMisty.ForeColor = System.Drawing.Color.FromArgb(255, 183, 3);
            rdbMisty.Location = new System.Drawing.Point(283, 120);
            rdbMisty.Name = "rdbMisty";
            rdbMisty.Size = new System.Drawing.Size(77, 29);
            rdbMisty.TabIndex = 62;
            rdbMisty.TabStop = true;
            rdbMisty.Text = "Misty";
            rdbMisty.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Red;
            ClientSize = new System.Drawing.Size(396, 240);
            Controls.Add(rdbMisty);
            Controls.Add(rdbBrock);
            Controls.Add(rdbAsh);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton rdbAsh;
        private System.Windows.Forms.RadioButton rdbBrock;
        private System.Windows.Forms.RadioButton rdbMisty;
    }
}