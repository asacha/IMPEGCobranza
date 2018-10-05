using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessData.IMPEG.Cobranza
{
    public class admDocumentos : Conexion.ConexionSQL
    {
        public admDocumentos()
        {
            NombreConexion = "cxnCobranza";
        }

        public BusinessEntity.DataHandler Consultar(BusinessEntity.QueryOptions Opcion, BusinessEntity.IMPEG.Cobranza.admDocumentos oBE)
        {
            BusinessEntity.DataHandler oDataHandler = new BusinessEntity.DataHandler();

            try
            {
                DataSet Resultado = new DataSet();
                oComando.CommandText = "Cobranza.spadmDocumentos_Consultar";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@Opcion", System.Data.SqlDbType.SmallInt);
                oParametro.Value = (short)Opcion;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIDDOCUMENTO", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIDDOCUMENTO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIDDOCUMENTODE", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIDDOCUMENTODE;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIDCONCEPTODOCUMENTO", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIDCONCEPTODOCUMENTO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CSERIEDOCUMENTO", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CSERIEDOCUMENTO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CFOLIO", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CFOLIO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CFECHA", System.Data.SqlDbType.DateTime);
                oParametro.Value = oBE.CFECHA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIDCLIENTEPROVEEDOR", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIDCLIENTEPROVEEDOR;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CRAZONSOCIAL", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CRAZONSOCIAL;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CRFC", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CRFC;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIDAGENTE", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIDAGENTE;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CFECHAVENCIMIENTO", System.Data.SqlDbType.DateTime);
                oParametro.Value = oBE.CFECHAVENCIMIENTO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CFECHAPRONTOPAGO", System.Data.SqlDbType.DateTime);
                oParametro.Value = oBE.CFECHAPRONTOPAGO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CFECHAENTREGARECEPCION", System.Data.SqlDbType.DateTime);
                oParametro.Value = oBE.CFECHAENTREGARECEPCION;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CFECHAULTIMOINTERES", System.Data.SqlDbType.DateTime);
                oParametro.Value = oBE.CFECHAULTIMOINTERES;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIDMONEDA", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIDMONEDA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CTIPOCAMBIO", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CTIPOCAMBIO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CREFERENCIA", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CREFERENCIA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CNATURALEZA", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CNATURALEZA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIDDOCUMENTOORIGEN", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIDDOCUMENTOORIGEN;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CPLANTILLA", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CPLANTILLA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CUSACLIENTE", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CUSACLIENTE;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CUSAPROVEEDOR", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CUSAPROVEEDOR;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CAFECTADO", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CAFECTADO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIMPRESO", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIMPRESO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CCANCELADO", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CCANCELADO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CDEVUELTO", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CDEVUELTO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIDPREPOLIZA", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIDPREPOLIZA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIDPREPOLIZACANCELACION", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIDPREPOLIZACANCELACION;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CESTADOCONTABLE", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CESTADOCONTABLE;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CNETO", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CNETO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIMPUESTO1", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CIMPUESTO1;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIMPUESTO2", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CIMPUESTO2;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIMPUESTO3", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CIMPUESTO3;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CRETENCION1", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CRETENCION1;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CRETENCION2", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CRETENCION2;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CDESCUENTOMOV", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CDESCUENTOMOV;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CDESCUENTODOC1", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CDESCUENTODOC1;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CDESCUENTODOC2", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CDESCUENTODOC2;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CGASTO1", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CGASTO1;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CGASTO2", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CGASTO2;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CGASTO3", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CGASTO3;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CTOTAL", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CTOTAL;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CPENDIENTE", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CPENDIENTE;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CTOTALUNIDADES", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CTOTALUNIDADES;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CDESCUENTOPRONTOPAGO", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CDESCUENTOPRONTOPAGO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJEIMPUESTO1", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CPORCENTAJEIMPUESTO1;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJEIMPUESTO2", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CPORCENTAJEIMPUESTO2;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJEIMPUESTO3", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CPORCENTAJEIMPUESTO3;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJERETENCION1", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CPORCENTAJERETENCION1;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJERETENCION2", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CPORCENTAJERETENCION2;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJEINTERES", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CPORCENTAJEINTERES;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CTEXTOEXTRA1", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CTEXTOEXTRA1;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CTEXTOEXTRA2", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CTEXTOEXTRA2;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CTEXTOEXTRA3", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CTEXTOEXTRA3;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CFECHAEXTRA", System.Data.SqlDbType.DateTime);
                oParametro.Value = oBE.CFECHAEXTRA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIMPORTEEXTRA1", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CIMPORTEEXTRA1;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIMPORTEEXTRA2", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CIMPORTEEXTRA2;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIMPORTEEXTRA3", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CIMPORTEEXTRA3;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIMPORTEEXTRA4", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CIMPORTEEXTRA4;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CDESTINATARIO", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CDESTINATARIO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CNUMEROGUIA", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CNUMEROGUIA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CMENSAJERIA", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CMENSAJERIA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CCUENTAMENSAJERIA", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CCUENTAMENSAJERIA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CNUMEROCAJAS", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CNUMEROCAJAS;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CPESO", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CPESO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CBANOBSERVACIONES", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CBANOBSERVACIONES;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CBANDATOSENVIO", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CBANDATOSENVIO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CBANCONDICIONESCREDITO", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CBANCONDICIONESCREDITO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CBANGASTOS", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CBANGASTOS;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CUNIDADESPENDIENTES", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CUNIDADESPENDIENTES;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CTIMESTAMP", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CTIMESTAMP;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIMPCHEQPAQ", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CIMPCHEQPAQ;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CSISTORIG", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CSISTORIG;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIDMONEDCA", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIDMONEDCA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CTIPOCAMCA", System.Data.SqlDbType.Float);
                oParametro.Value = oBE.CTIPOCAMCA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CESCFD", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CESCFD;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CTIENECFD", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CTIENECFD;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CLUGAREXPE", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CLUGAREXPE;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CMETODOPAG", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CMETODOPAG;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CNUMPARCIA", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CNUMPARCIA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CCANTPARCI", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CCANTPARCI;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CCONDIPAGO", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CCONDIPAGO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CNUMCTAPAG", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CNUMCTAPAG;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CGUIDDOCUMENTO", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CGUIDDOCUMENTO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CUSUARIO", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CUSUARIO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIDPROYECTO", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIDPROYECTO;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CIDCUENTA", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.CIDCUENTA;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@CTRANSACTIONID", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.CTRANSACTIONID;
                oComando.Parameters.Add(oParametro);

                if (this.Conectar())
                {
                    SqlDataAdapter daResultado = new SqlDataAdapter(oComando);
                    daResultado.Fill(oDataHandler.Resultado);
                    Desconectar();
                }
            }
            catch (Exception ex)
            {
                oDataHandler.Error = true;
                oDataHandler.MensajeError = ex.Message;
            }

            return oDataHandler;

        }
    }
}
