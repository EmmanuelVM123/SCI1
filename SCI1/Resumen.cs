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
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Cantidad = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[5].Value);
                //if (this.IdUnidadMedida.ToString() == "1")
                //{
                //    Convert.ToString(this.IdUnidadMedida.Equals("Pzs"));
                //}
                int IdUnidadMedida = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[6].Value);
                string NombreArticulo = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                MessageBox.Show(
                    $"Cantidad: {Cantidad}\nMedida: {IdUnidadMedida}\nArtículo: {NombreArticulo}"
                    );

                // this.dataGridView2.Rows.Add(Convert.ToInt32(this.Cantidad.ToString()), Convert.ToInt32(this.IdUnidadMedida.ToString()), this.NombreArticulo.ToString());

                foreach (DataGridViewRow row  in this.dataGridView1.Rows)
                {
                    this.dataGridView2.Rows.Add(row.Cells[6].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[3].Value.ToString());
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido error en el evento 'Doble clic a la celda'" + ex.Message.ToString(), "Error" );
            }
        }
        public void TablaDeAgregarDatos(DataGridViewRow fila)
        {
            String Cantidad = fila.Cells["Cantidad"].Value.ToString();
            String NombreArticulo = fila.Cells["NombreArticulo"].Value.ToString();
            String IdUnidadMedida = fila.Cells["IdUnidadMedida"].Value.ToString();

            this.dataGridView2.Rows.Add(new[] { Cantidad, IdUnidadMedida, NombreArticulo});
        }
        private void button1_Click(object sender, EventArgs e)
        {
           DataGridViewRow fila = dataGridView1.SelectedRows[0] as DataGridViewRow;
            TablaDeAgregarDatos(fila);
            
            
        }

    }

    internal interface VarDatosEntreForm
    {

    }
}
