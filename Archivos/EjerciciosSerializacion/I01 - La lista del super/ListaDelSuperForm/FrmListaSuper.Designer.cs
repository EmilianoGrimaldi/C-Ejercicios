namespace ListaDelSuperForm
{
    partial class frmListaDelSuper
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
            components = new System.ComponentModel.Container();
            lstObjetos = new ListBox();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnModificar = new Button();
            toolTipBtnAgregar = new ToolTip(components);
            toolTipBtnQuitar = new ToolTip(components);
            toolTipBtnModificar = new ToolTip(components);
            SuspendLayout();
            // 
            // lstObjetos
            // 
            lstObjetos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstObjetos.FormattingEnabled = true;
            lstObjetos.ItemHeight = 15;
            lstObjetos.Location = new Point(12, 12);
            lstObjetos.Name = "lstObjetos";
            lstObjetos.Size = new Size(318, 424);
            lstObjetos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(336, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(40, 38);
            btnAgregar.TabIndex = 1;
            btnAgregar.Tag = "";
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuitar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuitar.Location = new Point(336, 56);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(40, 38);
            btnQuitar.TabIndex = 2;
            btnQuitar.Text = "-";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(336, 100);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(40, 38);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "M";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmListaDelSuper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(lstObjetos);
            Name = "frmListaDelSuper";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista del supermercado";
            Load += frmListaDelSuper_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstObjetos;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnModificar;
        private ToolTip toolTipBtnAgregar;
        private ToolTip toolTipBtnQuitar;
        private ToolTip toolTipBtnModificar;
    }
}