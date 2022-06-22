namespace SCI1
{
    partial class AñadirStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirStock));
            System.Windows.Forms.Label idArticuloLabel1;
            System.Windows.Forms.Label idAreaLabel;
            System.Windows.Forms.Label nombreArticuloLabel1;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label descripcionLabel;
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.sCIDataSet = new SCI1.SCIDataSet();
            this.añadirStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.añadirStockTableAdapter = new SCI1.SCIDataSetTableAdapters.AñadirStockTableAdapter();
            this.tableAdapterManager = new SCI1.SCIDataSetTableAdapters.TableAdapterManager();
            this.idArticuloTextBox = new System.Windows.Forms.TextBox();
            this.idAreaTextBox = new System.Windows.Forms.TextBox();
            this.nombreArticuloTextBox = new System.Windows.Forms.TextBox();
            this.añadirStockDataGridView = new System.Windows.Forms.DataGridView();
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarFormulario = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            idArticuloLabel1 = new System.Windows.Forms.Label();
            idAreaLabel = new System.Windows.Forms.Label();
            nombreArticuloLabel1 = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            this.panelBotones.SuspendLayout();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.añadirStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.añadirStockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(descripcionLabel);
            this.panelBotones.Controls.Add(this.descripcionTextBox);
            this.panelBotones.Controls.Add(cantidadLabel);
            this.panelBotones.Controls.Add(this.cantidadNumericUpDown);
            this.panelBotones.Controls.Add(nombreArticuloLabel1);
            this.panelBotones.Controls.Add(this.nombreArticuloTextBox);
            this.panelBotones.Controls.Add(idAreaLabel);
            this.panelBotones.Controls.Add(this.idAreaTextBox);
            this.panelBotones.Controls.Add(idArticuloLabel1);
            this.panelBotones.Controls.Add(this.idArticuloTextBox);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.BtnInsertar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 349);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(896, 101);
            this.panelBotones.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(804, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 70);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(728, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 70);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("BtnInsertar.Image")));
            this.BtnInsertar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnInsertar.Location = new System.Drawing.Point(652, 14);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(70, 70);
            this.BtnInsertar.TabIndex = 31;
            this.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // panelDGV
            // 
            this.panelDGV.Controls.Add(this.añadirStockDataGridView);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGV.Location = new System.Drawing.Point(0, 125);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(896, 224);
            this.panelDGV.TabIndex = 11;
            // 
            // sCIDataSet
            // 
            this.sCIDataSet.DataSetName = "SCIDataSet";
            this.sCIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // añadirStockBindingSource
            // 
            this.añadirStockBindingSource.DataMember = "AñadirStock";
            this.añadirStockBindingSource.DataSource = this.sCIDataSet;
            // 
            // añadirStockTableAdapter
            // 
            this.añadirStockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AñadirStockTableAdapter = this.añadirStockTableAdapter;
            this.tableAdapterManager.AreasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Inventario11111TableAdapter = null;
            this.tableAdapterManager.Inventario1111TableAdapter = null;
            this.tableAdapterManager.Inventario111TableAdapter = null;
            this.tableAdapterManager.Inventario11TableAdapter = null;
            this.tableAdapterManager.Inventario1TableAdapter = null;
            this.tableAdapterManager.Inventario2TableAdapter = null;
            this.tableAdapterManager.InventarioInsertarTableAdapter = null;
            this.tableAdapterManager.InventarioInsertTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.UnidadMedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SCI1.SCIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // idArticuloLabel1
            // 
            idArticuloLabel1.AutoSize = true;
            idArticuloLabel1.Location = new System.Drawing.Point(112, 17);
            idArticuloLabel1.Name = "idArticuloLabel1";
            idArticuloLabel1.Size = new System.Drawing.Size(57, 13);
            idArticuloLabel1.TabIndex = 33;
            idArticuloLabel1.Text = "Id Articulo:";
            // 
            // idArticuloTextBox
            // 
            this.idArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.añadirStockBindingSource, "IdArticulo", true));
            this.idArticuloTextBox.Location = new System.Drawing.Point(175, 14);
            this.idArticuloTextBox.Name = "idArticuloTextBox";
            this.idArticuloTextBox.Size = new System.Drawing.Size(100, 20);
            this.idArticuloTextBox.TabIndex = 34;
            // 
            // idAreaLabel
            // 
            idAreaLabel.AutoSize = true;
            idAreaLabel.Location = new System.Drawing.Point(4, 17);
            idAreaLabel.Name = "idAreaLabel";
            idAreaLabel.Size = new System.Drawing.Size(44, 13);
            idAreaLabel.TabIndex = 34;
            idAreaLabel.Text = "Id Area:";
            // 
            // idAreaTextBox
            // 
            this.idAreaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.añadirStockBindingSource, "IdArea", true));
            this.idAreaTextBox.Location = new System.Drawing.Point(54, 14);
            this.idAreaTextBox.Name = "idAreaTextBox";
            this.idAreaTextBox.Size = new System.Drawing.Size(53, 20);
            this.idAreaTextBox.TabIndex = 35;
            // 
            // nombreArticuloLabel1
            // 
            nombreArticuloLabel1.AutoSize = true;
            nombreArticuloLabel1.Location = new System.Drawing.Point(283, 20);
            nombreArticuloLabel1.Name = "nombreArticuloLabel1";
            nombreArticuloLabel1.Size = new System.Drawing.Size(85, 13);
            nombreArticuloLabel1.TabIndex = 35;
            nombreArticuloLabel1.Text = "Nombre Articulo:";
            // 
            // nombreArticuloTextBox
            // 
            this.nombreArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.añadirStockBindingSource, "NombreArticulo", true));
            this.nombreArticuloTextBox.Location = new System.Drawing.Point(374, 17);
            this.nombreArticuloTextBox.Name = "nombreArticuloTextBox";
            this.nombreArticuloTextBox.Size = new System.Drawing.Size(272, 20);
            this.nombreArticuloTextBox.TabIndex = 36;
            // 
            // añadirStockDataGridView
            // 
            this.añadirStockDataGridView.AllowUserToAddRows = false;
            this.añadirStockDataGridView.AllowUserToDeleteRows = false;
            this.añadirStockDataGridView.AllowUserToOrderColumns = true;
            this.añadirStockDataGridView.AutoGenerateColumns = false;
            this.añadirStockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.añadirStockDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.añadirStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.añadirStockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Cantidad,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.añadirStockDataGridView.DataSource = this.añadirStockBindingSource;
            this.añadirStockDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.añadirStockDataGridView.Location = new System.Drawing.Point(0, 0);
            this.añadirStockDataGridView.Name = "añadirStockDataGridView";
            this.añadirStockDataGridView.ReadOnly = true;
            this.añadirStockDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.añadirStockDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.añadirStockDataGridView.Size = new System.Drawing.Size(896, 224);
            this.añadirStockDataGridView.TabIndex = 0;
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(7, 79);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 36;
            cantidadLabel.Text = "Cantidad:";
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.añadirStockBindingSource, "Cantidad", true));
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(65, 74);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadNumericUpDown.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdArea";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdArea";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 63;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdArticulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdArticulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 76;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreArticulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "NombreArticulo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 104;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 88;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdUnidadMedida";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdUnidadMedida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CantidadNormal";
            this.dataGridViewTextBoxColumn6.HeaderText = "CantidadNormal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 107;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CantidadCritica";
            this.dataGridViewTextBoxColumn7.HeaderText = "CantidadCritica";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 103;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(7, 51);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 37;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.añadirStockBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(79, 48);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(567, 20);
            this.descripcionTextBox.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añadir Stock a artículo";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnCerrarFormulario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 25);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 100);
            this.panel2.TabIndex = 9;
            // 
            // AñadirStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.panelDGV);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AñadirStock";
            this.Text = "AñadirStock";
            this.Load += new System.EventHandler(this.AñadirStock_Load);
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.añadirStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.añadirStockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button BtnInsertar;
        private SCIDataSet sCIDataSet;
        private System.Windows.Forms.BindingSource añadirStockBindingSource;
        private SCIDataSetTableAdapters.AñadirStockTableAdapter añadirStockTableAdapter;
        private SCIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombreArticuloTextBox;
        private System.Windows.Forms.TextBox idAreaTextBox;
        private System.Windows.Forms.TextBox idArticuloTextBox;
        private System.Windows.Forms.DataGridView añadirStockDataGridView;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrarFormulario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}