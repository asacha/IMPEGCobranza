using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.IMPEG.dbo
{
    public class UsuarioToken : EntityBase
    {
        public UsuarioToken()
        {
            _Token = string.Empty;
        }

        System.Int32 _UsuarioTokenId;
        public System.Int32 UsuarioTokenId { get { return _UsuarioTokenId; } set { if (value >= 0) _UsuarioTokenId = value; } }

        System.Int32 _UsuarioId;
        public System.Int32 UsuarioId { get { return _UsuarioId; } set { if (value >= 0) _UsuarioId = value; } }

        System.String _Token;
        public System.String Token { get { return _Token; } set { if (value.Length >= 500) _Token = value.Substring(0, 500); else _Token = value; } }

    }
}
