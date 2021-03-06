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
    public partial class EnviarRequisicion : Form, IResumen
    {
        private int conteo;
        public EnviarRequisicion()
        {
            InitializeComponent();
            conteo = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {

        }

        //private void Enviar(sender e)
        //{
        //    this.btnEnviarCorreo_Click();
        //}

        private  void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                Correo correo = new Correo
                {
                    correo = txtCorreo.Text,
                    contraseña = txtContraseña.Text,
                    alias = txtAlias.Text,
                    asunto = txtAsunto.Text,
                    cuerpo = txtCuerpo.Text,
                    puerto = Convert.ToInt32(txtPuerto.Text),
                    smtp = txtSMPT.Text,
                    destinatarios = new List<string>(),
                    adjuntos = new List<string>()
                };

                foreach (DataGridViewRow fila in dgvDestinatario.Rows)
                {
                    var des = fila.Cells["correoDestino"].Value;
                    if (des == null) continue;

                    string destinatario = des.ToString();
                    if (!string.IsNullOrWhiteSpace(destinatario))
                    {
                        correo.destinatarios.Add(destinatario);
                    }
                }

                foreach (DataGridViewRow fila in dgvArchivos.Rows)
                {
                    string archivo = fila.Cells["adjuntoArchivo"].Value.ToString();
                    if (!string.IsNullOrWhiteSpace(archivo))
                    {
                        correo.adjuntos.Add(archivo);
                    }
                }

                if (Correo.Enviar(correo) == true)
                {
                    MessageBox.Show("El e-mail fue enviado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtAsunto.Clear();
                    this.txtCuerpo.Clear();
                    this.dgvDestinatario.Rows.Clear();
                    this.dgvArchivos.Rows.Clear();
                    this.txtCorreo.Text = "";
                    this.txtContraseña.Clear();
                    this.txtAlias.Clear();
                }
                
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Error al enviar e-mail: " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }

        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Seleccione Requisición";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var archivos = open.FileName;
                dgvArchivos.Rows.Add(archivos);    
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvArchivos.Rows.Clear();
        }

        private void tProgreso_Tick(object sender, EventArgs e)
        {
            conteo++;

        }
    }

    internal interface IResumen
    {
        
    }
}
