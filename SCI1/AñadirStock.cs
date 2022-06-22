using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SCI1
{
    public partial class AñadirStock : Form
    {
        string Modo = "";

        SqlCommand cmd;
        SqlDataReader dr;
        public AñadirStock()
        {
            InitializeComponent();
        }

        private void AñadirStock_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
        }
        private void CargaDatos()
        {
            try
            {
                this.añadirStockTableAdapter.Fill(this.sCIDataSet.AñadirStock);
                this.ModoEdicion("Lectura");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar los datos" + ex.Message.ToString());
            }
        }
        private void ModoEdicion(string modo)
        {
            this.Modo = modo;
            switch (modo)
            {                
                case "Lectura":
                    this.BtnInsertar.Enabled = true;
                    this.btnGuardar.Enabled = false;
                    this.btnCancelar.Enabled = false;   
                    this.idArticuloTextBox.Enabled = false;
                    this.idAreaTextBox.Enabled = false;
                    this.nombreArticuloTextBox.Enabled = false;
                    this.descripcionTextBox.Enabled = false;
                    this.cantidadNumericUpDown.Enabled = false;
                    break;
                case "Añadir":
                    this.BtnInsertar.Enabled = false;
                    this.btnGuardar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.idArticuloTextBox.Enabled = false;
                    this.idAreaTextBox.Enabled = false;
                    this.nombreArticuloTextBox.Enabled = false;
                    this.descripcionTextBox.Enabled = false;
                    this.cantidadNumericUpDown.Enabled = true;
                    break;
            }
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Añadir");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("SpInventarioIn");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@IdArticulo", idArticuloTextBox));
            //int id = int.Parse(this.idArticuloTextBox.Text);
            //this.añadirStockTableAdapter.Update( Convert.ToInt32(this.cantidadNumericUpDown.Value),
            //    id);
            this.CargaDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void añadirStockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.añadirStockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sCIDataSet);

        }

       
    }
}
