
namespace SCI1
{
    partial class InsertarInventario
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
            System.Windows.Forms.Label idArticuloLabel;
            System.Windows.Forms.Label nombreArticuloLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idAreaLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label idUnidadMedidaLabel;
            System.Windows.Forms.Label cantidadNormalLabel;
            System.Windows.Forms.Label cantidadCriticaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarInventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarFormulario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inventarioInsertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCIDataSet = new SCI1.SCIDataSet();
            this.unidadMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.inventarioDataGridView = new System.Windows.Forms.DataGridView();
            this.IdArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCritica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioInsertTableAdapter = new SCI1.SCIDataSetTableAdapters.InventarioInsertTableAdapter();
            this.tableAdapterManager = new SCI1.SCIDataSetTableAdapters.TableAdapterManager();
            this.areasTableAdapter = new SCI1.SCIDataSetTableAdapters.AreasTableAdapter();
            this.unidadMedidaTableAdapter = new SCI1.SCIDataSetTableAdapters.UnidadMedidaTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idArticuloTextBox = new System.Windows.Forms.TextBox();
            this.nombreArticuloTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.cantidadCriticaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cantidadNormalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idUnidadMedidaComboBox = new System.Windows.Forms.ComboBox();
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idAreaComboBox = new System.Windows.Forms.ComboBox();
            this.inventarioInsertarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioInsertarTableAdapter = new SCI1.SCIDataSetTableAdapters.InventarioInsertarTableAdapter();
            idArticuloLabel = new System.Windows.Forms.Label();
            nombreArticuloLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            idAreaLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            idUnidadMedidaLabel = new System.Windows.Forms.Label();
            cantidadNormalLabel = new System.Windows.Forms.Label();
            cantidadCriticaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioInsertBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadCriticaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNormalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioInsertarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idArticuloLabel
            // 
            idArticuloLabel.AutoSize = true;
            idArticuloLabel.Location = new System.Drawing.Point(7, 14);
            idArticuloLabel.Name = "idArticuloLabel";
            idArticuloLabel.Size = new System.Drawing.Size(21, 13);
            idArticuloLabel.TabIndex = 7;
            idArticuloLabel.Text = "ID:";
            // 
            // nombreArticuloLabel
            // 
            nombreArticuloLabel.AutoSize = true;
            nombreArticuloLabel.Location = new System.Drawing.Point(326, 15);
            nombreArticuloLabel.Name = "nombreArticuloLabel";
            nombreArticuloLabel.Size = new System.Drawing.Size(47, 13);
            nombreArticuloLabel.TabIndex = 8;
            nombreArticuloLabel.Text = "Artículo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(14, 50);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 15;
            descripcionLabel.Text = "Descripcion:";
            // 
            // idAreaLabel
            // 
            idAreaLabel.AutoSize = true;
            idAreaLabel.Location = new System.Drawing.Point(124, 17);
            idAreaLabel.Name = "idAreaLabel";
            idAreaLabel.Size = new System.Drawing.Size(32, 13);
            idAreaLabel.TabIndex = 23;
            idAreaLabel.Text = "Area:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(7, 78);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 24;
            cantidadLabel.Text = "Cantidad:";
            // 
            // idUnidadMedidaLabel
            // 
            idUnidadMedidaLabel.AutoSize = true;
            idUnidadMedidaLabel.Location = new System.Drawing.Point(155, 80);
            idUnidadMedidaLabel.Name = "idUnidadMedidaLabel";
            idUnidadMedidaLabel.Size = new System.Drawing.Size(44, 13);
            idUnidadMedidaLabel.TabIndex = 25;
            idUnidadMedidaLabel.Text = "Unidad:";
            // 
            // cantidadNormalLabel
            // 
            cantidadNormalLabel.AutoSize = true;
            cantidadNormalLabel.Location = new System.Drawing.Point(290, 80);
            cantidadNormalLabel.Name = "cantidadNormalLabel";
            cantidadNormalLabel.Size = new System.Drawing.Size(88, 13);
            cantidadNormalLabel.TabIndex = 26;
            cantidadNormalLabel.Text = "Cantidad Normal:";
            // 
            // cantidadCriticaLabel
            // 
            cantidadCriticaLabel.AutoSize = true;
            cantidadCriticaLabel.Location = new System.Drawing.Point(491, 81);
            cantidadCriticaLabel.Name = "cantidadCriticaLabel";
            cantidadCriticaLabel.Size = new System.Drawing.Size(84, 13);
            cantidadCriticaLabel.TabIndex = 27;
            cantidadCriticaLabel.Text = "Cantidad Critica:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnCerrarFormulario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 25);
            this.panel1.TabIndex = 4;
            // 
            // btnCerrarFormulario
            // 
            this.btnCerrarFormulario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarFormulario.Image")));
            this.btnCerrarFormulario.Location = new System.Drawing.Point(1, 2);
            this.btnCerrarFormulario.Name = "btnCerrarFormulario";
            this.btnCerrarFormulario.Size = new System.Drawing.Size(20, 20);
            this.btnCerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarFormulario.TabIndex = 1;
            this.btnCerrarFormulario.TabStop = false;
            this.btnCerrarFormulario.Click += new System.EventHandler(this.btnCerrarFormulario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insertar nuevo artículo";
            // 
            // inventarioInsertBindingSource
            // 
            this.inventarioInsertBindingSource.DataMember = "InventarioInsert";
            this.inventarioInsertBindingSource.DataSource = this.sCIDataSet;
            // 
            // sCIDataSet
            // 
            this.sCIDataSet.DataSetName = "SCIDataSet";
            this.sCIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unidadMedidaBindingSource
            // 
            this.unidadMedidaBindingSource.DataMember = "UnidadMedida";
            this.unidadMedidaBindingSource.DataSource = this.sCIDataSet;
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "Areas";
            this.areasBindingSource.DataSource = this.sCIDataSet;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 100);
            this.panel2.TabIndex = 7;
            // 
            // panelDGV
            // 
            this.panelDGV.Controls.Add(this.inventarioDataGridView);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGV.Location = new System.Drawing.Point(0, 125);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(896, 225);
            this.panelDGV.TabIndex = 8;
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
            this.inventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArea,
            this.IdArticulo,
            this.NombreArticulo,
            this.Descripcion,
            this.IdUnidadMedida,
            this.Cantidad,
            this.CantidadNormal,
            this.CantidadCritica});
            this.inventarioDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inventarioDataGridView.DataSource = this.inventarioInsertBindingSource;
            this.inventarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventarioDataGridView.Enabled = false;
            this.inventarioDataGridView.Location = new System.Drawing.Point(0, 0);
            this.inventarioDataGridView.Name = "inventarioDataGridView";
            this.inventarioDataGridView.ReadOnly = true;
            this.inventarioDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.inventarioDataGridView.RowHeadersVisible = false;
            this.inventarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventarioDataGridView.Size = new System.Drawing.Size(896, 225);
            this.inventarioDataGridView.TabIndex = 0;
            // 
            // IdArea
            // 
            this.IdArea.DataPropertyName = "IdArea";
            this.IdArea.HeaderText = "Area";
            this.IdArea.Name = "IdArea";
            this.IdArea.ReadOnly = true;
            this.IdArea.Width = 54;
            // 
            // IdArticulo
            // 
            this.IdArticulo.DataPropertyName = "IdArticulo";
            this.IdArticulo.HeaderText = "ID";
            this.IdArticulo.Name = "IdArticulo";
            this.IdArticulo.ReadOnly = true;
            this.IdArticulo.Width = 43;
            // 
            // NombreArticulo
            // 
            this.NombreArticulo.DataPropertyName = "NombreArticulo";
            this.NombreArticulo.HeaderText = "Artículo";
            this.NombreArticulo.Name = "NombreArticulo";
            this.NombreArticulo.ReadOnly = true;
            this.NombreArticulo.Width = 69;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 88;
            // 
            // IdUnidadMedida
            // 
            this.IdUnidadMedida.DataPropertyName = "IdUnidadMedida";
            this.IdUnidadMedida.HeaderText = "Medida";
            this.IdUnidadMedida.Name = "IdUnidadMedida";
            this.IdUnidadMedida.ReadOnly = true;
            this.IdUnidadMedida.Width = 67;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad ingresada";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 113;
            // 
            // CantidadNormal
            // 
            this.CantidadNormal.DataPropertyName = "CantidadNormal";
            this.CantidadNormal.HeaderText = "CantidadNormal";
            this.CantidadNormal.Name = "CantidadNormal";
            this.CantidadNormal.ReadOnly = true;
            this.CantidadNormal.Width = 107;
            // 
            // CantidadCritica
            // 
            this.CantidadCritica.DataPropertyName = "CantidadCritica";
            this.CantidadCritica.HeaderText = "CantidadCritica";
            this.CantidadCritica.Name = "CantidadCritica";
            this.CantidadCritica.ReadOnly = true;
            this.CantidadCritica.Width = 103;
            // 
            // inventarioInsertTableAdapter
            // 
            this.inventarioInsertTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Inventario11111TableAdapter = null;
            this.tableAdapterManager.Inventario1111TableAdapter = null;
            this.tableAdapterManager.Inventario111TableAdapter = null;
            this.tableAdapterManager.Inventario11TableAdapter = null;
            this.tableAdapterManager.Inventario1TableAdapter = null;
            this.tableAdapterManager.Inventario2TableAdapter = null;
            this.tableAdapterManager.InventarioInsertarTableAdapter = null;
            this.tableAdapterManager.InventarioInsertTableAdapter = this.inventarioInsertTableAdapter;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.UnidadMedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SCI1.SCIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // unidadMedidaTableAdapter
            // 
            this.unidadMedidaTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // idArticuloTextBox
            // 
            this.idArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioInsertBindingSource, "IdArticulo", true));
            this.idArticuloTextBox.Enabled = false;
            this.idArticuloTextBox.Location = new System.Drawing.Point(34, 11);
            this.idArticuloTextBox.Name = "idArticuloTextBox";
            this.idArticuloTextBox.ReadOnly = true;
            this.idArticuloTextBox.Size = new System.Drawing.Size(84, 20);
            this.idArticuloTextBox.TabIndex = 8;
            // 
            // nombreArticuloTextBox
            // 
            this.nombreArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioInsertBindingSource, "NombreArticulo", true));
            this.nombreArticuloTextBox.Location = new System.Drawing.Point(379, 13);
            this.nombreArticuloTextBox.Name = "nombreArticuloTextBox";
            this.nombreArticuloTextBox.Size = new System.Drawing.Size(280, 20);
            this.nombreArticuloTextBox.TabIndex = 9;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioInsertBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(86, 47);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(573, 20);
            this.descripcionTextBox.TabIndex = 16;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("BtnInsertar.Image")));
            this.BtnInsertar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnInsertar.Location = new System.Drawing.Point(665, 6);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(70, 70);
            this.BtnInsertar.TabIndex = 21;
            this.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(741, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 70);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(817, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 70);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(cantidadCriticaLabel);
            this.panelBotones.Controls.Add(this.cantidadCriticaNumericUpDown);
            this.panelBotones.Controls.Add(cantidadNormalLabel);
            this.panelBotones.Controls.Add(this.cantidadNormalNumericUpDown);
            this.panelBotones.Controls.Add(idUnidadMedidaLabel);
            this.panelBotones.Controls.Add(this.idUnidadMedidaComboBox);
            this.panelBotones.Controls.Add(cantidadLabel);
            this.panelBotones.Controls.Add(this.cantidadNumericUpDown);
            this.panelBotones.Controls.Add(idAreaLabel);
            this.panelBotones.Controls.Add(this.idAreaComboBox);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.BtnInsertar);
            this.panelBotones.Controls.Add(descripcionLabel);
            this.panelBotones.Controls.Add(this.descripcionTextBox);
            this.panelBotones.Controls.Add(nombreArticuloLabel);
            this.panelBotones.Controls.Add(this.nombreArticuloTextBox);
            this.panelBotones.Controls.Add(idArticuloLabel);
            this.panelBotones.Controls.Add(this.idArticuloTextBox);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 350);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(896, 100);
            this.panelBotones.TabIndex = 6;
            // 
            // cantidadCriticaNumericUpDown
            // 
            this.cantidadCriticaNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventarioInsertBindingSource, "CantidadCritica", true));
            this.cantidadCriticaNumericUpDown.Location = new System.Drawing.Point(581, 77);
            this.cantidadCriticaNumericUpDown.Name = "cantidadCriticaNumericUpDown";
            this.cantidadCriticaNumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.cantidadCriticaNumericUpDown.TabIndex = 28;
            // 
            // cantidadNormalNumericUpDown
            // 
            this.cantidadNormalNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventarioInsertBindingSource, "CantidadNormal", true));
            this.cantidadNormalNumericUpDown.Location = new System.Drawing.Point(384, 77);
            this.cantidadNormalNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.cantidadNormalNumericUpDown.Name = "cantidadNormalNumericUpDown";
            this.cantidadNormalNumericUpDown.Size = new System.Drawing.Size(95, 20);
            this.cantidadNormalNumericUpDown.TabIndex = 27;
            // 
            // idUnidadMedidaComboBox
            // 
            this.idUnidadMedidaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioInsertBindingSource, "IdUnidadMedida", true));
            this.idUnidadMedidaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idUnidadMedidaComboBox.FormattingEnabled = true;
            this.idUnidadMedidaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.idUnidadMedidaComboBox.Location = new System.Drawing.Point(205, 76);
            this.idUnidadMedidaComboBox.Name = "idUnidadMedidaComboBox";
            this.idUnidadMedidaComboBox.Size = new System.Drawing.Size(79, 21);
            this.idUnidadMedidaComboBox.TabIndex = 26;
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventarioInsertBindingSource, "Cantidad", true));
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(65, 78);
            this.cantidadNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(76, 20);
            this.cantidadNumericUpDown.TabIndex = 25;
            // 
            // idAreaComboBox
            // 
            this.idAreaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioInsertBindingSource, "IdArea", true));
            this.idAreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idAreaComboBox.FormattingEnabled = true;
            this.idAreaComboBox.Items.AddRange(new object[] {
            "CIS",
            "ITN",
            "MNT",
            "SGR",
            "LBC",
            "AMT"});
            this.idAreaComboBox.Location = new System.Drawing.Point(157, 13);
            this.idAreaComboBox.Name = "idAreaComboBox";
            this.idAreaComboBox.Size = new System.Drawing.Size(163, 21);
            this.idAreaComboBox.TabIndex = 24;
            // 
            // inventarioInsertarBindingSource
            // 
            this.inventarioInsertarBindingSource.DataMember = "InventarioInsertar";
            this.inventarioInsertarBindingSource.DataSource = this.sCIDataSet;
            // 
            // inventarioInsertarTableAdapter
            // 
            this.inventarioInsertarTableAdapter.ClearBeforeFill = true;
            // 
            // InsertarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.panelDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertarInventario";
            this.Text = "InsertarInventario";
            this.Load += new System.EventHandler(this.InsertarInventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioInsertBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            this.panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadCriticaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNormalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioInsertarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrarFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.DataGridView inventarioDataGridView;
        private SCIDataSet sCIDataSet;
        private System.Windows.Forms.BindingSource inventarioInsertBindingSource;
        private SCIDataSetTableAdapters.InventarioInsertTableAdapter inventarioInsertTableAdapter;
        private SCIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private SCIDataSetTableAdapters.AreasTableAdapter areasTableAdapter;
        private System.Windows.Forms.BindingSource unidadMedidaBindingSource;
        private SCIDataSetTableAdapters.UnidadMedidaTableAdapter unidadMedidaTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombreArticuloTextBox;
        private System.Windows.Forms.TextBox idArticuloTextBox;
        private System.Windows.Forms.BindingSource inventarioInsertarBindingSource;
        private SCIDataSetTableAdapters.InventarioInsertarTableAdapter inventarioInsertarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCritica;
        private System.Windows.Forms.NumericUpDown cantidadCriticaNumericUpDown;
        private System.Windows.Forms.NumericUpDown cantidadNormalNumericUpDown;
        private System.Windows.Forms.ComboBox idUnidadMedidaComboBox;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.ComboBox idAreaComboBox;
    }
}