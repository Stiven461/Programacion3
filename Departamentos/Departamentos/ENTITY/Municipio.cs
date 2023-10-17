using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Municipio
    {

        public int idMunicipio {  get; set; }
        public string nombreMunicipio { get; set;}
        public Departamento departamento { get; set; }

        public Municipio() { 
        
        }
    }
}
