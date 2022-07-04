using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace SCI1
{
    public partial class Resumen : Form, VarDatosEntreForm 
    {
        int n;
        public Resumen()
        {
            InitializeComponent();
            this.tbxArticulo.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook hoja = excel.Workbooks.Open("C:\\Users\\Emman\\Downloads\\RR.xlsx");
                Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

                Microsoft.Office.Interop.Excel.Range userRange = x.UsedRange;
                int counRecords = userRange.Rows.Count;
                int add = counRecords + 1;
                
                
                //Insertar NOMBRE DEL ÁREA SOLICITANTE en la CELDA D9
                x.Cells[9, 4] = tbxArea.Text;
                //Insertar FECHA de solicitud en la CELDA D11
                DateTime fecha = DateTime.Today;
                x.Cells[11, 4] = fecha.ToShortDateString();
                //insertar CANTIDAD SOLICITADA en la CELDA B12
                x.Cells[14, 2] = tbxCantidad.Text;
                //Insertar UNIDAD DE MEDIDA en la CELDA C14
                x.Cells[14, 3] = tbxMedida.Text;
                //Insertar NOMBRE DE ARTÍCULO en la CELDA D14
                x.Cells[14, 4] = "*" + tbxArticulo.Text;
                //Insertar DESCRIPCIÓN para el uso de los bienes en la CELDA E27
                x.Cells[27, 5] = tbxUso.Text;
                
                //Guardar lo cambios el mismo documento
                hoja.Save();
                MessageBox.Show("Se insertaron datos en el archivo Excel ", "Operación exitosa") ;
                hoja.PrintOutEx();
                hoja.Close(true, Type.Missing, Type.Missing);
                excel.Quit();
                this.tbxArea.Clear();
                this.tbxCantidad.Clear();
                this.tbxMedida.Clear();
                this.tbxArticulo.Clear();
                this.tbxUso.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un Error: " + ex.Message.ToString(), "Error");
            }
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
            this.articuloARequisitar.Fill(this.sCIDataSet.ArticuloARequisitar);
        }
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.articuloARequisitar.Fill(this.sCIDataSet.ArticuloARequisitar);
        }
        
        public void TablaDeAgregarDatos(DataGridViewRow fila)
        {
            bool DatosEnDGV = false;
            String valorElemento = fila.Cells["NombreArticulo"].Value.ToString().ToUpper();

            foreach (DataGridViewRow fila2 in dataGridView2.Rows)
            {
                if (fila2.Cells[2].Value.ToString().Equals(valorElemento))
                {
                    MessageBox.Show("No se puede agregar de nuevo el artículo seleccionado porque que ya está en la lista a solicitar", "Artículo repetido");
                    DatosEnDGV = true;
                    break;
                }
            }

            if (DatosEnDGV != true)
            {
                String Cantidad = fila.Cells["Cantidad"].Value.ToString().ToUpper();
                String NombreArticulo = fila.Cells["NombreArticulo"].Value.ToString().ToUpper();
                String IdUnidadMedida = fila.Cells["IdUnidadMedida"].Value.ToString().ToUpper();

                this.dataGridView2.Rows.Add(new[] { Cantidad, IdUnidadMedida, NombreArticulo });
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0] as DataGridViewRow;
                TablaDeAgregarDatos(fila);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error al solicitar artículo(s): " + ex.Message.ToString(), "Error al solicitar");
            }
            
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            try
            {
                dataGridView2.Rows.RemoveAt(n);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocuurrido un error al remover una fila: " + ex.Message.ToString(), "Error al remover");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }
    }

    internal interface VarDatosEntreForm
    {

    }
}
