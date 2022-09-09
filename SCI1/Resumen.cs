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
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using Magnum.FileSystem;

namespace SCI1
{
    public partial class Resumen : Form
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
        public void ExportarExcel ()
        {
            try
            {

                //SLDocument sl = new SLDocument("RR.xlsx");
                //sl.SetCellValue(4,15, "PROBANDO...");
                //sl.Save(); 

                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook hoja = excel.Workbooks.Open("C:\\Users\\Emman\\Downloads\\RR.xlsx");
                Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

                Microsoft.Office.Interop.Excel.Range userRange = x.UsedRange;
                int counRecords = userRange.Rows.Count;
                int add = counRecords + 1;
                int ColumnIndex = 0;
                foreach (DataGridViewRow row in dgvArticulosSolcitados.Rows)
                {
                    excel.Cells[14, 2] = row.Selected;
                }


                //Insertar NOMBRE DEL ÁREA SOLICITANTE en la CELDA D9
                x.Cells[9, 4] = cbxAreaSolicitante.Text;
                //Insertar FECHA de solicitud en la CELDA D11
                DateTime fecha = DateTime.Today;
                x.Cells[11, 4] = fecha.ToShortDateString();
                //insertar CANTIDAD SOLICITADA en la CELDA B12
                x.Cells[14, 2] = Convert.ToString(cbxCantidad.Text);
                //Insertar UNIDAD DE MEDIDA en la CELDA C14
                x.Cells[14, 3] = cbxUnidadMedida.Text;
                //Insertar NOMBRE DE ARTÍCULO en la CELDA D14
                //foreach (DataGridViewColumn i in fila)
                //{
                //    x.Cells[14, 4]++;
                //}
                //x.Cells[14, 4] = "*" + tbxArticulo.Text;
                //Insertar DESCRIPCIÓN para el uso de los bienes en la CELDA E27
                x.Cells[27, 5] = cbxUsar.Text;

                //Guardar lo cambios en el mismo documento
                hoja.Save();
                MessageBox.Show("Se insertaron datos en el archivo Excel ", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                excel.Visible = true;
                hoja.PrintOutEx();

                hoja.Close(true, Type.Missing, Type.Missing);
                excel.Quit();
                this.cbxAreaSolicitante.Text = "";
                Convert.ToUInt32(cbxCantidad).ToString("");
                this.cbxUnidadMedida.Text = "";
                this.cbxArticulo.Text = "";
                this.cbxUsar.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            if (this.ValidaGenerar())
            {
                MessageBox.Show("Se insertaron datos en el archivo Excel ", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        public void ExportarDatos(DataGridView dataListado)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook hoja = exportarExcel.Workbooks.Open("C:\\Users\\Emman\\Downloads\\RR.xlsx");
            int indiceColumna = 0;
            StringConverter stringConverter = new StringConverter();
            stringConverter.ConvertToString(dataListado = dgvArticulosSolcitados);
            foreach (DataGridViewColumn columna in dataListado.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }

            int indiceFila = 0;
            foreach (DataGridViewRow fila in dataListado.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in dataListado.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }

            exportarExcel.Visible = true;

        }

        public void Notificacion()
        {
            if (dgvArticulosASolicitar.Rows.Count != 0)
            {
                notifyIcon1.Text = "SCI ITSAV \n*Solicite una requisición \n**Actualice stock";
                notifyIcon1.BalloonTipTitle = "Actualice stock o solicite una Requisición";
                notifyIcon1.BalloonTipText = "La cantidad de algunos artículos está por debajo de lo normal";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.ShowBalloonTip(4000);
                notifyIcon1.Visible = true;

            }
            else
            {
                notifyIcon1.Text = "SCI ITSAV \nTodo en orden";
                notifyIcon1.BalloonTipTitle = "Excelentes noticias";
                notifyIcon1.BalloonTipText = "Las cantidades de los artículos en inventario son normales";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(4000);
                notifyIcon1.Visible = true;
            }
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sCIDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.sCIDataSet.Inventario);
            this.articuloARequisitar.Fill(this.sCIDataSet.ArticuloARequisitar);
             this.Notificacion();

            if (dgvArticulosASolicitar.Rows.Count > 0)
            {                
                this.btnSolicitar.Enabled = true;
                this.btnSolicitarNuevo.Enabled = true;
            }
            else
            {
                this.btnSolicitar.Enabled = false;
                this.btnSolicitarNuevo.Enabled = true;
            }
            if (dgvArticulosSolcitados.Rows.Count > 0)
            {
                this.btnEnviar.Enabled = true;
                this.btnLimpiar.Enabled = false;
            }
            else
            {
                this.btnEnviar.Enabled = false; 
                this.btnLimpiar.Enabled = false;
            }
        }
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.articuloARequisitar.Fill(this.sCIDataSet.ArticuloARequisitar);
            this.Notificacion();

            if(dgvArticulosASolicitar.Rows.Count > 0)
            {
                this.btnSolicitar.Enabled = true;
                this.btnLimpiar.Enabled = false;
            }
            else
            {
                this.btnSolicitar.Enabled = false;
                this.btnEnviar.Enabled = false;
            }
            if (dgvArticulosSolcitados.Rows.Count > 0)
            {
                this.btnLimpiar.Enabled = true;
                this.btnEnviar.Enabled = true;
            }

        }
        
        public void TablaDeAgregarDatos(DataGridViewRow fila)
        {
            try
            {
                bool DatosEnDGV = false;
                String valorElemento = fila.Cells["NombreArticulo"].Value.ToString().ToUpper();

                foreach (DataGridViewRow fila2 in dgvArticulosSolcitados.Rows)
                {

                    if (fila2.Cells[2].Value.ToString().Equals(valorElemento))
                    {
                        //this.errorProvider1.SetError(this.btnSolicitar, "Artículo repetido\nEl artículo '" + this.NombreArticulo.ToString() + "' ya fue agregado");
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

                    switch (IdUnidadMedida)
                    {
                        case "1":
                            IdUnidadMedida = "PZS";
                            break;
                        case "2":
                            IdUnidadMedida = "KGS";
                            break;
                        case "3":
                            IdUnidadMedida = "LTS";
                            break;
                        case "4":
                            IdUnidadMedida = "GALON";
                            break;
                    }

                    dgvArticulosSolcitados.Rows.Add(new[] { Cantidad, IdUnidadMedida, NombreArticulo });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TablaAgregarNuevos(DataGridViewRow fila)
        {
            try
            {
                bool DatosEnDGV = false;
                String valorElemento = cbxArticulo.Text.ToString().ToUpper();

                foreach (DataGridViewRow fila2 in dgvArticulosSolcitados.Rows)
                {

                    if (fila2.Cells[2].Value.ToString().Equals(valorElemento))
                    {
                        //this.errorProvider1.SetError(this.btnSolicitar, "Artículo repetido\nEl artículo '" + this.NombreArticulo.ToString() + "' ya fue agregado");
                        MessageBox.Show("No se puede agregar de nuevo el artículo seleccionado porque que ya está en la lista a solicitar", "Artículo repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DatosEnDGV = true;
                        break;
                    }
                }

                if (DatosEnDGV != true)
                {
                    //String Cantidad = cbxCantidad.Text.ToString();  
                    //String NombreArticulo = cbxArticulo.Text.ToString();
                    //String IdUnidadMedida = cbxUnidadMedida.Text.ToString();
                    //dgvArticulosSolcitados.Rows.Add(new[] { Cantidad, IdUnidadMedida, NombreArticulo });
                    dgvArticulosSolcitados.Rows.Add(cbxCantidad.Value.ToString(), cbxUnidadMedida.Text.ToString(), cbxArticulo.Text.ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private bool ValidaGenerar()
        {
            this.errorProvider.Clear();
            bool resultado = true;
            //Validar el campo Usuario
            if (this.cbxAreaSolicitante.Text.Trim() == "Seleccione el área")
            {
                resultado = false;
                this.errorProvider.SetError(this.cbxAreaSolicitante, "Seleccione el área solicitante");
            }

            //Validar el campo Contraseña
            if (this.cbxUsar.Text.Trim() == "" || this.cbxUsar.Text.Trim() == "Seleccione o describa para que o por quiénes serán utilizados los artículos solicitados")
            {
                resultado = false;
                this.errorProvider.SetError(this.cbxUnidadMedida, "Seleccione o describa el uso de los artículos");
            }

            return resultado;
        }

        private bool ValidaSolicitarNuevo()
        {
            this.errorProvider.Clear();
            bool resultado = true;
            //Validar el campo Usuario
            if (this.cbxCantidad.Value == 0 )
            {
                resultado = false;
                this.errorProvider.SetError(this.cbxCantidad, "Ingrese un núnero mayor que 1");
            }

            //Validar el campo Contraseña
            if (this.cbxUnidadMedida.Text.Trim() == "" || this.cbxUnidadMedida.Text.Trim() == "Seleccione o describa la unidad de medida")
            {
                resultado = false;
                this.errorProvider.SetError(this.cbxUnidadMedida, "Selecciona una unidad de medida");
            }

            return resultado;
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvArticulosASolicitar.Rows.Count != 0)
                {                    
                    DataGridViewRow fila = dgvArticulosASolicitar.SelectedRows[0] as DataGridViewRow;
                    TablaDeAgregarDatos(fila);
                    btnEnviar.Enabled = true;
                }
                if (dgvArticulosASolicitar.Rows.Count == 0)
                {
                    btnSolicitar.Enabled = false;
                }               
                this.btnLimpiar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error al solicitar artículo(s): " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSolicitarNuevo_Click(object sender, EventArgs e)
        {            
            try
            {
                if (dgvArticulosASolicitar.Rows.Count != 0 && this.ValidaSolicitarNuevo())
                {
                    dgvArticulosSolcitados.Rows.Add(cbxCantidad.Value.ToString(), cbxUnidadMedida.Text.ToString().ToUpper(), cbxArticulo.Text.ToString().ToUpper());
                    //DataGridViewRow fila = dgvArticulosSolcitados.SelectedRows[0] as DataGridViewRow;
                    //TablaAgregarNuevos(fila);
                    btnEnviar.Enabled = true;
                }
                if (dgvArticulosASolicitar.Rows.Count == 0)
                {
                    btnSolicitar.Enabled = false;
                }
                this.btnLimpiar.Enabled = true;

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
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvArticulosSolcitados.Rows.Clear();
            if (dgvArticulosSolcitados.Rows.Count == 0)
            {
                this.btnLimpiar.Enabled = false;
                this.btnEnviar.Enabled = false;
            }
        }

        private void dgvArticulosSolcitados_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvArticulosSolcitados.Rows.Count == 0)
            {
                this.btnEnviar.Enabled = false;
                this.btnLimpiar.Enabled = false; 
            }
        }
    }
}
