using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class DataHandler
    {
        public DataHandler()
        {
            Resultado = new System.Data.DataSet();
            Error = false;
            MensajeError = string.Empty;
        }

        public System.Data.DataSet Resultado { get; set; }

        public bool ContieneInformacion
        {
            get
            {
                if (Resultado != null)
                {
                    foreach (System.Data.DataTable dt in Resultado.Tables)
                    {
                        foreach (System.Data.DataRow dr in dt.Rows)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
        }

        public string MensajeError { get; set; }
        public bool Error { get; set; }
    }
}
