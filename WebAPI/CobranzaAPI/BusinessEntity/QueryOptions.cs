using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public enum QueryOptions
    {
        Consultar_PorId = 1,
        Consultar_PorFiltrosGenerales = 2,
        Consultar_ParaLista = 3,

        Consultar_IniciarSesion = 4,
        Consultar_TokenValido = 4,

        Insertar_General = 1,

        Actualizar_RegistroCompleto = 1,
        Actualizar_Baja = 2,
        Actualizar_Foto = 3
    }
}
