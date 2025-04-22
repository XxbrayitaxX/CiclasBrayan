using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entity
{
    public class FacturaEntity
    {
        public int Id { get; set; }
        public int idVendedor { get; set; }
        public string cantidadP { get; set; }
        public string nombreP { get; set; }
        public int precioP { get; set; }
        public int total {  get; set; }

    }
}
