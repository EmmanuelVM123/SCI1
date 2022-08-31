using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI1
{
    public class Correo
    {
        public string correo { get; set; }
        public string alias { get; set; }
        public string asunto { get; set; }
        public string cuerpo { get; set; }
        public string contraseña { get; set; }
        public int puerto { get; set; }
        public string smtp { get; set; }
        //public string destinatario { get; set; }
        public List<string> destinatarios { get; set; }
        public List<string> adjuntos { get; set; }

        public static bool Envio(Correo correo)
        {
            try
            {
                //Instancia SMTP
                SmtpClient cliente = new SmtpClient(correo.smtp,correo.puerto);
                cliente.EnableSsl = true;
                //correo
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(correo.correo, correo.alias);

                //Asunto
                mail.Subject = correo.asunto;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;

                //Cuerpo
                mail.Body = correo.cuerpo;
                mail.BodyEncoding = System.Text.Encoding.UTF8;

                ////Destinatario para recuperar contraseña
                //string correodestinatario = correo.destinatario;
                

                //Destinatarios
                foreach (var destinatario in correo.destinatarios)
                {
                    if (!string.IsNullOrWhiteSpace(destinatario))
                    {
                        mail.To.Add(destinatario);
                    }
                }

                //Archivos adjuntos
                foreach (var adjunto in correo.adjuntos)
                {
                    if (!string.IsNullOrWhiteSpace(adjunto))
                    {
                        mail.Attachments.Add( new Attachment(adjunto));
                    }
                }

                //Validar credenciales
                cliente.Credentials = new NetworkCredential(correo.correo, correo.contraseña);
                cliente.EnableSsl = true;
                cliente.Send(mail);



                //Configuración de caracteres
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al enviar el e-mail: " + ex.Message.ToString(), "Revise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
