﻿namespace SCI1
{
    partial class EnviarRequisicon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gbxEnvio = new System.Windows.Forms.GroupBox();
            this.txtEnviarCorreo = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adjuntoArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adjuntoQuitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbxEnvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinatario)).BeginInit();
            this.gbxDetallesEnvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
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
            this.gbxEnvio.Controls.Add(this.txtEnviarCorreo);
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
            // txtEnviarCorreo
            // 
            this.txtEnviarCorreo.Image = global::SCI1.Properties.Resources.Fasticon_Isimple_System_Email_send;
            this.txtEnviarCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEnviarCorreo.Location = new System.Drawing.Point(10, 167);
            this.txtEnviarCorreo.Name = "txtEnviarCorreo";
            this.txtEnviarCorreo.Size = new System.Drawing.Size(316, 45);
            this.txtEnviarCorreo.TabIndex = 8;
            this.txtEnviarCorreo.Text = "Enviar correo";
            this.txtEnviarCorreo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Puerto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "SMTP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(98, 113);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(64, 23);
            this.txtPuerto.TabIndex = 4;
            // 
            // txtSMPT
            // 
            this.txtSMPT.Location = new System.Drawing.Point(98, 81);
            this.txtSMPT.Name = "txtSMPT";
            this.txtSMPT.Size = new System.Drawing.Size(228, 23);
            this.txtSMPT.TabIndex = 3;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(98, 52);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(228, 23);
            this.txtContraseña.TabIndex = 2;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDestinatario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.gbxDetallesEnvio.Controls.Add(this.button1);
            this.gbxDetallesEnvio.Controls.Add(this.dataGridView1);
            this.gbxDetallesEnvio.Controls.Add(this.label8);
            this.gbxDetallesEnvio.Controls.Add(this.textBox4);
            this.gbxDetallesEnvio.Controls.Add(this.textBox5);
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
            // button1
            // 
            this.button1.Image = global::SCI1.Properties.Resources.icons8_agregar_enlace_40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(85, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(516, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Adjuntar archivo(s)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adjuntoArchivo,
            this.adjuntoQuitar});
            this.dataGridView1.Location = new System.Drawing.Point(85, 474);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(516, 143);
            this.dataGridView1.TabIndex = 6;
            // 
            // adjuntoArchivo
            // 
            this.adjuntoArchivo.HeaderText = "Archivos";
            this.adjuntoArchivo.Name = "adjuntoArchivo";
            this.adjuntoArchivo.ReadOnly = true;
            // 
            // adjuntoQuitar
            // 
            this.adjuntoQuitar.HeaderText = "Quitar";
            this.adjuntoQuitar.Name = "adjuntoQuitar";
            this.adjuntoQuitar.ReadOnly = true;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(98, 52);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(503, 260);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(98, 23);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(503, 23);
            this.textBox5.TabIndex = 1;
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
            // EnviarRequisicon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.gbxDetallesEnvio);
            this.Controls.Add(this.dgvDestinatario);
            this.Controls.Add(this.gbxEnvio);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnviarRequisicon";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnRecargar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox gbxEnvio;
        private System.Windows.Forms.Button txtEnviarCorreo;
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adjuntoArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn adjuntoQuitar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}