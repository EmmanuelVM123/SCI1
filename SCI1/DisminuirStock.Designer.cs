namespace SCI1
{
    partial class DisminuirStock
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label nombreArticuloLabel;
            System.Windows.Forms.Label idAreaLabel;
            System.Windows.Forms.Label idArticuloLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sCIDataSet = new SCI1.SCIDataSet();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombreArticuloTextBox = new System.Windows.Forms.TextBox();
            this.idAreaComboBox = new System.Windows.Forms.ComboBox();
            this.idArticuloTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.inventarioDataGridView = new System.Windows.Forms.DataGridView();
            this.idAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadNormalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCriticaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventario_TableAdapter = new SCI1.SCIDataSetTableAdapters.Inventario_TableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            cantidadLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            nombreArticuloLabel = new System.Windows.Forms.Label();
            idAreaLabel = new System.Windows.Forms.Label();
            idArticuloLabel = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).BeginInit();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(23, 113);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 11;
            cantidadLabel.Text = "Cantidad:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(16, 51);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 9;
            descripcionLabel.Text = "Descripcion:";
            // 
            // nombreArticuloLabel
            // 
            nombreArticuloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            nombreArticuloLabel.AutoSize = true;
            nombreArticuloLabel.Location = new System.Drawing.Point(247, 16);
            nombreArticuloLabel.Name = "nombreArticuloLabel";
            nombreArticuloLabel.Size = new System.Drawing.Size(47, 13);
            nombreArticuloLabel.TabIndex = 7;
            nombreArticuloLabel.Text = "Artículo:";
            // 
            // idAreaLabel
            // 
            idAreaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            idAreaLabel.AutoSize = true;
            idAreaLabel.Location = new System.Drawing.Point(130, 16);
            idAreaLabel.Name = "idAreaLabel";
            idAreaLabel.Size = new System.Drawing.Size(32, 13);
            idAreaLabel.TabIndex = 5;
            idAreaLabel.Text = "Área:";
            // 
            // idArticuloLabel
            // 
            idArticuloLabel.AutoSize = true;
            idArticuloLabel.Location = new System.Drawing.Point(16, 16);
            idArticuloLabel.Name = "idArticuloLabel";
            idArticuloLabel.Size = new System.Drawing.Size(18, 13);
            idArticuloLabel.TabIndex = 3;
            idArticuloLabel.Text = "ID";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.LightCoral;
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restar a stock";
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
            // panelBotones
            // 
            this.panelBotones.Controls.Add(cantidadLabel);
            this.panelBotones.Controls.Add(this.cantidadNumericUpDown);
            this.panelBotones.Controls.Add(descripcionLabel);
            this.panelBotones.Controls.Add(this.descripcionTextBox);
            this.panelBotones.Controls.Add(nombreArticuloLabel);
            this.panelBotones.Controls.Add(this.nombreArticuloTextBox);
            this.panelBotones.Controls.Add(idAreaLabel);
            this.panelBotones.Controls.Add(this.idAreaComboBox);
            this.panelBotones.Controls.Add(idArticuloLabel);
            this.panelBotones.Controls.Add(this.idArticuloTextBox);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnDisminuir);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 531);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1014, 150);
            this.panelBotones.TabIndex = 4;
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventarioBindingSource1, "Cantidad", true));
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(81, 109);
            this.cantidadNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.cantidadNumericUpDown.TabIndex = 12;
            // 
            // inventarioBindingSource1
            // 
            this.inventarioBindingSource1.DataMember = "Inventario-";
            this.inventarioBindingSource1.DataSource = this.sCIDataSet;
            // 
            // sCIDataSet
            // 
            this.sCIDataSet.DataSetName = "SCIDataSet";
            this.sCIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource1, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(88, 48);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(502, 43);
            this.descripcionTextBox.TabIndex = 10;
            // 
            // nombreArticuloTextBox
            // 
            this.nombreArticuloTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nombreArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource1, "NombreArticulo", true));
            this.nombreArticuloTextBox.Location = new System.Drawing.Point(300, 14);
            this.nombreArticuloTextBox.Name = "nombreArticuloTextBox";
            this.nombreArticuloTextBox.Size = new System.Drawing.Size(290, 20);
            this.nombreArticuloTextBox.TabIndex = 8;
            // 
            // idAreaComboBox
            // 
            this.idAreaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.idAreaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource1, "IdArea", true));
            this.idAreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idAreaComboBox.FormattingEnabled = true;
            this.idAreaComboBox.Items.AddRange(new object[] {
            "CIS",
            "ITN",
            "MNT",
            "SGR",
            "LBC",
            "AMT"});
            this.idAreaComboBox.Location = new System.Drawing.Point(167, 13);
            this.idAreaComboBox.Name = "idAreaComboBox";
            this.idAreaComboBox.Size = new System.Drawing.Size(55, 21);
            this.idAreaComboBox.TabIndex = 6;
            // 
            // idArticuloTextBox
            // 
            this.idArticuloTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.idArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource1, "IdArticulo", true));
            this.idArticuloTextBox.Location = new System.Drawing.Point(49, 13);
            this.idArticuloTextBox.Name = "idArticuloTextBox";
            this.idArticuloTextBox.Size = new System.Drawing.Size(73, 20);
            this.idArticuloTextBox.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = global::SCI1.Properties.Resources.Windows_Close_Program_icon;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(927, 37);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 85);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::SCI1.Properties.Resources.Save_icon;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(846, 37);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 85);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisminuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisminuir.Image = global::SCI1.Properties.Resources.icons8_dinámica_negativa_64;
            this.btnDisminuir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDisminuir.Location = new System.Drawing.Point(765, 37);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(75, 85);
            this.btnDisminuir.TabIndex = 0;
            this.btnDisminuir.Text = "Disminuir";
            this.btnDisminuir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisminuir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDisminuir.UseVisualStyleBackColor = true;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // panelDGV
            // 
            this.panelDGV.Controls.Add(this.inventarioDataGridView);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGV.Location = new System.Drawing.Point(0, 25);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(1014, 506);
            this.panelDGV.TabIndex = 5;
            // 
            // inventarioDataGridView
            // 
            this.inventarioDataGridView.AllowUserToAddRows = false;
            this.inventarioDataGridView.AllowUserToDeleteRows = false;
            this.inventarioDataGridView.AllowUserToOrderColumns = true;
            this.inventarioDataGridView.AutoGenerateColumns = false;
            this.inventarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.inventarioDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.inventarioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventarioDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAreaDataGridViewTextBoxColumn,
            this.idArticuloDataGridViewTextBoxColumn,
            this.nombreArticuloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.idUnidadMedidaDataGridViewTextBoxColumn,
            this.cantidadNormalDataGridViewTextBoxColumn,
            this.cantidadCriticaDataGridViewTextBoxColumn});
            this.inventarioDataGridView.DataSource = this.inventarioBindingSource1;
            this.inventarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventarioDataGridView.EnableHeadersVisualStyles = false;
            this.inventarioDataGridView.Location = new System.Drawing.Point(0, 0);
            this.inventarioDataGridView.Name = "inventarioDataGridView";
            this.inventarioDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventarioDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.inventarioDataGridView.RowHeadersVisible = false;
            this.inventarioDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventarioDataGridView.Size = new System.Drawing.Size(1014, 506);
            this.inventarioDataGridView.TabIndex = 1;
            // 
            // idAreaDataGridViewTextBoxColumn
            // 
            this.idAreaDataGridViewTextBoxColumn.DataPropertyName = "IdArea";
            this.idAreaDataGridViewTextBoxColumn.HeaderText = "Área";
            this.idAreaDataGridViewTextBoxColumn.Name = "idAreaDataGridViewTextBoxColumn";
            this.idAreaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAreaDataGridViewTextBoxColumn.Width = 64;
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            this.idArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArticuloDataGridViewTextBoxColumn.Width = 46;
            // 
            // nombreArticuloDataGridViewTextBoxColumn
            // 
            this.nombreArticuloDataGridViewTextBoxColumn.DataPropertyName = "NombreArticulo";
            this.nombreArticuloDataGridViewTextBoxColumn.HeaderText = "Artículo";
            this.nombreArticuloDataGridViewTextBoxColumn.Name = "nombreArticuloDataGridViewTextBoxColumn";
            this.nombreArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreArticuloDataGridViewTextBoxColumn.Width = 83;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 114;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 93;
            // 
            // idUnidadMedidaDataGridViewTextBoxColumn
            // 
            this.idUnidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "IdUnidadMedida";
            this.idUnidadMedidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.idUnidadMedidaDataGridViewTextBoxColumn.Name = "idUnidadMedidaDataGridViewTextBoxColumn";
            this.idUnidadMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUnidadMedidaDataGridViewTextBoxColumn.Width = 83;
            // 
            // cantidadNormalDataGridViewTextBoxColumn
            // 
            this.cantidadNormalDataGridViewTextBoxColumn.DataPropertyName = "CantidadNormal";
            this.cantidadNormalDataGridViewTextBoxColumn.HeaderText = "Cantidad normal";
            this.cantidadNormalDataGridViewTextBoxColumn.Name = "cantidadNormalDataGridViewTextBoxColumn";
            this.cantidadNormalDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadNormalDataGridViewTextBoxColumn.Width = 132;
            // 
            // cantidadCriticaDataGridViewTextBoxColumn
            // 
            this.cantidadCriticaDataGridViewTextBoxColumn.DataPropertyName = "CantidadCritica";
            this.cantidadCriticaDataGridViewTextBoxColumn.HeaderText = "Cantidad crítica";
            this.cantidadCriticaDataGridViewTextBoxColumn.Name = "cantidadCriticaDataGridViewTextBoxColumn";
            this.cantidadCriticaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadCriticaDataGridViewTextBoxColumn.Width = 127;
            // 
            // inventario_TableAdapter
            // 
            this.inventario_TableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DisminuirStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.panelDGV);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisminuirStock";
            this.Text = "DisminuirStock";
            this.Load += new System.EventHandler(this.DisminuirStock_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).EndInit();
            this.panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnRecargar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombreArticuloTextBox;
        private System.Windows.Forms.ComboBox idAreaComboBox;
        private System.Windows.Forms.TextBox idArticuloTextBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDisminuir;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.DataGridView inventarioDataGridView;
        private SCIDataSet sCIDataSet;
        private SCIDataSetTableAdapters.Inventario_TableAdapter inventario_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadNormalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCriticaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inventarioBindingSource1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}