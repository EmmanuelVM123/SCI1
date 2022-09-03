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
    public partial class DisminuirStock : Form
    {
        string Modo = "";
        public DisminuirStock()
        {
            InitializeComponent();
        }

        private void DisminuirStock_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
        }
        private void CargaDatos()
        {
            this.inventario_TableAdapter.Fill(this.sCIDataSet._Inventario_);
            this.ModoEdicion("Lectura");
        }
        private void ModoEdicion(string modo)
        {
            this.Modo = modo;
            switch (modo)
            {
                case "Lectura":
                    this.btnDisminuir.Enabled = true;
                    this.btnGuardar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnRecargar.Enabled = true;
                    this.idArticuloTextBox.Enabled = false;
                    this.idAreaComboBox.Enabled = false;
                    this.nombreArticuloTextBox.Enabled = false;
                    this.descripcionTextBox.Enabled = false;
                    this.cantidadNumericUpDown.Enabled = false;

                    break;
                case "Añadir":
                    this.btnDisminuir.Enabled = false;
                    this.btnGuardar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.btnRecargar.Enabled = false;
                    this.idArticuloTextBox.Enabled = false;
                    this.idAreaComboBox.Enabled = false;
                    this.nombreArticuloTextBox.Enabled = false;
                    this.descripcionTextBox.Enabled = false;
                    this.cantidadNumericUpDown.Enabled = true;
                    this.cantidadNumericUpDown.Value = 0;
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Añadir");
        }

        private bool Valida()
        {
            this.errorProvider1.Clear();
            bool validado = true;
            if (this.cantidadNumericUpDown.Text == "0")
            {
                validado = false;
                this.errorProvider1.SetError(this.cantidadNumericUpDown, "Disminuya al menos 1 unidad al artículo ");
            }
            return validado;
        }
        
        private void Guardar()
        {
            try
            {
                if (Valida())
                {
                    int id = int.Parse(this.idArticuloTextBox.Text);
                    this.inventario_TableAdapter.Update(Convert.ToInt32(this.cantidadNumericUpDown.Value),
                        id);
                    MessageBox.Show("Se ha(n) disminuido " + Convert.ToInt32(this.cantidadNumericUpDown.Value) + " unidad(es) al artículo: " + this.nombreArticuloTextBox.Text, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.CargaDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar los campos " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void cantidadNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) == true)
            {
                this.Guardar();
            }
        }
    }
}
