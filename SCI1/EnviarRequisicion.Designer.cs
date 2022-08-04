namespace SCI1
{
    partial class EnviarRequisicion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gbxEnvio = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtSMPT = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDestinatario = new System.Windows.Forms.DataGridView();
            this.correoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDetallesEnvio = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pBarEnviar = new System.Windows.Forms.ProgressBar();
            this.tProgreso = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.adjuntoArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbxEnvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinatario)).BeginInit();
            this.gbxDetallesEnvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Controls.Add(this.btnRecargar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1014, 25);
            this.panelTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enviar requisición ";
            // 
            // btnRecargar
            // 
            this.btnRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.Image = global::SCI1.Properties.Resources.Zhoolego_Material_Control_Panel;
            this.btnRecargar.Location = new System.Drawing.Point(989, 0);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(25, 25);
            this.btnRecargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecargar.TabIndex = 1;
            this.btnRecargar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::SCI1.Properties.Resources.pngegg;
            this.btnCerrar.Location = new System.Drawing.Point(0, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbxEnvio
            // 
            this.gbxEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxEnvio.Controls.Add(this.label6);
            this.gbxEnvio.Controls.Add(this.txtAlias);
            this.gbxEnvio.Controls.Add(this.btnEnviarCorreo);
            this.gbxEnvio.Controls.Add(this.label5);
            this.gbxEnvio.Controls.Add(this.label4);
            this.gbxEnvio.Controls.Add(this.label3);
            this.gbxEnvio.Controls.Add(this.txtPuerto);
            this.gbxEnvio.Controls.Add(this.txtSMPT);
            this.gbxEnvio.Controls.Add(this.txtContraseña);
            this.gbxEnvio.Controls.Add(this.txtCorreo);
            this.gbxEnvio.Controls.Add(this.label2);
            this.gbxEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEnvio.Location = new System.Drawing.Point(655, 436);
            this.gbxEnvio.Name = "gbxEnvio";
            this.gbxEnvio.Size = new System.Drawing.Size(347, 233);
            this.gbxEnvio.TabIndex = 2;
            this.gbxEnvio.TabStop = false;
            this.gbxEnvio.Text = "Datos de envío";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alias: ";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(98, 52);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(228, 23);
            this.txtAlias.TabIndex = 2;
            this.txtAlias.Text = "Coordinación Unidad Académica Lerdo de Tejada";
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.Image = global::SCI1.Properties.Resources.Fasticon_Isimple_System_Email_send;
            this.btnEnviarCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(10, 171);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(316, 45);
            this.btnEnviarCorreo.TabIndex = 8;
            this.btnEnviarCorreo.Text = "Enviar correo";
            this.btnEnviarCorreo.UseVisualStyleBackColor = true;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Puerto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "SMTP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(98, 142);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(64, 23);
            this.txtPuerto.TabIndex = 5;
            this.txtPuerto.Text = "25";
            // 
            // txtSMPT
            // 
            this.txtSMPT.Location = new System.Drawing.Point(98, 110);
            this.txtSMPT.Name = "txtSMPT";
            this.txtSMPT.Size = new System.Drawing.Size(228, 23);
            this.txtSMPT.TabIndex = 4;
            this.txtSMPT.Text = "smtp.gmail.com";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(98, 81);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(228, 23);
            this.txtContraseña.TabIndex = 3;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(98, 23);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(228, 23);
            this.txtCorreo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Correo:";
            // 
            // dgvDestinatario
            // 
            this.dgvDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDestinatario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDestinatario.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDestinatario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDestinatario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinatario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.correoDestino});
            this.dgvDestinatario.Location = new System.Drawing.Point(655, 31);
            this.dgvDestinatario.Name = "dgvDestinatario";
            this.dgvDestinatario.Size = new System.Drawing.Size(347, 292);
            this.dgvDestinatario.TabIndex = 3;
            // 
            // correoDestino
            // 
            this.correoDestino.HeaderText = "Destinatario(s)";
            this.correoDestino.Name = "correoDestino";
            // 
            // gbxDetallesEnvio
            // 
            this.gbxDetallesEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxDetallesEnvio.Controls.Add(this.btnLimpiar);
            this.gbxDetallesEnvio.Controls.Add(this.btnAdjuntar);
            this.gbxDetallesEnvio.Controls.Add(this.dgvArchivos);
            this.gbxDetallesEnvio.Controls.Add(this.label8);
            this.gbxDetallesEnvio.Controls.Add(this.txtCuerpo);
            this.gbxDetallesEnvio.Controls.Add(this.txtAsunto);
            this.gbxDetallesEnvio.Controls.Add(this.label9);
            this.gbxDetallesEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxDetallesEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetallesEnvio.Location = new System.Drawing.Point(12, 31);
            this.gbxDetallesEnvio.Name = "gbxDetallesEnvio";
            this.gbxDetallesEnvio.Size = new System.Drawing.Size(615, 638);
            this.gbxDetallesEnvio.TabIndex = 9;
            this.gbxDetallesEnvio.TabStop = false;
            this.gbxDetallesEnvio.Text = "Detalles de envío";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::SCI1.Properties.Resources.limpieza_de_datos;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(361, 406);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(240, 45);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Image = global::SCI1.Properties.Resources.icons8_adjuntar_50;
            this.btnAdjuntar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdjuntar.Location = new System.Drawing.Point(85, 405);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(240, 45);
            this.btnAdjuntar.TabIndex = 9;
            this.btnAdjuntar.Text = "Adjuntar archivo(s)";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // dgvArchivos
            // 
            this.dgvArchivos.AllowUserToAddRows = false;
            this.dgvArchivos.AllowUserToDeleteRows = false;
            this.dgvArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArchivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArchivos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adjuntoArchivo});
            this.dgvArchivos.Location = new System.Drawing.Point(85, 474);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.ReadOnly = true;
            this.dgvArchivos.Size = new System.Drawing.Size(516, 143);
            this.dgvArchivos.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cuerpo:";
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Location = new System.Drawing.Point(98, 58);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(503, 260);
            this.txtCuerpo.TabIndex = 2;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(98, 23);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(503, 23);
            this.txtAsunto.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Asunto:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pBarEnviar
            // 
            this.pBarEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pBarEnviar.Location = new System.Drawing.Point(655, 394);
            this.pBarEnviar.Name = "pBarEnviar";
            this.pBarEnviar.Size = new System.Drawing.Size(347, 36);
            this.pBarEnviar.Step = 1;
            this.pBarEnviar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBarEnviar.TabIndex = 10;
            // 
            // tProgreso
            // 
            this.tProgreso.Tick += new System.EventHandler(this.tProgreso_Tick);
            // 
            // adjuntoArchivo
            // 
            this.adjuntoArchivo.HeaderText = "Archivos";
            this.adjuntoArchivo.Name = "adjuntoArchivo";
            this.adjuntoArchivo.ReadOnly = true;
            // 
            // EnviarRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.pBarEnviar);
            this.Controls.Add(this.gbxDetallesEnvio);
            this.Controls.Add(this.dgvDestinatario);
            this.Controls.Add(this.gbxEnvio);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnviarRequisicion";
            this.Text = " ";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbxEnvio.ResumeLayout(false);
            this.gbxEnvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinatario)).EndInit();
            this.gbxDetallesEnvio.ResumeLayout(false);
            this.gbxDetallesEnvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnRecargar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox gbxEnvio;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtSMPT;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDestino;
        private System.Windows.Forms.GroupBox gbxDetallesEnvio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvArchivos;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ProgressBar pBarEnviar;
        private System.Windows.Forms.Timer tProgreso;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adjuntoArchivo;
    }
}