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
    public partial class AñadirStock : Form
    {
        string Modo = "";
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
            this.inventarioTableAdapter.Fill(this.sCIDataSet.Inventario);
            this.ModoEdicion("Lectura");
        }
        private void ModoEdicion(string modo)
        {
            this.Modo = modo;
            switch (modo)
            {
                case "Lectura":
                    this.btnAñadir.Enabled = true;
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
                    this.btnAñadir.Enabled = false;
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
        private bool Valida()
        {
            this.errorProvider1.Clear();
            bool validado = true;
            if (this.cantidadNumericUpDown.Text == "0")
            {
                validado = false;
                this.errorProvider1.SetError(this.cantidadNumericUpDown, "Añada al menos 1 unidad al artículo ");
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
            this.ModoEdicion("Añadir");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valida())
                {
                    int id = int.Parse(this.idArticuloTextBox.Text);
                    this.inventarioTableAdapter.Update(Convert.ToInt32(this.cantidadNumericUpDown.Value),
                        id);
                    MessageBox.Show("¡Se ha(n) añadido " + Convert.ToInt32(this.cantidadNumericUpDown.Value) + " unidad(es) al artículo: " + this.nombreArticuloTextBox.Text, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargaDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al añadir inventario: " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void inventarioDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            bool cn = inventarioDataGridView.Columns[e.ColumnIndex].Index == 6;
            bool cc = inventarioDataGridView.Columns[e.ColumnIndex].Index == 7;



            if (inventarioDataGridView.Columns[e.ColumnIndex].Index == 4)
            {
                if (Convert.ToInt32(e.Value) >= Convert.ToInt32(cn))
                {
                    
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = System.Drawing.Color.SteelBlue;
                }
                if (Convert.ToInt32(e.Value) != Convert.ToInt32(cc) && Convert.ToInt32(e.Value) < Convert.ToInt32(cn))
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.Red;
                    e.CellStyle.BackColor = System.Drawing.Color.FloralWhite;
                }
                
                if (Convert.ToInt32(e.Value) < Convert.ToInt32(cn))
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.DarkRed;
                    e.CellStyle.BackColor = System.Drawing.Color.LightYellow;
                }
                              
            }
        }
    }
}
