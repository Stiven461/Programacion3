using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    {
        public int cedula {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int telefono { get; set; }


        public Persona()
        {

        }

        public Persona(int cedula, string nombre, string apellido, int telefono)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

    }
}
