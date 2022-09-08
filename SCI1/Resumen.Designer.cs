namespace SCI1
{
    partial class Resumen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resumen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.articuloARequisitarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCIDataSet = new SCI1.SCIDataSet();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvArticulosSolcitados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloARequisitar = new SCI1.SCIDataSetTableAdapters.ArticuloARequisitar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.inventarioTableAdapter = new SCI1.SCIDataSetTableAdapters.InventarioTableAdapter();
            this.panelSolicitarArticulos = new System.Windows.Forms.Panel();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.dgvArticulosASolicitar = new System.Windows.Forms.DataGridView();
            this.IdArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCritica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOtroArticulo = new System.Windows.Forms.Panel();
            this.cbxCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnSolicitarNuevo = new System.Windows.Forms.Button();
            this.cbxUsar = new System.Windows.Forms.ComboBox();
            this.cbxAreaSolicitante = new System.Windows.Forms.ComboBox();
            this.cbxArticulo = new System.Windows.Forms.ComboBox();
            this.cbxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloARequisitarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosSolcitados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelSolicitarArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosASolicitar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelOtroArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Controls.Add(this.btnRecargar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1014, 25);
            this.panelTitulo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(453, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resumen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.Image = global::SCI1.Properties.Resources.Reload_2_2_icon2;
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
            // articuloARequisitarBindingSource
            // 
            this.articuloARequisitarBindingSource.DataMember = "ArticuloARequisitar";
            this.articuloARequisitarBindingSource.DataSource = this.sCIDataSet;
            // 
            // sCIDataSet
            // 
            this.sCIDataSet.DataSetName = "SCIDataSet";
            this.sCIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.sCIDataSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEnviar);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.dgvArticulosSolcitados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 245);
            this.panel2.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = global::SCI1.Properties.Resources.icons8_generador_automotriz_32;
            this.btnEnviar.Location = new System.Drawing.Point(334, 184);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(296, 40);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Generar requisición";
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Image = global::SCI1.Properties.Resources.limpieza_de_datos;
            this.btnLimpiar.Location = new System.Drawing.Point(423, 129);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 40);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvArticulosSolcitados
            // 
            this.dgvArticulosSolcitados.AllowUserToAddRows = false;
            this.dgvArticulosSolcitados.AllowUserToOrderColumns = true;
            this.dgvArticulosSolcitados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulosSolcitados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulosSolcitados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulosSolcitados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulosSolcitados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulosSolcitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosSolcitados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvArticulosSolcitados.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvArticulosSolcitados.Location = new System.Drawing.Point(0, 0);
            this.dgvArticulosSolcitados.Name = "dgvArticulosSolcitados";
            this.dgvArticulosSolcitados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvArticulosSolcitados.RowHeadersWidth = 42;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvArticulosSolcitados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulosSolcitados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulosSolcitados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosSolcitados.Size = new System.Drawing.Size(1014, 114);
            this.dgvArticulosSolcitados.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 82;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 73;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Artículo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 77;
            // 
            // articuloARequisitar
            // 
            this.articuloARequisitar.ClearBeforeFill = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // panelSolicitarArticulos
            // 
            this.panelSolicitarArticulos.Controls.Add(this.btnSolicitar);
            this.panelSolicitarArticulos.Controls.Add(this.dgvArticulosASolicitar);
            this.panelSolicitarArticulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSolicitarArticulos.Location = new System.Drawing.Point(0, 0);
            this.panelSolicitarArticulos.Name = "panelSolicitarArticulos";
            this.panelSolicitarArticulos.Size = new System.Drawing.Size(1014, 273);
            this.panelSolicitarArticulos.TabIndex = 15;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSolicitar.Enabled = false;
            this.btnSolicitar.Image = global::SCI1.Properties.Resources.icons8_insertar_fila_debajo_32;
            this.btnSolicitar.Location = new System.Drawing.Point(423, 223);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(120, 41);
            this.btnSolicitar.TabIndex = 8;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSolicitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // dgvArticulosASolicitar
            // 
            this.dgvArticulosASolicitar.AllowUserToAddRows = false;
            this.dgvArticulosASolicitar.AllowUserToDeleteRows = false;
            this.dgvArticulosASolicitar.AllowUserToOrderColumns = true;
            this.dgvArticulosASolicitar.AutoGenerateColumns = false;
            this.dgvArticulosASolicitar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulosASolicitar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulosASolicitar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulosASolicitar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulosASolicitar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosASolicitar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArea,
            this.IdArticulo,
            this.NombreArticulo,
            this.Descripcion,
            this.Cantidad,
            this.IdUnidadMedida,
            this.CantidadNormal,
            this.CantidadCritica,
            this.seleccionar});
            this.dgvArticulosASolicitar.DataSource = this.articuloARequisitarBindingSource;
            this.dgvArticulosASolicitar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvArticulosASolicitar.EnableHeadersVisualStyles = false;
            this.dgvArticulosASolicitar.Location = new System.Drawing.Point(0, 0);
            this.dgvArticulosASolicitar.Name = "dgvArticulosASolicitar";
            this.dgvArticulosASolicitar.ReadOnly = true;
            this.dgvArticulosASolicitar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvArticulosASolicitar.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvArticulosASolicitar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulosASolicitar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosASolicitar.Size = new System.Drawing.Size(1014, 217);
            this.dgvArticulosASolicitar.TabIndex = 2;
            // 
            // IdArea
            // 
            this.IdArea.DataPropertyName = "IdArea";
            this.IdArea.HeaderText = "Área";
            this.IdArea.Name = "IdArea";
            this.IdArea.ReadOnly = true;
            this.IdArea.Width = 64;
            // 
            // IdArticulo
            // 
            this.IdArticulo.DataPropertyName = "IdArticulo";
            this.IdArticulo.HeaderText = "ID";
            this.IdArticulo.Name = "IdArticulo";
            this.IdArticulo.ReadOnly = true;
            this.IdArticulo.Width = 46;
            // 
            // NombreArticulo
            // 
            this.NombreArticulo.DataPropertyName = "NombreArticulo";
            this.NombreArticulo.HeaderText = "Artículo";
            this.NombreArticulo.Name = "NombreArticulo";
            this.NombreArticulo.ReadOnly = true;
            this.NombreArticulo.Width = 83;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 114;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 93;
            // 
            // IdUnidadMedida
            // 
            this.IdUnidadMedida.DataPropertyName = "IdUnidadMedida";
            this.IdUnidadMedida.HeaderText = "Medida";
            this.IdUnidadMedida.Name = "IdUnidadMedida";
            this.IdUnidadMedida.ReadOnly = true;
            this.IdUnidadMedida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdUnidadMedida.Width = 83;
            // 
            // CantidadNormal
            // 
            this.CantidadNormal.DataPropertyName = "CantidadNormal";
            this.CantidadNormal.HeaderText = "Cantidad normal";
            this.CantidadNormal.Name = "CantidadNormal";
            this.CantidadNormal.ReadOnly = true;
            this.CantidadNormal.Width = 132;
            // 
            // CantidadCritica
            // 
            this.CantidadCritica.DataPropertyName = "CantidadCritica";
            this.CantidadCritica.HeaderText = "Cantidad crítica";
            this.CantidadCritica.Name = "CantidadCritica";
            this.CantidadCritica.ReadOnly = true;
            this.CantidadCritica.Width = 127;
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.ReadOnly = true;
            this.seleccionar.Visible = false;
            this.seleccionar.Width = 95;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelSolicitarArticulos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 274);
            this.panel1.TabIndex = 4;
            // 
            // panelOtroArticulo
            // 
            this.panelOtroArticulo.Controls.Add(this.cbxCantidad);
            this.panelOtroArticulo.Controls.Add(this.btnSolicitarNuevo);
            this.panelOtroArticulo.Controls.Add(this.cbxUsar);
            this.panelOtroArticulo.Controls.Add(this.cbxAreaSolicitante);
            this.panelOtroArticulo.Controls.Add(this.cbxArticulo);
            this.panelOtroArticulo.Controls.Add(this.cbxUnidadMedida);
            this.panelOtroArticulo.Controls.Add(this.label6);
            this.panelOtroArticulo.Controls.Add(this.label5);
            this.panelOtroArticulo.Controls.Add(this.label4);
            this.panelOtroArticulo.Controls.Add(this.label3);
            this.panelOtroArticulo.Controls.Add(this.label2);
            this.panelOtroArticulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOtroArticulo.Location = new System.Drawing.Point(0, 605);
            this.panelOtroArticulo.Name = "panelOtroArticulo";
            this.panelOtroArticulo.Size = new System.Drawing.Size(1014, 183);
            this.panelOtroArticulo.TabIndex = 6;
            // 
            // cbxCantidad
            // 
            this.cbxCantidad.Location = new System.Drawing.Point(203, 63);
            this.cbxCantidad.Name = "cbxCantidad";
            this.cbxCantidad.Size = new System.Drawing.Size(272, 20);
            this.cbxCantidad.TabIndex = 25;
            // 
            // btnSolicitarNuevo
            // 
            this.btnSolicitarNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSolicitarNuevo.Image = global::SCI1.Properties.Resources.icons8_crear_archivo_32;
            this.btnSolicitarNuevo.Location = new System.Drawing.Point(423, 130);
            this.btnSolicitarNuevo.Name = "btnSolicitarNuevo";
            this.btnSolicitarNuevo.Size = new System.Drawing.Size(120, 41);
            this.btnSolicitarNuevo.TabIndex = 9;
            this.btnSolicitarNuevo.Text = "Solicitar nuevo";
            this.btnSolicitarNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSolicitarNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSolicitarNuevo.UseVisualStyleBackColor = true;
            this.btnSolicitarNuevo.Click += new System.EventHandler(this.btnSolicitarNuevo_Click);
            // 
            // cbxUsar
            // 
            this.cbxUsar.FormattingEnabled = true;
            this.cbxUsar.Items.AddRange(new object[] {
            "POR EL PERSONAL DE OFICINA.",
            "POR EL ÁREA DE INTENDENCIA PARA LA LIMPIEZA DE LAS ÁREAS.",
            "POR EL AREA DE MANTENIMIENTO PARA MANTENIMIENTO DE LA UNIDAD.",
            "POR EL AREA DE JARDINERIA PARA MANTENIMIENTO DEL EQUIPO."});
            this.cbxUsar.Location = new System.Drawing.Point(203, 102);
            this.cbxUsar.Name = "cbxUsar";
            this.cbxUsar.Size = new System.Drawing.Size(560, 21);
            this.cbxUsar.TabIndex = 24;
            this.cbxUsar.Text = "Seleccione o describa para que o por quiénes serán utilizados los artículos solic" +
    "itados";
            // 
            // cbxAreaSolicitante
            // 
            this.cbxAreaSolicitante.FormattingEnabled = true;
            this.cbxAreaSolicitante.Items.AddRange(new object[] {
            "CIS - COORDINACIÓN/OFICINA",
            "ITN - INTEN",
            "MNT - MANTENIMIENTO",
            "SGR - SERVICIOS GENERALES",
            "LBC -LABORATORIO DE CÓMPUTO",
            "AMT - ARCHIVO MUERTO"});
            this.cbxAreaSolicitante.Location = new System.Drawing.Point(203, 23);
            this.cbxAreaSolicitante.Name = "cbxAreaSolicitante";
            this.cbxAreaSolicitante.Size = new System.Drawing.Size(272, 21);
            this.cbxAreaSolicitante.TabIndex = 23;
            this.cbxAreaSolicitante.Text = "Seleccione el área";
            // 
            // cbxArticulo
            // 
            this.cbxArticulo.DataSource = this.inventarioBindingSource;
            this.cbxArticulo.DisplayMember = "NombreArticulo";
            this.cbxArticulo.FormattingEnabled = true;
            this.cbxArticulo.Location = new System.Drawing.Point(497, 23);
            this.cbxArticulo.Name = "cbxArticulo";
            this.cbxArticulo.Size = new System.Drawing.Size(266, 21);
            this.cbxArticulo.TabIndex = 22;
            this.cbxArticulo.ValueMember = "NombreArticulo";
            // 
            // cbxUnidadMedida
            // 
            this.cbxUnidadMedida.FormattingEnabled = true;
            this.cbxUnidadMedida.Items.AddRange(new object[] {
            "PZS",
            "KGS",
            "LTS"});
            this.cbxUnidadMedida.Location = new System.Drawing.Point(497, 63);
            this.cbxUnidadMedida.Name = "cbxUnidadMedida";
            this.cbxUnidadMedida.Size = new System.Drawing.Size(266, 21);
            this.cbxUnidadMedida.TabIndex = 21;
            this.cbxUnidadMedida.Text = "Seleccione o describa la unidad de medida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Lo anterior para ser utilizado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Unidad de medida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad solicitada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Artículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Área solicitante";
            // 
            // Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1014, 788);
            this.Controls.Add(this.panelOtroArticulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 718);
            this.Name = "Resumen";
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.Resumen_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloARequisitarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosSolcitados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelSolicitarArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosASolicitar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelOtroArticulo.ResumeLayout(false);
            this.panelOtroArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnRecargar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private SCIDataSet sCIDataSet;
        private System.Windows.Forms.BindingSource articuloARequisitarBindingSource;
        private SCIDataSetTableAdapters.ArticuloARequisitar articuloARequisitar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private SCIDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        public System.Windows.Forms.DataGridView dgvArticulosSolcitados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSolicitarArticulos;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.DataGridView dgvArticulosASolicitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCritica;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Panel panelOtroArticulo;
        private System.Windows.Forms.Button btnSolicitarNuevo;
        private System.Windows.Forms.ComboBox cbxUsar;
        private System.Windows.Forms.ComboBox cbxAreaSolicitante;
        private System.Windows.Forms.ComboBox cbxArticulo;
        private System.Windows.Forms.ComboBox cbxUnidadMedida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cbxCantidad;
    }
}