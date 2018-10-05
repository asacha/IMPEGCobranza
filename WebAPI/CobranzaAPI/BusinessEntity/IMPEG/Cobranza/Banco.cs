using System;
using System.Data;

namespace BusinessEntity.IMPEG.Cobranza
{
    public class Banco : EntityBase
	{
        public Banco()
		{
			_BancoDescripcion = string.Empty;
			_Clave = string.Empty;
		}

		System.Int32 _BancoId;
		public System.Int32 BancoId { get { return _BancoId; } set { if (value >= 0) _BancoId = value; } }

		System.String _BancoDescripcion;
		public System.String BancoDescripcion { get { return _BancoDescripcion; } set { if (value.Length >= 100) _BancoDescripcion = value.Substring(0, 100); else _BancoDescripcion = value; } }

		System.String _Clave;
		public System.String Clave { get { return _Clave; } set { if (value.Length >= 100) _Clave = value.Substring(0, 100); else _Clave = value; } }

	}
}
