using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace CobranzaAPI.Areas.Catalogo.Controllers
{
    public class ListaController : ApiController
    {
        [HttpGet]
        public JsonResult<ListaSucursalResponse> obtenerSucursales(string Token)
        {
            ListaSucursalResponse respuesta = new ListaSucursalResponse(false, 0, string.Empty);

            //Validar Token
            if (!BusinessLogic.Validacion.TokenValido(Token))
            {
                respuesta = new ListaSucursalResponse(true, 9010, "Token no válido");
                return Json(respuesta);
            }

            //llamar a BD y obtener las Sucursales
            #region Código simulado
            respuesta.Sucursales.Add(new Sucursal(2080, "Toluca"));
            respuesta.Sucursales.Add(new Sucursal(5030, "Guadalajara"));
            respuesta.Sucursales.Add(new Sucursal(1025, "Monterrey"));
            #endregion

            return Json(respuesta);
        }

        [HttpGet]
        public JsonResult<ListaBancoResponse> obtenerBancos(string Token)
        {
            ListaBancoResponse respuesta = new ListaBancoResponse(false, 0, string.Empty);

            //Validar Token
            if (!BusinessLogic.Validacion.TokenValido(Token))
            {
                respuesta = new ListaBancoResponse(true, 9020, "Token no válido");
                return Json(respuesta);
            }

            //llamar a BD y obtener las Bancos
            #region Código simulado
            respuesta.Bancos.Add(new Banco(1, "BANREGIO", "1234"));
            respuesta.Bancos.Add(new Banco(2, "HSBC", "4567"));
            respuesta.Bancos.Add(new Banco(3, "BANORTE", "8569"));
            respuesta.Bancos.Add(new Banco(4, "BANAMEX", "7485"));
            respuesta.Bancos.Add(new Banco(5, "BANCOMER", "1402"));

            #endregion

            return Json(respuesta);
        }
    }

    public class ListaSucursalResponse
    {
        public ListaSucursalResponse(bool error, int errorId, string mensajeError)
        {
            Error = error;
            ErrorId = errorId;
            MensajeError = mensajeError;
            Sucursales = new List<Sucursal>();
        }

        public bool Error { get; set; }
        public int ErrorId { get; set; }
        public string MensajeError { get; set; }

        public List<Sucursal> Sucursales { get; set; }
    }

    public class ListaBancoResponse
    {
        public ListaBancoResponse(bool error, int errorId, string mensajeError)
        {
            Error = error;
            ErrorId = errorId;
            MensajeError = mensajeError;
            Bancos = new List<Banco>();
        }

        public bool Error { get; set; }
        public int ErrorId { get; set; }
        public string MensajeError { get; set; }

        public List<Banco> Bancos { get; set; }
    }

    public class Sucursal
    {
        public Sucursal(int sucursalId, string sucursalDescripcion)
        {
            SucursalId = sucursalId;
            SucursalDescripcion = sucursalDescripcion;
        }

        public int SucursalId { get; set; }
        public string SucursalDescripcion { get; set; }
    }

    public class Banco
    {
        public Banco(int bancoId, string bancoDescripcion, string clave)
        {
            BancoId = bancoId;
            BancoDescripcion = bancoDescripcion;
            Clave = clave;
        }

        public int BancoId { get; set; }
        public string BancoDescripcion { get; set; }
        public string Clave { get; set; }
    }
}
