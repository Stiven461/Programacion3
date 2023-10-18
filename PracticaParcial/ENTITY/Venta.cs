using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Venta
    {

        public int idVenta { get; set; }
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public decimal valorPagar { get; set; }
        public Venta() 
        {

        }

    }
}
