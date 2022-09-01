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

        public string RecuperaContraseña(string correoSolicitante)
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
                        string nombreUsuario = reader.GetString(2);
                        string correoSolicitud = reader.GetString(4);
                        string contraseña = reader.GetString(3);

                        var servicioCorreo = new SoporteCorreo();
                        servicioCorreo.enviarCorreo
                            (
                                asunto: "Sistema de Recuperacuón de contraseña: Solicitud de recuperación de contraseña",
                                cuerpo: "¡Hola, " + nombreUsuario + " su Solicitud de Recuperación de Contraseña ha sido exitosa!\n" + "Su contraseña de ingreso es: " + contraseña + "\nSin embargo, se le recomienda cambiar lo antes posible su contraseña un a vez ingrese al sistema, para esto contacte a un Administrador de Base de Datos",
                                destinatario: new List<string> { correoSolicitud }                            
                            );
                        return Convert.ToString(MessageBox.Show("Estimad@ " + nombreUsuario + ", el sistema de recuperación de contraseñas ha enviado al correo (" + correoSolicitud + ") que tiene registrado la contraseña correspondite a su usuario", "Recuperación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information));
                    }
                    else
                    {
                        return Convert.ToString(MessageBox.Show("El correo ingresado no corresponde a un cuenta de usuario registrada" , "Revise", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    }
                }
            }

        }

        public string recuperacionContraseña (string usuarioSolicita)
        {
            return RecuperaContraseña(usuarioSolicita);
        }

        public void btnRecuperarContraseña_Click(object sender, EventArgs e)
        {
            var resultado = RecuperaContraseña(txtCorreo.Text);
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

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo eléctronico")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Silver;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo eléctronico";
                txtCorreo.ForeColor = Color.Silver;
            }
        }
    }

    public abstract class ServidorCorreoMaestro
    {
        private SmtpClient smtpClient;
        protected string remitente { get; set; }
        protected string alias { get; set; }
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

    class SoporteCorreo : ServidorCorreoMaestro
    {
        public SoporteCorreo()
        {
            remitente = "ingresospropioslerdo@gmail.com";
            contraseña = "oebrwllmarjfdxdk";
            smtp = "smtp.gmail.com";
            puerto = 587;
            ssl = true;
            IniciarClienteSmtp();
        }
    }
}
