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
                
                //Guardar lo cambios en el mismo documento
                hoja.Save();
                MessageBox.Show("Se insertaron datos en el archivo Excel ", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
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
                MessageBox.Show("Ha ocurrido un error: " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Notificacion()
        {
            if (dataGridView1.Rows.Count != 0)
            {
                notifyIcon1.Text = "SCI ITSAV Prueba";
                notifyIcon1.BalloonTipTitle = "Actualice stock o solicite una Requisición";
                notifyIcon1.BalloonTipText = "La cantidad de algunos artículos está por debajo de lo normal";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.ShowBalloonTip(4000);
                notifyIcon1.Visible = true;
                ;
            }
            else
            {
                notifyIcon1.Text = "SCI ITSAV Prueba";
                notifyIcon1.BalloonTipTitle = "Excelentes noticias";
                notifyIcon1.BalloonTipText = "Las cantidades de los artículos en inventario son normales";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(4000);
                notifyIcon1.Visible = true;
            }
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
            this.articuloARequisitar.Fill(this.sCIDataSet.ArticuloARequisitar);
            this.Notificacion();
            
        }
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.articuloARequisitar.Fill(this.sCIDataSet.ArticuloARequisitar);
            this.Notificacion();
        }
        
        public void TablaDeAgregarDatos(DataGridViewRow fila)
        {
            try
            {
                bool DatosEnDGV = false;
                String valorElemento = fila.Cells["NombreArticulo"].Value.ToString().ToUpper();

                foreach (DataGridViewRow fila2 in dataGridView2.Rows)
                {

                    if (fila2.Cells[2].Value.ToString().Equals(valorElemento))
                    {
                        MessageBox.Show("No se puede agregar de nuevo el artículo seleccionado porque que ya está en la lista a solicitar", "Artículo repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0] as DataGridViewRow;
                TablaDeAgregarDatos(fila);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error al solicitar artículo(s): " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Ha ocuurrido un error al remover una fila: " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
