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
    public partial class InventarioMNT : Form
    {
        string Modo = "";
        public InventarioMNT()
        {
            InitializeComponent();
        }
        private void CargaDatos()
        {
            try
            {
                this.inventarioMNTTableAdapter.Fill(this.sCIDataSet.InventarioMNT);
                this.ModoEdicion("Lectura");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InventarioMNT_Load(object sender, EventArgs e)
        {
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
                    this.inventarioMNTTableAdapter.Update(this.idAreaComboBox.Text, this.nombreArticuloTextBox.Text, this.descripcionTextBox.Text, Convert.ToInt32(this.idUnidadMedidaComboBox.Text), Convert.ToInt32(this.cantidadNormalNumericUpDown.Value), Convert.ToInt32(this.cantidadCriticaNumericUpDown.Value),
                        id);
                    MessageBox.Show("Se han actualizados los datos ", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargaDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar los campos " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void inventarioITNDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.inventarioITNDataGridView.Columns[e.ColumnIndex].Name == "Cantidad")
                if (Convert.ToInt32(e.Value) <= 2)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.Orange;
                }
        }
    }
}
