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
    public partial class InventarioCIS : Form
    {
        string Modo = "";

        public InventarioCIS()
        {
            InitializeComponent();
        }

        private void InventarioCIS_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void CargaDatos()
        {
            try
            {
                this.inventarioTableAdapter.Fill(this.sCIDataSet.Inventario);
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
                    this.BtnEditar.Enabled = true;
                    this.btnGuardar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.idArticuloTextBox.Enabled = false;
                    this.idAreaTextBox.Enabled = false;
                    this.nombreArticuloTextBox.Enabled = false;
                    this.descripcionTextBox.Enabled = false;
                    this.idUnidadMedidaNumericUpDown.Enabled = false;
                    this.cantidadNormalNumericUpDown.Enabled = false;
                    this.cantidadCriticaNumericUpDown.Enabled = false;                    
                    break;
                case "Modificar":
                    this.BtnEditar.Enabled = false;
                    this.btnGuardar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.idArticuloTextBox.Enabled = true;
                    this.idAreaTextBox.Enabled = true;
                    this.nombreArticuloTextBox.Enabled = true;
                    this.descripcionTextBox.Enabled = true;
                    this.idUnidadMedidaNumericUpDown.Enabled = true;
                    this.cantidadNormalNumericUpDown.Enabled = true;
                    this.cantidadCriticaNumericUpDown.Enabled = true;

                    break;
            }
        }
        private bool Valida()
        {
            this.errorProvider1.Clear();
            bool validado = true;
            if (this.nombreArticuloTextBox.Text.Trim() == "" )
            {
                this.errorProvider1.SetError(this.nombreArticuloTextBox, "¡Campo requerido!");
            }
            if (this.descripcionTextBox.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.descripcionTextBox, "¡Campo requerido!");
            }
            return validado;
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sCIDataSet);

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Modificar");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Valida())
                {
                    int id = int.Parse(this.idArticuloTextBox.Text);
                    this.inventarioTableAdapter.Update(this.idAreaTextBox.Text,
                   this.nombreArticuloTextBox.Text, this.descripcionTextBox.Text,
                   Convert.ToInt32(this.idUnidadMedidaNumericUpDown.Text),
                   Convert.ToInt32(this.cantidadNormalNumericUpDown.Value),
                   Convert.ToInt32(this.cantidadCriticaNumericUpDown.Value),
                   id);
                    MessageBox.Show("Los datos fueron actualizados correctamente", "Operación exitosa");
                    this.CargaDatos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar los campos: " + ex.Message.ToString());

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();            
        }
    }
}
