﻿
namespace SCI1
{
    partial class InventarioLBC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioLBC));
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label cantidadCriticaLabel;
            System.Windows.Forms.Label cantidadNormalLabel;
            System.Windows.Forms.Label idUnidadMedidaLabel;
            System.Windows.Forms.Label nombreArticuloLabel;
            System.Windows.Forms.Label idArticuloLabel;
            System.Windows.Forms.Label idAreaLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarFormulario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.cantidadCriticaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cantidadNormalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idUnidadMedidaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nombreArticuloTextBox = new System.Windows.Forms.TextBox();
            this.idArticuloTextBox = new System.Windows.Forms.TextBox();
            this.idAreaTextBox = new System.Windows.Forms.TextBox();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.inventarioDataGridView = new System.Windows.Forms.DataGridView();
            this.sCIDataSet = new SCI1.SCIDataSet();
            this.inventario1111BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventario1111TableAdapter = new SCI1.SCIDataSetTableAdapters.Inventario1111TableAdapter();
            this.tableAdapterManager = new SCI1.SCIDataSetTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadNormalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCriticaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descripcionLabel = new System.Windows.Forms.Label();
            cantidadCriticaLabel = new System.Windows.Forms.Label();
            cantidadNormalLabel = new System.Windows.Forms.Label();
            idUnidadMedidaLabel = new System.Windows.Forms.Label();
            nombreArticuloLabel = new System.Windows.Forms.Label();
            idArticuloLabel = new System.Windows.Forms.Label();
            idAreaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).BeginInit();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadCriticaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNormalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idUnidadMedidaNumericUpDown)).BeginInit();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario1111BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnCerrarFormulario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 25);
            this.panel1.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laboratorio de cómputo";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 100);
            this.panel2.TabIndex = 4;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.BtnEditar);
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
            this.panelBotones.Location = new System.Drawing.Point(0, 649);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1084, 100);
            this.panelBotones.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(1004, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 70);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(928, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 70);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEditar.Location = new System.Drawing.Point(852, 13);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(70, 70);
            this.BtnEditar.TabIndex = 21;
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
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
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventario1111BindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(86, 47);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(573, 20);
            this.descripcionTextBox.TabIndex = 16;
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
            // cantidadCriticaNumericUpDown
            // 
            this.cantidadCriticaNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventario1111BindingSource, "CantidadCritica", true));
            this.cantidadCriticaNumericUpDown.Location = new System.Drawing.Point(539, 78);
            this.cantidadCriticaNumericUpDown.Name = "cantidadCriticaNumericUpDown";
            this.cantidadCriticaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadCriticaNumericUpDown.TabIndex = 14;
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
            // cantidadNormalNumericUpDown
            // 
            this.cantidadNormalNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventario1111BindingSource, "CantidadNormal", true));
            this.cantidadNormalNumericUpDown.Location = new System.Drawing.Point(310, 78);
            this.cantidadNormalNumericUpDown.Name = "cantidadNormalNumericUpDown";
            this.cantidadNormalNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadNormalNumericUpDown.TabIndex = 12;
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
            // idUnidadMedidaNumericUpDown
            // 
            this.idUnidadMedidaNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventario1111BindingSource, "IdUnidadMedida", true));
            this.idUnidadMedidaNumericUpDown.Location = new System.Drawing.Point(76, 76);
            this.idUnidadMedidaNumericUpDown.Name = "idUnidadMedidaNumericUpDown";
            this.idUnidadMedidaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.idUnidadMedidaNumericUpDown.TabIndex = 10;
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
            // nombreArticuloTextBox
            // 
            this.nombreArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventario1111BindingSource, "NombreArticulo", true));
            this.nombreArticuloTextBox.Location = new System.Drawing.Point(330, 13);
            this.nombreArticuloTextBox.Name = "nombreArticuloTextBox";
            this.nombreArticuloTextBox.Size = new System.Drawing.Size(329, 20);
            this.nombreArticuloTextBox.TabIndex = 9;
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
            // idArticuloTextBox
            // 
            this.idArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventario1111BindingSource, "IdArticulo", true));
            this.idArticuloTextBox.Enabled = false;
            this.idArticuloTextBox.Location = new System.Drawing.Point(34, 11);
            this.idArticuloTextBox.Name = "idArticuloTextBox";
            this.idArticuloTextBox.ReadOnly = true;
            this.idArticuloTextBox.Size = new System.Drawing.Size(100, 20);
            this.idArticuloTextBox.TabIndex = 8;
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
            // idAreaTextBox
            // 
            this.idAreaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventario1111BindingSource, "IdArea", true));
            this.idAreaTextBox.Location = new System.Drawing.Point(188, 12);
            this.idAreaTextBox.Name = "idAreaTextBox";
            this.idAreaTextBox.Size = new System.Drawing.Size(75, 20);
            this.idAreaTextBox.TabIndex = 7;
            // 
            // panelDGV
            // 
            this.panelDGV.Controls.Add(this.inventarioDataGridView);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGV.Location = new System.Drawing.Point(0, 125);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(1084, 524);
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
            this.idUnidadMedidaDataGridViewTextBoxColumn,
            this.cantidadNormalDataGridViewTextBoxColumn,
            this.cantidadCriticaDataGridViewTextBoxColumn});
            this.inventarioDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inventarioDataGridView.DataSource = this.inventario1111BindingSource;
            this.inventarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventarioDataGridView.Location = new System.Drawing.Point(0, 0);
            this.inventarioDataGridView.Name = "inventarioDataGridView";
            this.inventarioDataGridView.ReadOnly = true;
            this.inventarioDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.inventarioDataGridView.RowHeadersVisible = false;
            this.inventarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventarioDataGridView.Size = new System.Drawing.Size(1084, 524);
            this.inventarioDataGridView.TabIndex = 0;
            // 
            // sCIDataSet
            // 
            this.sCIDataSet.DataSetName = "SCIDataSet";
            this.sCIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventario1111BindingSource
            // 
            this.inventario1111BindingSource.DataMember = "Inventario1111";
            this.inventario1111BindingSource.DataSource = this.sCIDataSet;
            // 
            // inventario1111TableAdapter
            // 
            this.inventario1111TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Inventario11111TableAdapter = null;
            this.tableAdapterManager.Inventario1111TableAdapter = this.inventario1111TableAdapter;
            this.tableAdapterManager.Inventario111TableAdapter = null;
            this.tableAdapterManager.Inventario11TableAdapter = null;
            this.tableAdapterManager.Inventario1TableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.UnidadMedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SCI1.SCIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // idAreaDataGridViewTextBoxColumn
            // 
            this.idAreaDataGridViewTextBoxColumn.DataPropertyName = "IdArea";
            this.idAreaDataGridViewTextBoxColumn.HeaderText = "Área";
            this.idAreaDataGridViewTextBoxColumn.Name = "idAreaDataGridViewTextBoxColumn";
            this.idAreaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAreaDataGridViewTextBoxColumn.Width = 54;
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            this.idArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArticuloDataGridViewTextBoxColumn.Width = 43;
            // 
            // nombreArticuloDataGridViewTextBoxColumn
            // 
            this.nombreArticuloDataGridViewTextBoxColumn.DataPropertyName = "NombreArticulo";
            this.nombreArticuloDataGridViewTextBoxColumn.HeaderText = "Artículo";
            this.nombreArticuloDataGridViewTextBoxColumn.Name = "nombreArticuloDataGridViewTextBoxColumn";
            this.nombreArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreArticuloDataGridViewTextBoxColumn.Width = 69;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 88;
            // 
            // idUnidadMedidaDataGridViewTextBoxColumn
            // 
            this.idUnidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "IdUnidadMedida";
            this.idUnidadMedidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.idUnidadMedidaDataGridViewTextBoxColumn.Name = "idUnidadMedidaDataGridViewTextBoxColumn";
            this.idUnidadMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUnidadMedidaDataGridViewTextBoxColumn.Width = 67;
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
            // InventarioLBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.panelDGV);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventarioLBC";
            this.Text = "InventarioLBC";
            this.Load += new System.EventHandler(this.InventarioLBC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadCriticaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNormalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idUnidadMedidaNumericUpDown)).EndInit();
            this.panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario1111BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrarFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.NumericUpDown cantidadCriticaNumericUpDown;
        private System.Windows.Forms.NumericUpDown cantidadNormalNumericUpDown;
        private System.Windows.Forms.NumericUpDown idUnidadMedidaNumericUpDown;
        private System.Windows.Forms.TextBox nombreArticuloTextBox;
        private System.Windows.Forms.TextBox idArticuloTextBox;
        private System.Windows.Forms.TextBox idAreaTextBox;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.DataGridView inventarioDataGridView;
        private SCIDataSet sCIDataSet;
        private System.Windows.Forms.BindingSource inventario1111BindingSource;
        private SCIDataSetTableAdapters.Inventario1111TableAdapter inventario1111TableAdapter;
        private SCIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadNormalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCriticaDataGridViewTextBoxColumn;
    }
}