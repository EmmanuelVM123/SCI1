namespace SCI1
{
    partial class RecuperarContraseña
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRecuperarContraseña = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelAriiba = new System.Windows.Forms.Panel();
            this.btnMinizar = new System.Windows.Forms.PictureBox();
            this.bntCerrar = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelAriiba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 261);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCI1.Properties.Resources.Logo_ITSAV11;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(93)))), ((int)(((byte)(97)))));
            this.panel3.Controls.Add(this.txtCorreo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnRecuperarContraseña);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(254, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 261);
            this.panel3.TabIndex = 10;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(93)))), ((int)(((byte)(97)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Silver;
            this.txtCorreo.Location = new System.Drawing.Point(64, 119);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(388, 19);
            this.txtCorreo.TabIndex = 1;
            this.txtCorreo.Text = "Correo eléctronico";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(61, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Recuperar contraseña mediante correo el-mail";
            // 
            // btnRecuperarContraseña
            // 
            this.btnRecuperarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnRecuperarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuperarContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnRecuperarContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRecuperarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarContraseña.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecuperarContraseña.Image = global::SCI1.Properties.Resources.icons8_abrir_en_popup_32;
            this.btnRecuperarContraseña.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecuperarContraseña.Location = new System.Drawing.Point(185, 187);
            this.btnRecuperarContraseña.Name = "btnRecuperarContraseña";
            this.btnRecuperarContraseña.Size = new System.Drawing.Size(157, 40);
            this.btnRecuperarContraseña.TabIndex = 0;
            this.btnRecuperarContraseña.Text = "Recuperar";
            this.btnRecuperarContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecuperarContraseña.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecuperarContraseña.UseVisualStyleBackColor = false;
            this.btnRecuperarContraseña.Click += new System.EventHandler(this.btnRecuperarContraseña_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::SCI1.Properties.Resources.envelope;
            this.pictureBox2.Location = new System.Drawing.Point(233, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panelAriiba
            // 
            this.panelAriiba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(138)))), ((int)(((byte)(37)))));
            this.panelAriiba.Controls.Add(this.btnMinizar);
            this.panelAriiba.Controls.Add(this.bntCerrar);
            this.panelAriiba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAriiba.Location = new System.Drawing.Point(0, 0);
            this.panelAriiba.Name = "panelAriiba";
            this.panelAriiba.Size = new System.Drawing.Size(767, 30);
            this.panelAriiba.TabIndex = 9;
            this.panelAriiba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAriiba_MouseDown);
            // 
            // btnMinizar
            // 
            this.btnMinizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinizar.Image = global::SCI1.Properties.Resources.menos2;
            this.btnMinizar.Location = new System.Drawing.Point(701, 2);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinizar.TabIndex = 6;
            this.btnMinizar.TabStop = false;
            this.btnMinizar.Click += new System.EventHandler(this.btnMinizar_Click);
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCerrar.Image = global::SCI1.Properties.Resources.pngwing_com__19_;
            this.bntCerrar.Location = new System.Drawing.Point(738, 2);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(25, 25);
            this.bntCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntCerrar.TabIndex = 5;
            this.bntCerrar.TabStop = false;
            this.bntCerrar.Click += new System.EventHandler(this.bntCerrar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelAriiba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarContraseña";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelAriiba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelAriiba;
        private System.Windows.Forms.PictureBox btnMinizar;
        private System.Windows.Forms.PictureBox bntCerrar;
        private System.Windows.Forms.Button btnRecuperarContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}