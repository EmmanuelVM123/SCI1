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
    public partial class InsertarInventario : Form
    {
        string Modo = "";
        public InsertarInventario()
        {
            InitializeComponent();
        }

        private void InsertarInventario_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void CargaDatos()
        {
            try
            {
                this.unidadMedidaTableAdapter.Fill(this.sCIDataSet.UnidadMedida);
                this.areasTableAdapter.Fill(this.sCIDataSet.Areas);
                this.inventarioInsertTableAdapter.Fill(this.sCIDataSet.InventarioInsert);
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
                    this.BtnInsertar.Enabled = true;
                    this.btnGuardar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.inventarioDataGridView.Enabled = true;
                    this.idArticuloTextBox.Enabled = false;
                    this.idAreaTextBox.Enabled = false;
                    this.nombreArticuloTextBox.Enabled = false;
                    this.cantidadNumericUpDown.Enabled = false; 
                    this.descripcionTextBox.Enabled = false;
                    this.idUnidadMedidaTextBox.Enabled = false;
                    this.cantidadNormalNumericUpDown.Enabled = false;
                    this.cantidadCriticaNumericUpDown.Enabled = false;
                    break;
                case "Insertar":
                    this.BtnInsertar.Enabled = false;
                    this.btnGuardar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.idArticuloTextBox.Enabled = false;
                    this.idAreaTextBox.Enabled = true;
                    this.nombreArticuloTextBox.Enabled = true;
                    this.descripcionTextBox.Enabled = true;
                    this.cantidadNumericUpDown.Enabled = true;
                    this.idUnidadMedidaTextBox.Enabled = true;
                    this.cantidadNormalNumericUpDown.Enabled = true;
                    this.cantidadCriticaNumericUpDown.Enabled = true;
                    this.descripcionTextBox.Text = "";
                    this.idAreaTextBox.Text = "";
                    this.nombreArticuloTextBox.Text = "";                    
                    this.cantidadNormalNumericUpDown.Value = 0;
                    this.cantidadCriticaNumericUpDown.Value = 0;

                    break;
            }
        }

        private bool Valida()
        {
            this.errorProvider1.Clear();
            bool validado = true;
            if (this.nombreArticuloTextBox.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.nombreArticuloTextBox, "¡Campo requerido!");
            }
            if (this.descripcionTextBox.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.descripcionTextBox, "¡Campo requerido!");
            }
            return validado;
        }
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Insertar");

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Valida())
                {
                    //int id = int.Parse(this.idArticuloTextBox.Text);
                    this.inventarioInsertTableAdapter.Insert(this.idAreaTextBox.Text,
                   this.nombreArticuloTextBox.Text, this.descripcionTextBox.Text,
                   Convert.ToInt32(this.idUnidadMedidaTextBox.Text),
                   Convert.ToInt32(this.cantidadNumericUpDown.Value),
                   Convert.ToInt32(this.cantidadNormalNumericUpDown.Value),
                   Convert.ToInt32(this.cantidadCriticaNumericUpDown.Value));
                    MessageBox.Show("Los datos fueron insertados correctamente", "Operación exitosa");
                    this.CargaDatos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al Insertar los datos: " + ex.Message.ToString(), "Operación fallida: ");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
