using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class EntityBase
    {
        public EntityBase()
        {
            FechaCreacion = DateTime.Now;
            FechaModificacion = DateTime.Now;

            foreach (var prop in this.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(string))
                {
                    prop.SetValue(this, string.Empty);
                }
            }
        }

        public uint UsuarioCreacionId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public uint UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
        public uint? UsuarioBajaId { get; set; }
        public DateTime? FechaBaja { get; set; }
        public bool? Baja { get; set; }
    }
}
