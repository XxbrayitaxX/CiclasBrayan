using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entity
{
    public class ProveedorEntity
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string tipo { get; set; }
        public string correo { get; set; }
    }
}
