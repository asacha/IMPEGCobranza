using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class Util
    {
        /// <summary>
        /// Convierte un datatable en json
        /// </summary>
        /// <param name="dt">Datatable base</param>
        /// <returns>json</returns>
        public static string ConvertDataTabletoString(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                return "[]";
            }

            if (dt == null || dt.Rows.Count == 0)
            {
                return string.Empty;
            }

            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }

        public static string ConvertDataSetToString(DataSet ds)
        {
            var resultado = string.Empty;
            if (ds == null || ds.Tables.Count == 0)
            {
                return "[]";
            }

            foreach (DataTable dt in ds.Tables)
            {
                if (dt == null || dt.Rows.Count == 0)
                {
                    resultado += "~[]";
                }

                System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                serializer.MaxJsonLength = Int32.MaxValue;

                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                Dictionary<string, object> row;
                foreach (DataRow dr in dt.Rows)
                {
                    row = new Dictionary<string, object>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        row.Add(col.ColumnName, dr[col]);
                    }
                    rows.Add(row);
                }
                resultado += "~" + serializer.Serialize(rows);
            }

            if (resultado.Contains("~"))
            {
                return resultado.Substring(1);
            }
            else
            {
                return "[]";
            }
        }

        public static BusinessEntity.DataHandler Consultar(BusinessEntity.QueryOptions Opcion, dynamic oBE)
        {
            try
            {
                Type tipoBD = MapaClases.EntityToData(oBE);
                dynamic oBD = Activator.CreateInstance(tipoBD);

                return oBD.Consultar(Opcion, oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BusinessEntity.DataHandler Insertar(BusinessEntity.QueryOptions Opcion, dynamic oBE)
        {
            try
            {
                Type tipoBD = MapaClases.EntityToData(oBE);
                dynamic oBD = Activator.CreateInstance(tipoBD);

                return oBD.Insertar(Opcion, oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BusinessEntity.DataHandler Actualizar(BusinessEntity.QueryOptions Opcion, dynamic oBE)
        {
            try
            {
                Type tipoBD = MapaClases.EntityToData(oBE);
                dynamic oBD = Activator.CreateInstance(tipoBD);

                return oBD.Actualizar(Opcion, oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static byte[] GetBytes(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}
