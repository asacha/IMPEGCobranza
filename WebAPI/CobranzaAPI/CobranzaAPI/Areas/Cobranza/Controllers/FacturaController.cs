using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace CobranzaAPI.Areas.Cobranza.Controllers
{
    public class FacturaController : ApiController
    {
        [HttpGet]
        public JsonResult<ListaFacturaRespuesta> obtenerFacturas(string Token, string NumeroCliente)
        {
            ListaFacturaRespuesta respuesta = new ListaFacturaRespuesta(false, 0, string.Empty);

            //Validar Token
            if (!BusinessLogic.Validacion.TokenValido(Token))
            {
                respuesta = new ListaFacturaRespuesta(true, 2010, "Token no válido");
                return Json(respuesta);
            }

            //llamar a BD y obtener las facturas por cliente
            #region Código simulado
            respuesta.Facturas.Add(new FacturaEncabezado("7AF1129B", "EG Transportes", "EPA070313S59", 15000, "2018-09-26 10:19:59"));
            respuesta.Facturas.Add(new FacturaEncabezado("525D4401", "EG Transportes", "EPA070313S59", 18520, "2018-09-20 16:45:15"));
            respuesta.Facturas.Add(new FacturaEncabezado("87367E06", "EG Transportes", "EPA070313S59", 14526, "2018-09-10 09:23:28"));
            #endregion

            return Json(respuesta);
        }
    }

    public class ListaFacturaRespuesta
    {
        public ListaFacturaRespuesta(bool error, int errorId, string mensajeError)
        {
            Error = error;
            ErrorId = errorId;
            MensajeError = mensajeError;
            Facturas = new List<FacturaEncabezado>();
        }

        public bool Error { get; set; }
        public int ErrorId { get; set; }
        public string MensajeError { get; set; }

        public List<FacturaEncabezado> Facturas { get; set; }
    }

    public class FacturaEncabezado
    {
        public FacturaEncabezado(string numero, string empresa, string rFC, double total, string fechaEmision)
        {
            Numero = numero;
            Empresa = empresa;
            RFC = rFC;
            Total = total;
            FechaEmision = fechaEmision;
        }

        public string Numero { get; set; }
        public string Empresa { get; set; }
        public string RFC { get; set; }
        public double Total { get; set; }
        public string FechaEmision { get; set; }
    }
}
