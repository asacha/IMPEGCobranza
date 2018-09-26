using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.IMPEG.dbo
{
    public class Usuario : EntityBase
    {
        public Usuario()
        {
            
        }

        System.Int32 _UsuarioId;
        public System.Int32 UsuarioId { get { return _UsuarioId; } set { if (value >= 0) _UsuarioId = value; } }

        System.String _Nombre;
        public System.String Nombre { get { return _Nombre; } set { if (value.Length >= 50) _Nombre = value.Substring(0, 50); else _Nombre = value; } }

        System.String _Paterno;
        public System.String Paterno { get { return _Paterno; } set { if (value.Length >= 50) _Paterno = value.Substring(0, 50); else _Paterno = value; } }

        System.String _Materno;
        public System.String Materno { get { return _Materno; } set { if (value.Length >= 50) _Materno = value.Substring(0, 50); else _Materno = value; } }

        System.String _Genero;
        public System.String Genero { get { return _Genero; } set { if (value.Length >= 1) _Genero = value.Substring(0, 1); else _Genero = value; } }

        System.String _Correo;
        public System.String Correo { get { return _Correo; } set { if (value.Length >= 120) _Correo = value.Substring(0, 120); else _Correo = value; } }

        System.String _NumeroCliente;
        public System.String NumeroCliente { get { return _NumeroCliente; } set { if (value.Length >= 50) _NumeroCliente = value.Substring(0, 50); else _NumeroCliente = value; } }

        System.String _Contrasena;
        public System.String Contrasena { get { return _Contrasena; } set { if (value.Length >= 20) _Contrasena = value.Substring(0, 20); else _Contrasena = value; } }
    }
}
