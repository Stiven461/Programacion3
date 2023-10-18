using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Producto
    {

        public int referencia { get; set; }
        public string nombre { get; set; }
        
        public int existencia { get; set;}
        public int stockMini { get; set; }
        public decimal precio { get; set; }
        public string  estado { get; set; }

        public Producto()
        {
        }

    }
}
