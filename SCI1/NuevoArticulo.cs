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
    public partial class NuevoArticulo : Form
    {
        string Modo = "";
        public NuevoArticulo()
        {
            InitializeComponent();
        }

        private void NuevoArticulo_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
            
        }
        private void CargaDatos()
        {
            this.inventarioCrearTableAdapter.Fill(this.sCIDataSet.InventarioCrear);
            this.ModoEdicion("Lectura");
        }
        private void ModoEdicion(string modo)
        {
            this.Modo = modo;
            switch (modo)
            {
                case "Lectura":
                    this.btnAgregar.Enabled = true;
                    this.btnGuardar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.idArticuloTextBox.Enabled = false;
                    this.idAreaComboBox.Enabled = false;
                    this.nombreArticuloTextBox.Enabled = false;
                    this.descripcionTextBox.Enabled = false;
                    this.idUnidadMedidaComboBox.Enabled = false;
                    this.cantidadNumericUpDown.Enabled = false;
                    this.cantidadNormalNumericUpDown.Enabled = false;
                    this.cantidadCriticaNumericUpDown.Enabled = false;
                    break;
                case "Agregar":
                    this.btnAgregar.Enabled = false;
                    this.btnGuardar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.idArticuloTextBox.Enabled = false;
                    this.idAreaComboBox.Enabled = true;
                    this.nombreArticuloTextBox.Enabled = true;
                    this.descripcionTextBox.Enabled = true;
                    this.idUnidadMedidaComboBox.Enabled = true;
                    this.cantidadNumericUpDown.Enabled = true;
                    this.cantidadNormalNumericUpDown.Enabled = true;
                    this.cantidadCriticaNumericUpDown.Enabled = true;
                    break;
            }
        }
        private bool Valida()
        {
            this.errorProvider1.Clear();
            bool validado = true;
            if (this.nombreArticuloTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.nombreArticuloTextBox, "Campo requerido");
            }
            if (this.descripcionTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.descripcionTextBox, "Campo requerido");
            }
            if (this.cantidadNumericUpDown.Value == 0)
            {
                validado = false;
                this.errorProvider1.SetError(this.cantidadNumericUpDown, "La cantidad debe ser mayor de 0");
            }
            return validado;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Agregar");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Valida())
                {                    
                    this.inventarioCrearTableAdapter.Insert(this.idAreaComboBox.Text, this.nombreArticuloTextBox.Text, this.descripcionTextBox.Text, Convert.ToInt32(this.cantidadNumericUpDown.Value),Convert.ToInt32(this.idUnidadMedidaComboBox.Text), Convert.ToInt32(this.cantidadNormalNumericUpDown.Value), Convert.ToInt32(this.cantidadCriticaNumericUpDown.Value));
                    MessageBox.Show("Se ha agregado el artículo: " + this.nombreArticuloTextBox.Text + " con " + this.cantidadNumericUpDown.Value + " unidad(es)", "Operación exitosa");
                    this.CargaDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar los campos " + ex.Message.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }
    }
}
