using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI1
{
    public partial class EliminarArticulo : Form
    {
        string Modo = "";
        public EliminarArticulo()
        {
            InitializeComponent();
        }

        private void EliminarArticulo_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void CargaDatos()
        {
            try
            {
                this.inventario1TableAdapter.E(this.sCIDataSet.Inventario1);
                this.ModoEdicion("Lectura");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error al cargar los datos: " + ex.Message.ToString());
            }
        }

        private void ModoEdicion(string modo)
        {
            this.Modo = modo;
            switch (modo)
            {
                case "Lectura":
                    this.inventarioDataGridView.Enabled = true;
                    this.idArticuloTextBox.Enabled = false;                    
                    break;
            }
        }

        private void eToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.inventario1TableAdapter.E(this.sCIDataSet.Inventario1);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void btbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Está seguro de eliminar el artículo: " + (this.nombreArticuloTextBox.Text) + "?" , "Eliminar ", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(this.idArticuloTextBox.Text);
                    this.inventario1TableAdapter.Delete(id);
                    MessageBox.Show("Artículo eliminado exitosamente");
                    this.CargaDatos();
                }
                else
                {
                    this.CargaDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el artículo: " + ex.Message.ToString());               
            }
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
