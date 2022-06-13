
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label cantidadCriticaLabel;
            System.Windows.Forms.Label cantidadNormalLabel;
            System.Windows.Forms.Label idUnidadMedidaLabel;
            System.Windows.Forms.Label nombreArticuloLabel;
            System.Windows.Forms.Label idArticuloLabel;
            System.Windows.Forms.Label idAreaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioITN));
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnCancelarI = new System.Windows.Forms.Button();
            this.btnGuardarI = new System.Windows.Forms.Button();
            this.BtnEditarI = new System.Windows.Forms.Button();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.inventario1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCIDataSet = new SCI1.SCIDataSet();
            this.cantidadCriticaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cantidadNormalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idUnidadMedidaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nombreArticuloTextBox = new System.Windows.Forms.TextBox();
            this.idArticuloTextBox = new System.Windows.Forms.TextBox();
            this.idAreaTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarFormulario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.inventario1TableAdapter = new SCI1.SCIDataSetTableAdapters.Inventario1TableAdapter();
            this.tableAdapterManager = new SCI1.SCIDataSetTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            descripcionLabel = new System.Windows.Forms.Label();
            cantidadCriticaLabel = new System.Windows.Forms.Label();
            cantidadNormalLabel = new System.Windows.Forms.Label();
            idUnidadMedidaLabel = new System.Windows.Forms.Label();
            nombreArticuloLabel = new System.Windows.Forms.Label();
            idArticuloLabel = new System.Windows.Forms.Label();
            idAreaLabel = new System.Windows.Forms.Label();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventario1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadCriticaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNormalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idUnidadMedidaNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).BeginInit();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // cantidadCriticaLabel
            // 
            cantidadCriticaLabel.AutoSize = true;
            cantidadCriticaLabel.Location = new System.Drawing.Point(449, 78);
            cantidadCriticaLabel.Name = "cantidadCriticaLabel";
            cantidadCriticaLabel.Size = new System.Drawing.Size(84, 13);
            cantidadCriticaLabel.TabIndex = 13;
            cantidadCriticaLabel.Text = "Cantidad Critica:";
            // 
            // cantidadNormalLabel
            // 
            cantidadNormalLabel.AutoSize = true;
            cantidadNormalLabel.Location = new System.Drawing.Point(216, 78);
            cantidadNormalLabel.Name = "cantidadNormalLabel";
            cantidadNormalLabel.Size = new System.Drawing.Size(88, 13);
            cantidadNormalLabel.TabIndex = 11;
            cantidadNormalLabel.Text = "Cantidad Normal:";
            // 
            // idUnidadMedidaLabel
            // 
            idUnidadMedidaLabel.AutoSize = true;
            idUnidadMedidaLabel.Location = new System.Drawing.Point(25, 78);
            idUnidadMedidaLabel.Name = "idUnidadMedidaLabel";
            idUnidadMedidaLabel.Size = new System.Drawing.Size(45, 13);
            idUnidadMedidaLabel.TabIndex = 9;
            idUnidadMedidaLabel.Text = "Medida:";
            // 
            // nombreArticuloLabel
            // 
            nombreArticuloLabel.AutoSize = true;
            nombreArticuloLabel.Location = new System.Drawing.Point(277, 16);
            nombreArticuloLabel.Name = "nombreArticuloLabel";
            nombreArticuloLabel.Size = new System.Drawing.Size(47, 13);
            nombreArticuloLabel.TabIndex = 8;
            nombreArticuloLabel.Text = "Artículo:";
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
            // idAreaLabel
            // 
            idAreaLabel.AutoSize = true;
            idAreaLabel.Location = new System.Drawing.Point(150, 16);
            idAreaLabel.Name = "idAreaLabel";
            idAreaLabel.Size = new System.Drawing.Size(32, 13);
            idAreaLabel.TabIndex = 6;
            idAreaLabel.Text = "Area:";
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnCancelarI);
            this.panelBotones.Controls.Add(this.btnGuardarI);
            this.panelBotones.Controls.Add(this.BtnEditarI);
            this.panelBotones.Controls.Add(descripcionLabel);
            this.panelBotones.Controls.Add(this.descripcionTextBox);
            this.panelBotones.Controls.Add(cantidadCriticaLabel);
            this.panelBotones.Controls.Add(this.cantidadCriticaNumericUpDown);
            this.panelBotones.Controls.Add(cantidadNormalLabel);
            this.panelBotones.Controls.Add(this.cantidadNormalNumericUpDown);
            this.panelBotones.Controls.Add(idUnidadMedidaLabel);
            this.panelBotones.Controls.Add(this.idUnidadMedidaNumericUpDown);
            this.panelBotones.Controls.Add(nombreArticuloLabel);
            this.panelBotones.Controls.Add(this.nombreArticuloTextBox);
            this.panelBotones.Controls.Add(idArticuloLabel);
            this.panelBotones.Controls.Add(this.idArticuloTextBox);
            this.panelBotones.Controls.Add(idAreaLabel);
            this.panelBotones.Controls.Add(this.idAreaTextBox);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 688);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1100, 100);
            this.panelBotones.TabIndex = 3;
            // 
            // btnCancelarI
            // 
            this.btnCancelarI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarI.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarI.Image")));
            this.btnCancelarI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarI.Location = new System.Drawing.Point(1020, 13);
            this.btnCancelarI.Name = "btnCancelarI";
            this.btnCancelarI.Size = new System.Drawing.Size(70, 70);
            this.btnCancelarI.TabIndex = 23;
            this.btnCancelarI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarI.UseVisualStyleBackColor = true;
            this.btnCancelarI.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarI
            // 
            this.btnGuardarI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarI.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarI.Image")));
            this.btnGuardarI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarI.Location = new System.Drawing.Point(944, 13);
            this.btnGuardarI.Name = "btnGuardarI";
            this.btnGuardarI.Size = new System.Drawing.Size(70, 70);
            this.btnGuardarI.TabIndex = 22;
            this.btnGuardarI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarI.UseVisualStyleBackColor = true;
            this.btnGuardarI.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnEditarI
            // 
            this.BtnEditarI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditarI.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditarI.Image")));
            this.BtnEditarI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEditarI.Location = new System.Drawing.Point(868, 13);
            this.BtnEditarI.Name = "BtnEditarI";
            this.BtnEditarI.Size = new System.Drawing.Size(70, 70);
            this.BtnEditarI.TabIndex = 21;
            this.BtnEditarI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditarI.UseVisualStyleBackColor = true;
            this.BtnEditarI.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventario1BindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(86, 47);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(573, 20);
            this.descripcionTextBox.TabIndex = 16;
            // 
            // inventario1BindingSource
            // 
            this.inventario1BindingSource.DataMember = "Inventario1";
            this.inventario1BindingSource.DataSource = this.sCIDataSet;
            // 
            // sCIDataSet
            // 
            this.sCIDataSet.DataSetName = "SCIDataSet";
            this.sCIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cantidadCriticaNumericUpDown
            // 
            this.cantidadCriticaNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventario1BindingSource, "CantidadCritica", true));
            this.cantidadCriticaNumericUpDown.Location = new System.Drawing.Point(539, 78);
            this.cantidadCriticaNumericUpDown.Name = "cantidadCriticaNumericUpDown";
            this.cantidadCriticaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadCriticaNumericUpDown.TabIndex = 14;
            // 
            // cantidadNormalNumericUpDown
            // 
            this.cantidadNormalNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventario1BindingSource, "CantidadNormal", true));
            this.cantidadNormalNumericUpDown.Location = new System.Drawing.Point(310, 78);
            this.cantidadNormalNumericUpDown.Name = "cantidadNormalNumericUpDown";
            this.cantidadNormalNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadNormalNumericUpDown.TabIndex = 12;
            // 
            // idUnidadMedidaNumericUpDown
            // 
            this.idUnidadMedidaNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventario1BindingSource, "IdUnidadMedida", true));
            this.idUnidadMedidaNumericUpDown.Location = new System.Drawing.Point(76, 76);
            this.idUnidadMedidaNumericUpDown.Name = "idUnidadMedidaNumericUpDown";
            this.idUnidadMedidaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.idUnidadMedidaNumericUpDown.TabIndex = 10;
            // 
            // nombreArticuloTextBox
            // 
            this.nombreArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventario1BindingSource, "NombreArticulo", true));
            this.nombreArticuloTextBox.Location = new System.Drawing.Point(330, 13);
            this.nombreArticuloTextBox.Name = "nombreArticuloTextBox";
            this.nombreArticuloTextBox.Size = new System.Drawing.Size(329, 20);
            this.nombreArticuloTextBox.TabIndex = 9;
            // 
            // idArticuloTextBox
            // 
            this.idArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventario1BindingSource, "IdArticulo", true));
            this.idArticuloTextBox.Enabled = false;
            this.idArticuloTextBox.Location = new System.Drawing.Point(34, 11);
            this.idArticuloTextBox.Name = "idArticuloTextBox";
            this.idArticuloTextBox.Size = new System.Drawing.Size(100, 20);
            this.idArticuloTextBox.TabIndex = 8;
            // 
            // idAreaTextBox
            // 
            this.idAreaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventario1BindingSource, "IdArea", true));
            this.idAreaTextBox.Location = new System.Drawing.Point(188, 12);
            this.idAreaTextBox.Name = "idAreaTextBox";
            this.idAreaTextBox.Size = new System.Drawing.Size(75, 20);
            this.idAreaTextBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnCerrarFormulario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 25);
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
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intendencia";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 100);
            this.panel2.TabIndex = 5;
            // 
            // panelDGV
            // 
            this.panelDGV.Controls.Add(this.inventarioDataGridView);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGV.Location = new System.Drawing.Point(0, 125);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(1100, 563);
            this.panelDGV.TabIndex = 6;
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
            this.idAreaDataGridViewTextBoxColumn,
            this.idArticuloDataGridViewTextBoxColumn,
            this.nombreArticuloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.idUnidadMedidaDataGridViewTextBoxColumn,
            this.cantidadNormalDataGridViewTextBoxColumn,
            this.cantidadCriticaDataGridViewTextBoxColumn});
            this.inventarioDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inventarioDataGridView.DataSource = this.inventario1BindingSource;
            this.inventarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventarioDataGridView.Location = new System.Drawing.Point(0, 0);
            this.inventarioDataGridView.Name = "inventarioDataGridView";
            this.inventarioDataGridView.ReadOnly = true;
            this.inventarioDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.inventarioDataGridView.RowHeadersVisible = false;
            this.inventarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventarioDataGridView.Size = new System.Drawing.Size(1100, 563);
            this.inventarioDataGridView.TabIndex = 0;
            // 
            // idAreaDataGridViewTextBoxColumn
            // 
            this.idAreaDataGridViewTextBoxColumn.DataPropertyName = "IdArea";
            this.idAreaDataGridViewTextBoxColumn.HeaderText = "IdArea";
            this.idAreaDataGridViewTextBoxColumn.Name = "idAreaDataGridViewTextBoxColumn";
            this.idAreaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAreaDataGridViewTextBoxColumn.Width = 63;
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            this.idArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArticuloDataGridViewTextBoxColumn.Width = 76;
            // 
            // nombreArticuloDataGridViewTextBoxColumn
            // 
            this.nombreArticuloDataGridViewTextBoxColumn.DataPropertyName = "NombreArticulo";
            this.nombreArticuloDataGridViewTextBoxColumn.HeaderText = "NombreArticulo";
            this.nombreArticuloDataGridViewTextBoxColumn.Name = "nombreArticuloDataGridViewTextBoxColumn";
            this.nombreArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreArticuloDataGridViewTextBoxColumn.Width = 104;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 88;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 74;
            // 
            // idUnidadMedidaDataGridViewTextBoxColumn
            // 
            this.idUnidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "IdUnidadMedida";
            this.idUnidadMedidaDataGridViewTextBoxColumn.HeaderText = "IdUnidadMedida";
            this.idUnidadMedidaDataGridViewTextBoxColumn.Name = "idUnidadMedidaDataGridViewTextBoxColumn";
            this.idUnidadMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUnidadMedidaDataGridViewTextBoxColumn.Width = 110;
            // 
            // cantidadNormalDataGridViewTextBoxColumn
            // 
            this.cantidadNormalDataGridViewTextBoxColumn.DataPropertyName = "CantidadNormal";
            this.cantidadNormalDataGridViewTextBoxColumn.HeaderText = "CantidadNormal";
            this.cantidadNormalDataGridViewTextBoxColumn.Name = "cantidadNormalDataGridViewTextBoxColumn";
            this.cantidadNormalDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadNormalDataGridViewTextBoxColumn.Width = 107;
            // 
            // cantidadCriticaDataGridViewTextBoxColumn
            // 
            this.cantidadCriticaDataGridViewTextBoxColumn.DataPropertyName = "CantidadCritica";
            this.cantidadCriticaDataGridViewTextBoxColumn.HeaderText = "CantidadCritica";
            this.cantidadCriticaDataGridViewTextBoxColumn.Name = "cantidadCriticaDataGridViewTextBoxColumn";
            this.cantidadCriticaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadCriticaDataGridViewTextBoxColumn.Width = 103;
            // 
            // inventario1TableAdapter
            // 
            this.inventario1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Inventario1TableAdapter = this.inventario1TableAdapter;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.UnidadMedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SCI1.SCIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InventarioITN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 788);
            this.Controls.Add(this.panelDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventarioITN";
            this.Text = "InventarioITN";
            this.Load += new System.EventHandler(this.InventarioITN_Load);
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventario1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadCriticaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNormalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idUnidadMedidaNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).EndInit();
            this.panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnCancelarI;
        private System.Windows.Forms.Button btnGuardarI;
        private System.Windows.Forms.Button BtnEditarI;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.NumericUpDown cantidadCriticaNumericUpDown;
        private System.Windows.Forms.NumericUpDown cantidadNormalNumericUpDown;
        private System.Windows.Forms.NumericUpDown idUnidadMedidaNumericUpDown;
        private System.Windows.Forms.TextBox nombreArticuloTextBox;
        private System.Windows.Forms.TextBox idArticuloTextBox;
        private System.Windows.Forms.TextBox idAreaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrarFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.DataGridView inventarioDataGridView;
        private SCIDataSet sCIDataSet;
        private System.Windows.Forms.BindingSource inventario1BindingSource;
        private SCIDataSetTableAdapters.Inventario1TableAdapter inventario1TableAdapter;
        private SCIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadNormalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCriticaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}