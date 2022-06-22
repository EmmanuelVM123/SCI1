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
    public partial class RestarStock : Form
    {
        string Modo = "";
        public RestarStock()
        {
            InitializeComponent();
        }

        private void RestarStock_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void CargaDatos()
        {
            try
            {
                this.disminuirStockTableAdapter.Fill(this.sCIDataSet.DisminuirStock);
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
            try
            {
                int id = int.Parse(this.idArticuloTextBox.Text);
                this.disminuirStockTableAdapter.Update(Convert.ToInt32(this.cantidadNumericUpDown.Value),
                    id);
                MessageBox.Show("¡Se ha disminunido " + Convert.ToInt32(this.cantidadNumericUpDown.Value) + " al artículo: " + this.nombreArticuloTextBox.Text, "Operación exitosa");
                this.CargaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al disminuir el Stock: " + ex.Message.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }
    }
}
