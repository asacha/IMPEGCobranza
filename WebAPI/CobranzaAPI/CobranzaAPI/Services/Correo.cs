using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace CobranzaAPI.Services
{
    public static class Correo
    {
        public static bool EnviarCorreo(MailAddressCollection Destinatarios, string Asunto, string Mensaje)
        {
            bool Error = false;
            try
            {
                NameValueCollection CorreoConfig = (NameValueCollection)ConfigurationManager.GetSection("CorreoConfig");
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(CorreoConfig["From"].ToString(), CorreoConfig["FromName"].ToString());

                foreach (MailAddress para in Destinatarios)
                {
                    mail.To.Add(para);
                }

                mail.Subject = Asunto;
                mail.IsBodyHtml = true;
                mail.Body = Mensaje;

                SmtpClient client = new SmtpClient();
                client.Host = CorreoConfig["Host"];
                client.Port = Convert.ToInt32(CorreoConfig["Port"]);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(CorreoConfig["Usuario"], CorreoConfig["Contrasena"]);

                client.Send(mail);
            }
            catch (Exception ex)
            {
                Error = true;
            }

            return !Error;
        }

        public static bool EnviarCorreoPlantilla(MailAddressCollection Destinatarios, string Asunto, string Titulo, string Nombre, string Contenido, string Accion)
        {
            bool Error = false;
            string DirectorioPrincipal = ConfigurationManager.AppSettings["DirectorioPrincipal"].ToString();
            string UrlPrincipalApp = ConfigurationManager.AppSettings["UrlPrincipalApp"].ToString();
            try
            {
                #region Datos del Correo
                NameValueCollection CorreoConfig = (NameValueCollection)ConfigurationManager.GetSection("CorreoConfig");
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(CorreoConfig["From"].ToString(), CorreoConfig["FromName"].ToString());

                foreach (MailAddress para in Destinatarios)
                {
                    mail.To.Add(para);
                }

                mail.Subject = Asunto;
                mail.IsBodyHtml = true;
                #endregion

                #region Cuerpo del Correo
                mail.Body = System.IO.File.ReadAllText(DirectorioPrincipal + "template\\Correo.html")
                                .Replace("{{Titulo}}", Titulo)
                                .Replace("{{Nombre}}", Nombre)
                                .Replace("{{Contenido}}", Contenido)
                                .Replace("{{Accion}}", Accion)
                                .Replace("{{UrlPrincipal}}", UrlPrincipalApp);
                #endregion

                #region Configuración de envío
                SmtpClient client = new SmtpClient();
                client.Host = CorreoConfig["Host"];
                client.Port = Convert.ToInt32(CorreoConfig["Port"]);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(CorreoConfig["Usuario"], CorreoConfig["Contrasena"]);
                #endregion

                client.Send(mail);
            }
            catch (Exception ex)
            {
                Error = true;
            }

            return !Error;
        }
    }
}