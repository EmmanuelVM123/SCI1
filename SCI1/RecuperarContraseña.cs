using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI1
{
    public abstract class ServidorCorreoMaestro
    {
        private SmtpClient smtpClient;
        protected string remitente { get; set; }
        protected string contraseña { get; set; }
        protected string smtp { get; set; }
        protected int puerto { get; set; }
        protected bool ssl { get; set; }  

        protected void IniciarClienteSmtp()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(remitente, contraseña);
            smtpClient.Host = smtp;
            smtpClient.Port = puerto;
            smtpClient.EnableSsl = ssl;
        }

        public void enviarCorreo(string asunto, string cuerpo, List<string> destinatario)
        {
            var correoMensaje = new MailMessage();
            try
            {
                correoMensaje.From = new MailAddress(remitente);
                foreach (string correo in destinatario)
                {
                    correoMensaje.To.Add(correo);
                }
                correoMensaje.Subject = asunto;
                correoMensaje.Body = cuerpo;
                correoMensaje.Priority = MailPriority.Normal;
                smtpClient.Send(correoMensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                correoMensaje?.Dispose();
                smtpClient.Dispose();
            }
        }
    }

    class SoporteCorreo:ServidorCorreoMaestro
    {
        public SoporteCorreo()
        {
            remitente = "larevo30@gmail.com";
            contraseña = "ewajnupfbzukgkmc";
            smtp = "smtp.gmail.com";
            puerto = 587;
            ssl = true;
            IniciarClienteSmtp();
        }
    }

    public partial class RecuperarContraseña : Form
    {
        private readonly string conexion;
        public RecuperarContraseña()
        {
            InitializeComponent();
            conexion = "Server=EVM\\EVM;DataBase= SCI; integrated security = true";
        }
        InicioSecion IS = new InicioSecion();
        #region Arrastre
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        public SqlConnection GetConnection()
        {
            return new SqlConnection(conexion);
        }

        public bool RecuperaContraseña(string correoSolicitante)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Usuario where Correo=@correoSolicitante ";
                    comando.Parameters.AddWithValue("@correoSolicitante", correoSolicitante);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }
        public void btnRecuperarContraseña_Click(object sender, EventArgs e)
        { 
            try
            {
               
                    var validarCorreo = RecuperaContraseña(Name = "correo");
                    if (validarCorreo == true)
                    {
                        Correo correo = new Correo
                        {
                            correo = "Emmanuel301097@hotmail.com",
                            contraseña = "EmmanuelVM",
                            alias = "EVM",
                            asunto = "Recuperación de contraseña",
                            cuerpo = "Hola Estimado usuario SCI ITSAV\nSe le hace llegar a su cuenta de correo eléctronico la contraseña que ha olvidado.\n\nLa contraseña es: ",
                            puerto = 587,
                            smtp = "smtp.office365.com",
                            destinatarios = new List<string>()
                        };

                        foreach (DataGridViewRow fila in dgvDestinatario.Rows)
                        {
                            var des = fila.Cells["Correo"].Value;
                            if (des == null) continue;

                            string destinatario = des.ToString();
                            if (!string.IsNullOrWhiteSpace(destinatario))
                            {
                                correo.destinatarios.Add(destinatario);
                            }
                        }

                    //if (Correo.Envio(correo) == true)
                    //{
                    //    MessageBox.Show("El e-mail fue enviado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    this.dgvDestinatario.Rows.Clear();
                       
                    //}

                }
                        else
                        {
                            MessageBox.Show("El usuario o contraseña no coinciden", "Revise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado al intentadr recuperar contraseña: " + ex.Message.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //finally
            //{
            //    this.Close();
            //    IS.Show();
            //}
        }

        private void txtCorreo_MouseEnter(object sender, EventArgs e)
        {
            this.txtCorreo.Text = "";
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;    
        }

        private void bntCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
            IS.Show();
        }

        private void panelAriiba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
