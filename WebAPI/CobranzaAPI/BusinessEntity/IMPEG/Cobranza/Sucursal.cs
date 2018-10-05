using System;
using System.Data;

namespace BusinessEntity.IMPEG.Cobranza
{
    public class Sucursal : EntityBase
	{
        public Sucursal()
		{
			_SucursalDescripcion = string.Empty;
			_Clave = string.Empty;
		}

		System.Int32 _SucursalId;
		public System.Int32 SucursalId { get { return _SucursalId; } set { if (value >= 0) _SucursalId = value; } }

		System.String _SucursalDescripcion;
		public System.String SucursalDescripcion { get { return _SucursalDescripcion; } set { if (value.Length >= 100) _SucursalDescripcion = value.Substring(0, 100); else _SucursalDescripcion = value; } }

		System.String _Clave;
		public System.String Clave { get { return _Clave; } set { if (value.Length >= 100) _Clave = value.Substring(0, 100); else _Clave = value; } }

	}
}
