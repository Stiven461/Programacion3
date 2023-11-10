using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario: Persona
    {

        public string UserName { get; set; }
        public string password {  get; set; }
        public string tipoUsuario { get; set; }

        public Usuario() 
        {
        
        }
        public Usuario(int cedula, string nombre, string apellido, int telefono) 
            :base(cedula,nombre,apellido,telefono) 
        {
            
        }

    }
}
