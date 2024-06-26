namespace FormTest
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
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            lbl_Hora = new Label();
            reloj = new System.Windows.Forms.Timer(components);
            btn_Iniciar = new Button();
            btn_Detener = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 48);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(746, 309);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // lbl_Hora
            // 
            lbl_Hora.AutoSize = true;
            lbl_Hora.Location = new Point(12, 18);
            lbl_Hora.Name = "lbl_Hora";
            lbl_Hora.Size = new Size(63, 15);
            lbl_Hora.TabIndex = 1;
            lbl_Hora.Text = "label_Hora";
            // 
            // btn_Iniciar
            // 
            btn_Iniciar.Location = new Point(482, 10);
            btn_Iniciar.Name = "btn_Iniciar";
            btn_Iniciar.Size = new Size(130, 23);
            btn_Iniciar.TabIndex = 2;
            btn_Iniciar.Text = "Iniciar reloj";
            btn_Iniciar.UseVisualStyleBackColor = true;
            btn_Iniciar.Click += btn_Iniciar_Click;
            // 
            // btn_Detener
            // 
            btn_Detener.Location = new Point(628, 10);
            btn_Detener.Name = "btn_Detener";
            btn_Detener.Size = new Size(130, 23);
            btn_Detener.TabIndex = 3;
            btn_Detener.Text = "Detener reloj";
            btn_Detener.UseVisualStyleBackColor = true;
            btn_Detener.Click += btn_Detener_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 369);
            Controls.Add(btn_Detener);
            Controls.Add(btn_Iniciar);
            Controls.Add(lbl_Hora);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label lbl_Hora;
        private System.Windows.Forms.Timer reloj;
        private Button btn_Iniciar;
        private Button btn_Detener;
    }
}
