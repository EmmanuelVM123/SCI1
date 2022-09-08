namespace SCI1
{
    partial class InventarioITN
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
            System.Windows.Forms.Label cantidadCriticaLabel;
            System.Windows.Forms.Label cantidadNormalLabel;
            System.Windows.Forms.Label idUnidadMedidaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label nombreArticuloLabel;
            System.Windows.Forms.Label idAreaLabel;
            System.Windows.Forms.Label idArticuloLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.cantidadCriticaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inventarioITNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCIDataSet = new SCI1.SCIDataSet();
            this.cantidadNormalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idUnidadMedidaComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombreArticuloTextBox = new System.Windows.Forms.TextBox();
            this.idAreaComboBox = new System.Windows.Forms.ComboBox();
            this.idArticuloTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.inventarioITNDataGridView = new System.Windows.Forms.DataGridView();
            this.IdArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.inventarioITNTableAdapter = new SCI1.SCIDataSetTableAdapters.InventarioITNTableAdapter();
            this.tableAdapterManager = new SCI1.SCIDataSetTableAdapters.TableAdapterManager();
            cantidadCriticaLabel = new System.Windows.Forms.Label();
            cantidadNormalLabel = new System.Windows.Forms.Label();
            idUnidadMedidaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            nombreArticuloLabel = new System.Windows.Forms.Label();
            idAreaLabel = new System.Windows.Forms.Label();
            idArticuloLabel = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadCriticaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioITNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNormalNumericUpDown)).BeginInit();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioITNDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadCriticaLabel
            // 
            cantidadCriticaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            cantidadCriticaLabel.AutoSize = true;
            cantidadCriticaLabel.Location = new System.Drawing.Point(393, 116);
            cantidadCriticaLabel.Name = "cantidadCriticaLabel";
            cantidadCriticaLabel.Size = new System.Drawing.Size(85, 13);
            cantidadCriticaLabel.TabIndex = 15;
            cantidadCriticaLabel.Text = "Cantidad crítica:";
            // 
            // cantidadNormalLabel
            // 
            cantidadNormalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            cantidadNormalLabel.AutoSize = true;
            cantidadNormalLabel.Location = new System.Drawing.Point(172, 118);
            cantidadNormalLabel.Name = "cantidadNormalLabel";
            cantidadNormalLabel.Size = new System.Drawing.Size(86, 13);
            cantidadNormalLabel.TabIndex = 13;
            cantidadNormalLabel.Text = "Cantidad normal:";
            // 
            // idUnidadMedidaLabel
            // 
            idUnidadMedidaLabel.AutoSize = true;
            idUnidadMedidaLabel.Location = new System.Drawing.Point(16, 116);
            idUnidadMedidaLabel.Name = "idUnidadMedidaLabel";
            idUnidadMedidaLabel.Size = new System.Drawing.Size(45, 13);
            idUnidadMedidaLabel.TabIndex = 11;
            idUnidadMedidaLabel.Text = "Medida:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(16, 51);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 9;
            descripcionLabel.Text = "Descripción:";
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
            this.panelTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(50, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Intendencia";
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
            this.panelBotones.Controls.Add(cantidadCriticaLabel);
            this.panelBotones.Controls.Add(this.cantidadCriticaNumericUpDown);
            this.panelBotones.Controls.Add(cantidadNormalLabel);
            this.panelBotones.Controls.Add(this.cantidadNormalNumericUpDown);
            this.panelBotones.Controls.Add(idUnidadMedidaLabel);
            this.panelBotones.Controls.Add(this.idUnidadMedidaComboBox);
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
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 531);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1014, 150);
            this.panelBotones.TabIndex = 2;
            // 
            // cantidadCriticaNumericUpDown
            // 
            this.cantidadCriticaNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cantidadCriticaNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventarioITNBindingSource, "CantidadCritica", true));
            this.cantidadCriticaNumericUpDown.Location = new System.Drawing.Point(494, 113);
            this.cantidadCriticaNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cantidadCriticaNumericUpDown.Name = "cantidadCriticaNumericUpDown";
            this.cantidadCriticaNumericUpDown.Size = new System.Drawing.Size(96, 20);
            this.cantidadCriticaNumericUpDown.TabIndex = 16;
            // 
            // inventarioITNBindingSource
            // 
            this.inventarioITNBindingSource.DataMember = "InventarioITN";
            this.inventarioITNBindingSource.DataSource = this.sCIDataSet;
            // 
            // sCIDataSet
            // 
            this.sCIDataSet.DataSetName = "SCIDataSet";
            this.sCIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cantidadNormalNumericUpDown
            // 
            this.cantidadNormalNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cantidadNormalNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventarioITNBindingSource, "CantidadNormal", true));
            this.cantidadNormalNumericUpDown.Location = new System.Drawing.Point(266, 114);
            this.cantidadNormalNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cantidadNormalNumericUpDown.Name = "cantidadNormalNumericUpDown";
            this.cantidadNormalNumericUpDown.Size = new System.Drawing.Size(91, 20);
            this.cantidadNormalNumericUpDown.TabIndex = 14;
            // 
            // idUnidadMedidaComboBox
            // 
            this.idUnidadMedidaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.idUnidadMedidaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioITNBindingSource, "IdUnidadMedida", true));
            this.idUnidadMedidaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idUnidadMedidaComboBox.FormattingEnabled = true;
            this.idUnidadMedidaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.idUnidadMedidaComboBox.Location = new System.Drawing.Point(67, 113);
            this.idUnidadMedidaComboBox.Name = "idUnidadMedidaComboBox";
            this.idUnidadMedidaComboBox.Size = new System.Drawing.Size(55, 21);
            this.idUnidadMedidaComboBox.TabIndex = 12;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioITNBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(88, 48);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(502, 43);
            this.descripcionTextBox.TabIndex = 10;
            // 
            // nombreArticuloTextBox
            // 
            this.nombreArticuloTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nombreArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioITNBindingSource, "NombreArticulo", true));
            this.nombreArticuloTextBox.Location = new System.Drawing.Point(300, 14);
            this.nombreArticuloTextBox.Name = "nombreArticuloTextBox";
            this.nombreArticuloTextBox.Size = new System.Drawing.Size(290, 20);
            this.nombreArticuloTextBox.TabIndex = 8;
            // 
            // idAreaComboBox
            // 
            this.idAreaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.idAreaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioITNBindingSource, "IdArea", true));
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
            this.idArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioITNBindingSource, "IdArticulo", true));
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
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Image = global::SCI1.Properties.Resources.Apps_menu_editor_icon;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(765, 37);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 85);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panelDGV
            // 
            this.panelDGV.Controls.Add(this.inventarioITNDataGridView);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGV.Location = new System.Drawing.Point(0, 25);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(1014, 506);
            this.panelDGV.TabIndex = 3;
            // 
            // inventarioITNDataGridView
            // 
            this.inventarioITNDataGridView.AllowUserToAddRows = false;
            this.inventarioITNDataGridView.AllowUserToDeleteRows = false;
            this.inventarioITNDataGridView.AllowUserToOrderColumns = true;
            this.inventarioITNDataGridView.AutoGenerateColumns = false;
            this.inventarioITNDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.inventarioITNDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.inventarioITNDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventarioITNDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventarioITNDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inventarioITNDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarioITNDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArea,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.inventarioITNDataGridView.DataSource = this.inventarioITNBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventarioITNDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.inventarioITNDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventarioITNDataGridView.EnableHeadersVisualStyles = false;
            this.inventarioITNDataGridView.Location = new System.Drawing.Point(0, 0);
            this.inventarioITNDataGridView.Name = "inventarioITNDataGridView";
            this.inventarioITNDataGridView.ReadOnly = true;
            this.inventarioITNDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventarioITNDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.inventarioITNDataGridView.RowHeadersVisible = false;
            this.inventarioITNDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioITNDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventarioITNDataGridView.Size = new System.Drawing.Size(1014, 506);
            this.inventarioITNDataGridView.TabIndex = 0;
            // 
            // IdArea
            // 
            this.IdArea.DataPropertyName = "IdArea";
            this.IdArea.HeaderText = "Area";
            this.IdArea.Name = "IdArea";
            this.IdArea.ReadOnly = true;
            this.IdArea.Width = 64;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdArticulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 46;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreArticulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Artículo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 83;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 114;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 93;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdUnidadMedida";
            this.dataGridViewTextBoxColumn6.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 83;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CantidadNormal";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cantidad normal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 132;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CantidadCritica";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cantidad crítica";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 127;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // inventarioITNTableAdapter
            // 
            this.inventarioITNTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreasTableAdapter = null;
            this.tableAdapterManager.ArticuloARequisitar = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Inventario_TableAdapter = null;
            this.tableAdapterManager.InventarioAMTTableAdapter = null;
            this.tableAdapterManager.InventarioCISTableAdapter = null;
            this.tableAdapterManager.InventarioCrearTableAdapter = null;
            this.tableAdapterManager.InventarioITNTableAdapter = this.inventarioITNTableAdapter;
            this.tableAdapterManager.InventarioLBCTableAdapter = null;
            this.tableAdapterManager.InventarioMNTTableAdapter = null;
            this.tableAdapterManager.InventarioSGRTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.UnidadMedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SCI1.SCIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // InventarioITN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.panelDGV);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventarioITN";
            this.Text = "InventarioITN";
            this.Load += new System.EventHandler(this.InventarioITN_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadCriticaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioITNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNormalNumericUpDown)).EndInit();
            this.panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioITNDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnRecargar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.NumericUpDown cantidadCriticaNumericUpDown;
        private System.Windows.Forms.NumericUpDown cantidadNormalNumericUpDown;
        private System.Windows.Forms.ComboBox idUnidadMedidaComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombreArticuloTextBox;
        private System.Windows.Forms.ComboBox idAreaComboBox;
        private System.Windows.Forms.TextBox idArticuloTextBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panelDGV;
        private SCIDataSet sCIDataSet;
        private System.Windows.Forms.BindingSource inventarioITNBindingSource;
        private SCIDataSetTableAdapters.InventarioITNTableAdapter inventarioITNTableAdapter;
        private SCIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inventarioITNDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}