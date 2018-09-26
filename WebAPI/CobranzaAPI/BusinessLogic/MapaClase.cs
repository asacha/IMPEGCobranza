using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal static class MapaClases
    {
        internal static dynamic EntityToData(object oBE)
        {
            Dictionary<object, object> BusinessDataList = new Dictionary<object, object>();

            BusinessDataList.Add(typeof(BusinessEntity.IMPEG.dbo.Usuario), typeof(BusinessData.IMPEG.dbo.Usuario));
            BusinessDataList.Add(typeof(BusinessEntity.IMPEG.dbo.UsuarioToken), typeof(BusinessData.IMPEG.dbo.UsuarioToken));
            dynamic valor;

            if (BusinessDataList.TryGetValue(oBE.GetType(), out valor))
            {
                return valor;
            }

            return typeof(object);
        }
    }
}
