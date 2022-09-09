namespace SCI1
{
    partial class SistemaControlInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaControlInventario));
            this.panelInicial = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelBajas = new System.Windows.Forms.Panel();
            this.btnDisminuirExistencia = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnBajas = new System.Windows.Forms.Button();
            this.panelAltas = new System.Windows.Forms.Panel();
            this.btnAñadirExistencia = new System.Windows.Forms.Button();
            this.btnAñadirArticulo = new System.Windows.Forms.Button();
            this.btnAltas = new System.Windows.Forms.Button();
            this.panelAreas = new System.Windows.Forms.Panel();
            this.btnAMT = new System.Windows.Forms.Button();
            this.btnLBC = new System.Windows.Forms.Button();
            this.btnSGR = new System.Windows.Forms.Button();
            this.btnMNT = new System.Windows.Forms.Button();
            this.btnITN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCIS = new System.Windows.Forms.Button();
            this.btnIAreas = new System.Windows.Forms.Button();
            this.panelUsuarioResumen = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnRequisicion = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.bntAchicar = new System.Windows.Forms.PictureBox();
            this.btnMinizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgrandar = new System.Windows.Forms.PictureBox();
            this.bntCerrar = new System.Windows.Forms.PictureBox();
            this.panelInicial.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.panelBajas.SuspendLayout();
            this.panelAltas.SuspendLayout();
            this.panelAreas.SuspendLayout();
            this.panelUsuarioResumen.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntAchicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgrandar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInicial
            // 
            this.panelInicial.Controls.Add(this.panelContenedor);
            this.panelInicial.Controls.Add(this.panelLateral);
            this.panelInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicial.Location = new System.Drawing.Point(0, 30);
            this.panelInicial.Name = "panelInicial";
            this.panelInicial.Size = new System.Drawing.Size(1370, 719);
            this.panelInicial.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(260, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1110, 719);
            this.panelContenedor.TabIndex = 1;
            // 
            // panelLateral
            // 
            this.panelLateral.AutoScroll = true;
            this.panelLateral.Controls.Add(this.btnCerrarSesion);
            this.panelLateral.Controls.Add(this.panelBajas);
            this.panelLateral.Controls.Add(this.btnBajas);
            this.panelLateral.Controls.Add(this.panelAltas);
            this.panelLateral.Controls.Add(this.btnAltas);
            this.panelLateral.Controls.Add(this.panelAreas);
            this.panelLateral.Controls.Add(this.btnIAreas);
            this.panelLateral.Controls.Add(this.panelUsuarioResumen);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(260, 719);
            this.panelLateral.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Image = global::SCI1.Properties.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_64;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 910);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(243, 71);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelBajas
            // 
            this.panelBajas.Controls.Add(this.btnDisminuirExistencia);
            this.panelBajas.Controls.Add(this.btnEliminarArticulo);
            this.panelBajas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBajas.Location = new System.Drawing.Point(0, 810);
            this.panelBajas.Name = "panelBajas";
            this.panelBajas.Size = new System.Drawing.Size(243, 100);
            this.panelBajas.TabIndex = 6;
            this.panelBajas.Visible = false;
            // 
            // btnDisminuirExistencia
            // 
            this.btnDisminuirExistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisminuirExistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisminuirExistencia.FlatAppearance.BorderSize = 0;
            this.btnDisminuirExistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDisminuirExistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDisminuirExistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisminuirExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuirExistencia.Image = global::SCI1.Properties.Resources.Custom_Icon_Design_Flatastic_4_Package_download;
            this.btnDisminuirExistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisminuirExistencia.Location = new System.Drawing.Point(0, 50);
            this.btnDisminuirExistencia.Name = "btnDisminuirExistencia";
            this.btnDisminuirExistencia.Size = new System.Drawing.Size(243, 50);
            this.btnDisminuirExistencia.TabIndex = 11;
            this.btnDisminuirExistencia.Tag = "Disminuir existencia";
            this.btnDisminuirExistencia.Text = "Disminuir existencia";
            this.btnDisminuirExistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisminuirExistencia.UseVisualStyleBackColor = true;
            this.btnDisminuirExistencia.Click += new System.EventHandler(this.btnDisminuirExistencia_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarArticulo.FlatAppearance.BorderSize = 0;
            this.btnEliminarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Image = global::SCI1.Properties.Resources.Custom_Icon_Design_Flatastic_4_Package_delete;
            this.btnEliminarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(0, 0);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(243, 50);
            this.btnEliminarArticulo.TabIndex = 10;
            this.btnEliminarArticulo.Tag = "Eliminar artículo";
            this.btnEliminarArticulo.Text = "Eliminar artículo";
            this.btnEliminarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnBajas
            // 
            this.btnBajas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBajas.FlatAppearance.BorderSize = 0;
            this.btnBajas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBajas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajas.Image = global::SCI1.Properties.Resources.data_download_icon__1_;
            this.btnBajas.Location = new System.Drawing.Point(0, 760);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(243, 50);
            this.btnBajas.TabIndex = 5;
            this.btnBajas.Tag = "Bajas";
            this.btnBajas.Text = "Bajas";
            this.btnBajas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBajas.UseVisualStyleBackColor = true;
            this.btnBajas.Click += new System.EventHandler(this.btnBajas_Click);
            // 
            // panelAltas
            // 
            this.panelAltas.Controls.Add(this.btnAñadirExistencia);
            this.panelAltas.Controls.Add(this.btnAñadirArticulo);
            this.panelAltas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAltas.Location = new System.Drawing.Point(0, 660);
            this.panelAltas.Name = "panelAltas";
            this.panelAltas.Size = new System.Drawing.Size(243, 100);
            this.panelAltas.TabIndex = 4;
            this.panelAltas.Visible = false;
            // 
            // btnAñadirExistencia
            // 
            this.btnAñadirExistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirExistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAñadirExistencia.FlatAppearance.BorderSize = 0;
            this.btnAñadirExistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAñadirExistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAñadirExistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirExistencia.Image = global::SCI1.Properties.Resources.Custom_Icon_Design_Flatastic_4_Package_upload;
            this.btnAñadirExistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirExistencia.Location = new System.Drawing.Point(0, 50);
            this.btnAñadirExistencia.Name = "btnAñadirExistencia";
            this.btnAñadirExistencia.Size = new System.Drawing.Size(243, 50);
            this.btnAñadirExistencia.TabIndex = 9;
            this.btnAñadirExistencia.Tag = "Añadir a existencia";
            this.btnAñadirExistencia.Text = "Añadir a existencia";
            this.btnAñadirExistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadirExistencia.UseVisualStyleBackColor = true;
            this.btnAñadirExistencia.Click += new System.EventHandler(this.btnAñadirExistencia_Click);
            // 
            // btnAñadirArticulo
            // 
            this.btnAñadirArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAñadirArticulo.FlatAppearance.BorderSize = 0;
            this.btnAñadirArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAñadirArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAñadirArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirArticulo.Image = global::SCI1.Properties.Resources.Custom_Icon_Design_Flatastic_4_Package_add;
            this.btnAñadirArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirArticulo.Location = new System.Drawing.Point(0, 0);
            this.btnAñadirArticulo.Name = "btnAñadirArticulo";
            this.btnAñadirArticulo.Size = new System.Drawing.Size(243, 50);
            this.btnAñadirArticulo.TabIndex = 8;
            this.btnAñadirArticulo.Tag = "Artículo de nuevo ingreso";
            this.btnAñadirArticulo.Text = "Artículo de nuevo ingreso";
            this.btnAñadirArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadirArticulo.UseVisualStyleBackColor = true;
            this.btnAñadirArticulo.Click += new System.EventHandler(this.btnAñadirArticulo_Click);
            // 
            // btnAltas
            // 
            this.btnAltas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltas.FlatAppearance.BorderSize = 0;
            this.btnAltas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAltas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltas.Image = global::SCI1.Properties.Resources.data_upload_icon;
            this.btnAltas.Location = new System.Drawing.Point(0, 610);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(243, 50);
            this.btnAltas.TabIndex = 3;
            this.btnAltas.Tag = "Altas";
            this.btnAltas.Text = "Altas";
            this.btnAltas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltas.UseVisualStyleBackColor = true;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            // 
            // panelAreas
            // 
            this.panelAreas.Controls.Add(this.btnAMT);
            this.panelAreas.Controls.Add(this.btnLBC);
            this.panelAreas.Controls.Add(this.btnSGR);
            this.panelAreas.Controls.Add(this.btnMNT);
            this.panelAreas.Controls.Add(this.btnITN);
            this.panelAreas.Controls.Add(this.button2);
            this.panelAreas.Controls.Add(this.btnCIS);
            this.panelAreas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAreas.Location = new System.Drawing.Point(0, 310);
            this.panelAreas.Name = "panelAreas";
            this.panelAreas.Size = new System.Drawing.Size(243, 300);
            this.panelAreas.TabIndex = 2;
            this.panelAreas.Visible = false;
            // 
            // btnAMT
            // 
            this.btnAMT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAMT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAMT.FlatAppearance.BorderSize = 0;
            this.btnAMT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAMT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAMT.Image = global::SCI1.Properties.Resources.Iconshock_Real_Vista_Project_Managment_Data_management;
            this.btnAMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAMT.Location = new System.Drawing.Point(0, 250);
            this.btnAMT.Name = "btnAMT";
            this.btnAMT.Size = new System.Drawing.Size(243, 50);
            this.btnAMT.TabIndex = 8;
            this.btnAMT.Tag = "Archivo muerto";
            this.btnAMT.Text = "Archivo muerto";
            this.btnAMT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAMT.UseVisualStyleBackColor = true;
            this.btnAMT.Click += new System.EventHandler(this.btnAMT_Click);
            // 
            // btnLBC
            // 
            this.btnLBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLBC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLBC.FlatAppearance.BorderSize = 0;
            this.btnLBC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLBC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLBC.Image = global::SCI1.Properties.Resources.Zhoolego_Material_Control_Panel;
            this.btnLBC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLBC.Location = new System.Drawing.Point(0, 200);
            this.btnLBC.Name = "btnLBC";
            this.btnLBC.Size = new System.Drawing.Size(243, 50);
            this.btnLBC.TabIndex = 7;
            this.btnLBC.Tag = "Laboratorio de cómputo";
            this.btnLBC.Text = "Laboratorio de cómputo";
            this.btnLBC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLBC.UseVisualStyleBackColor = true;
            this.btnLBC.Click += new System.EventHandler(this.btnLBC_Click);
            // 
            // btnSGR
            // 
            this.btnSGR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSGR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSGR.FlatAppearance.BorderSize = 0;
            this.btnSGR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSGR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSGR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSGR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSGR.Image = global::SCI1.Properties.Resources.Graphicloads_Seo_Services_Services_portfolio;
            this.btnSGR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSGR.Location = new System.Drawing.Point(0, 150);
            this.btnSGR.Name = "btnSGR";
            this.btnSGR.Size = new System.Drawing.Size(243, 50);
            this.btnSGR.TabIndex = 6;
            this.btnSGR.Tag = "Servicios generales";
            this.btnSGR.Text = "Servicios generales";
            this.btnSGR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSGR.UseVisualStyleBackColor = true;
            this.btnSGR.Click += new System.EventHandler(this.btnSGR_Click);
            // 
            // btnMNT
            // 
            this.btnMNT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMNT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMNT.FlatAppearance.BorderSize = 0;
            this.btnMNT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMNT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMNT.Image = global::SCI1.Properties.Resources.Custom_Icon_Design_Flatastic_8_Maintenance;
            this.btnMNT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMNT.Location = new System.Drawing.Point(0, 100);
            this.btnMNT.Name = "btnMNT";
            this.btnMNT.Size = new System.Drawing.Size(243, 50);
            this.btnMNT.TabIndex = 5;
            this.btnMNT.Tag = "Mantenimiento";
            this.btnMNT.Text = "Mantenimiento";
            this.btnMNT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMNT.UseVisualStyleBackColor = true;
            this.btnMNT.Click += new System.EventHandler(this.btnMNT_Click);
            // 
            // btnITN
            // 
            this.btnITN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnITN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnITN.FlatAppearance.BorderSize = 0;
            this.btnITN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnITN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnITN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnITN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnITN.Image = global::SCI1.Properties.Resources.Atyourservice_Service_Categories_Cleaning;
            this.btnITN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnITN.Location = new System.Drawing.Point(0, 50);
            this.btnITN.Name = "btnITN";
            this.btnITN.Size = new System.Drawing.Size(243, 50);
            this.btnITN.TabIndex = 4;
            this.btnITN.Tag = "Intendencia";
            this.btnITN.Text = "Intendencia";
            this.btnITN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnITN.UseVisualStyleBackColor = true;
            this.btnITN.Click += new System.EventHandler(this.btnITN_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 0);
            this.button2.TabIndex = 3;
            this.button2.Tag = "Inventario por áreas";
            this.button2.Text = "Inventario por áreas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCIS
            // 
            this.btnCIS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCIS.FlatAppearance.BorderSize = 0;
            this.btnCIS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCIS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIS.Image = global::SCI1.Properties.Resources.Aha_Soft_Free_Large_Boss_Teacher;
            this.btnCIS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCIS.Location = new System.Drawing.Point(0, 0);
            this.btnCIS.Name = "btnCIS";
            this.btnCIS.Size = new System.Drawing.Size(243, 50);
            this.btnCIS.TabIndex = 2;
            this.btnCIS.Tag = "Coordinación | Ingresos propios | Servicios Escolares";
            this.btnCIS.Text = "Coordinación | Ingresos propios | Servicios Escolares";
            this.btnCIS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCIS.UseVisualStyleBackColor = true;
            this.btnCIS.Click += new System.EventHandler(this.btnCIS_Click);
            // 
            // btnIAreas
            // 
            this.btnIAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIAreas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIAreas.FlatAppearance.BorderSize = 0;
            this.btnIAreas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIAreas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIAreas.Image = global::SCI1.Properties.Resources.Custom_Icon_Design_Flatastic_4_Inventory_maintenance;
            this.btnIAreas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIAreas.Location = new System.Drawing.Point(0, 260);
            this.btnIAreas.Name = "btnIAreas";
            this.btnIAreas.Size = new System.Drawing.Size(243, 50);
            this.btnIAreas.TabIndex = 1;
            this.btnIAreas.Tag = "Inventario por áreas";
            this.btnIAreas.Text = "   Inventario por áreas";
            this.btnIAreas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIAreas.UseVisualStyleBackColor = true;
            this.btnIAreas.Click += new System.EventHandler(this.btnIAreas_Click);
            // 
            // panelUsuarioResumen
            // 
            this.panelUsuarioResumen.Controls.Add(this.btnReportes);
            this.panelUsuarioResumen.Controls.Add(this.btnRequisicion);
            this.panelUsuarioResumen.Controls.Add(this.btnResumen);
            this.panelUsuarioResumen.Controls.Add(this.panelUsuario);
            this.panelUsuarioResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuarioResumen.Location = new System.Drawing.Point(0, 0);
            this.panelUsuarioResumen.Name = "panelUsuarioResumen";
            this.panelUsuarioResumen.Size = new System.Drawing.Size(243, 260);
            this.panelUsuarioResumen.TabIndex = 0;
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Image = global::SCI1.Properties.Resources.icons8_reporte_de_negocios_32;
            this.btnReportes.Location = new System.Drawing.Point(0, 212);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(243, 50);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Tag = "";
            this.btnReportes.Text = "       Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnRequisicion
            // 
            this.btnRequisicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequisicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequisicion.FlatAppearance.BorderSize = 0;
            this.btnRequisicion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRequisicion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRequisicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequisicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequisicion.Image = global::SCI1.Properties.Resources.icons8_subir_correo_32;
            this.btnRequisicion.Location = new System.Drawing.Point(0, 162);
            this.btnRequisicion.Name = "btnRequisicion";
            this.btnRequisicion.Size = new System.Drawing.Size(243, 50);
            this.btnRequisicion.TabIndex = 3;
            this.btnRequisicion.Tag = "";
            this.btnRequisicion.Text = "       Requisición";
            this.btnRequisicion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRequisicion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRequisicion.UseVisualStyleBackColor = true;
            this.btnRequisicion.Click += new System.EventHandler(this.btnRequisicion_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResumen.FlatAppearance.BorderSize = 0;
            this.btnResumen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumen.Image = global::SCI1.Properties.Resources.icons8_resume_32;
            this.btnResumen.Location = new System.Drawing.Point(0, 112);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(243, 50);
            this.btnResumen.TabIndex = 2;
            this.btnResumen.Tag = "";
            this.btnResumen.Text = "       Resumen";
            this.btnResumen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.pictureBox1);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(243, 112);
            this.panelUsuario.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SCI1.Properties.Resources.Logo_ITSAV11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(195)))), ((int)(((byte)(161)))));
            this.panelCabecera.Controls.Add(this.bntAchicar);
            this.panelCabecera.Controls.Add(this.btnMinizar);
            this.panelCabecera.Controls.Add(this.label1);
            this.panelCabecera.Controls.Add(this.btnAgrandar);
            this.panelCabecera.Controls.Add(this.bntCerrar);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1370, 30);
            this.panelCabecera.TabIndex = 1;
            this.panelCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecera_MouseDown);
            // 
            // bntAchicar
            // 
            this.bntAchicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAchicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAchicar.Image = global::SCI1.Properties.Resources.icons8_shrink_32__1_;
            this.bntAchicar.Location = new System.Drawing.Point(1301, 3);
            this.bntAchicar.Name = "bntAchicar";
            this.bntAchicar.Size = new System.Drawing.Size(25, 25);
            this.bntAchicar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntAchicar.TabIndex = 11;
            this.bntAchicar.TabStop = false;
            this.bntAchicar.Click += new System.EventHandler(this.bntAchicar_Click);
            // 
            // btnMinizar
            // 
            this.btnMinizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinizar.Image = global::SCI1.Properties.Resources.menos2;
            this.btnMinizar.Location = new System.Drawing.Point(1262, 2);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinizar.TabIndex = 10;
            this.btnMinizar.TabStop = false;
            this.btnMinizar.Click += new System.EventHandler(this.btnMinizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bienvenido al Sistema de Control de Inventario de la Unidad Académica Lerdo ITSAV" +
    "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgrandar
            // 
            this.btnAgrandar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgrandar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgrandar.Image = global::SCI1.Properties.Resources.icons8_alternar_pantalla_completa_32;
            this.btnAgrandar.Location = new System.Drawing.Point(1301, 2);
            this.btnAgrandar.Name = "btnAgrandar";
            this.btnAgrandar.Size = new System.Drawing.Size(25, 25);
            this.btnAgrandar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgrandar.TabIndex = 8;
            this.btnAgrandar.TabStop = false;
            this.btnAgrandar.Click += new System.EventHandler(this.btnAgrandar_Click);
            // 
            // bntCerrar
            // 
            this.bntCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCerrar.Image = global::SCI1.Properties.Resources.pngwing1;
            this.bntCerrar.Location = new System.Drawing.Point(1340, 2);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(25, 25);
            this.bntCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntCerrar.TabIndex = 7;
            this.bntCerrar.TabStop = false;
            this.bntCerrar.Click += new System.EventHandler(this.bntCerrar_Click);
            // 
            // SistemaControlInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelInicial);
            this.Controls.Add(this.panelCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 718);
            this.Name = "SistemaControlInventario";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Inventario";
            this.Load += new System.EventHandler(this.SistemaControlInventario_Load_1);
            this.panelInicial.ResumeLayout(false);
            this.panelLateral.ResumeLayout(false);
            this.panelBajas.ResumeLayout(false);
            this.panelAltas.ResumeLayout(false);
            this.panelAreas.ResumeLayout(false);
            this.panelUsuarioResumen.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntAchicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgrandar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInicial;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnIAreas;
        private System.Windows.Forms.Panel panelUsuarioResumen;
        private System.Windows.Forms.Panel panelAreas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCIS;
        private System.Windows.Forms.Panel panelAltas;
        private System.Windows.Forms.Button btnAñadirExistencia;
        private System.Windows.Forms.Button btnAñadirArticulo;
        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.Button btnLBC;
        private System.Windows.Forms.Button btnSGR;
        private System.Windows.Forms.Button btnMNT;
        private System.Windows.Forms.Button btnITN;
        private System.Windows.Forms.Button btnAMT;
        private System.Windows.Forms.Button btnBajas;
        private System.Windows.Forms.Panel panelBajas;
        private System.Windows.Forms.Button btnDisminuirExistencia;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Panel panelUsuario;
        public System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnRequisicion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.PictureBox btnAgrandar;
        private System.Windows.Forms.PictureBox bntCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bntAchicar;
        private System.Windows.Forms.PictureBox btnMinizar;
    }
}