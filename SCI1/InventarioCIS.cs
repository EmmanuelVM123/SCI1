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

        private void CargaDatos()
        {
            this.inventarioCISTableAdapter.Fill(this.sCIDataSet.InventarioCIS);
            this.ModoEdicion("Lectura");
        }
        private void InventarioCIS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sCIDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.sCIDataSet.Inventario);
            this.CargaDatos();
        }
        private void ModoEdicion(string modo)
        {
            this.Modo = modo;
            switch (modo)
            {
                case "Lectura":
                    this.btnEditar.Enabled = true;
                    this.btnGuardar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.idArticuloTextBox.Enabled = false;
                    this.idAreaComboBox.Enabled = false;
                    this.nombreArticuloTextBox.Enabled = false;
                    this.descripcionTextBox.Enabled = false;
                    this.idUnidadMedidaComboBox.Enabled = false;
                    this.cantidadNormalNumericUpDown.Enabled = false;
                    this.cantidadCriticaNumericUpDown.Enabled = false;
                    break;
                case "Actualizar":
                    this.btnEditar.Enabled = false;
                    this.btnGuardar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.idArticuloTextBox.Enabled = false;
                    this.idAreaComboBox.Enabled = true;
                    this.nombreArticuloTextBox.Enabled = true;
                    this.descripcionTextBox.Enabled = true;
                    this.idUnidadMedidaComboBox.Enabled = true;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Actualizar");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Valida())
                {
                    
                    int id = int.Parse(this.idArticuloTextBox.Text);
                    this.inventarioCISTableAdapter.Update(this.idAreaComboBox.Text, this.nombreArticuloTextBox.Text, this.descripcionTextBox.Text, Convert.ToInt32(this.idUnidadMedidaComboBox.Text), Convert.ToInt32(this.cantidadNormalNumericUpDown.Value), Convert.ToInt32(this.cantidadCriticaNumericUpDown.Value),
                        id);
                    MessageBox.Show("¡Se han actualizados los datos ", "Operación exitosa");
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
