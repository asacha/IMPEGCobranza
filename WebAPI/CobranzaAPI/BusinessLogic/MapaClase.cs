using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class MapaClases
    {
        public static dynamic EntityToData(object oBE)
        {
            Dictionary<object, object> BusinessDataList = new Dictionary<object, object>();

            #region dbo
            BusinessDataList.Add(typeof(BusinessEntity.IMPEG.dbo.Usuario), typeof(BusinessData.IMPEG.dbo.Usuario));
            BusinessDataList.Add(typeof(BusinessEntity.IMPEG.dbo.UsuarioToken), typeof(BusinessData.IMPEG.dbo.UsuarioToken));
            #endregion

            #region Cobranza
            BusinessDataList.Add(typeof(BusinessEntity.IMPEG.Cobranza.admClientes), typeof(BusinessData.IMPEG.Cobranza.admClientes));
            BusinessDataList.Add(typeof(BusinessEntity.IMPEG.Cobranza.admDocumentos), typeof(BusinessData.IMPEG.Cobranza.admDocumentos));
            BusinessDataList.Add(typeof(BusinessEntity.IMPEG.Cobranza.admMovimientos), typeof(BusinessData.IMPEG.Cobranza.admMovimientos));
            BusinessDataList.Add(typeof(BusinessEntity.IMPEG.Cobranza.Banco), typeof(BusinessData.IMPEG.Cobranza.Banco));
            BusinessDataList.Add(typeof(BusinessEntity.IMPEG.Cobranza.Sucursal), typeof(BusinessData.IMPEG.Cobranza.Sucursal));
            #endregion

            dynamic valor;

            if (BusinessDataList.TryGetValue(oBE.GetType(), out valor))
            {
                return valor;
            }

            return typeof(object);
        }
    }
}
