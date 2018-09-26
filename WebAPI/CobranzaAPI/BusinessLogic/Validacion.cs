using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class Validacion
    {
        public static bool CorreoValido(string Correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(Correo);
                return addr.Address == Correo;
            }
            catch
            {
                return false;
            }
        }

        public static bool TokenValido(string Token)
        {
            if (Token == null || Token.Trim().Length == 0)
            {
                return false;
            }

            BusinessEntity.IMPEG.dbo.UsuarioToken oUsuarioToken = new BusinessEntity.IMPEG.dbo.UsuarioToken();
            oUsuarioToken.Token = Token;

            BusinessEntity.DataHandler oDH = BusinessLogic.Util.Consultar(BusinessEntity.QueryOptions.Consultar_TokenValido, oUsuarioToken);

            if (oDH.Error || !oDH.ContieneInformacion)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
