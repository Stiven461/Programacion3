using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persona = new ENTITY.Persona(1,"johnp",30,"M",75);
            var persona2 = new ENTITY.Persona(2, "maria", 30, "M", 75);
            var persona3 = new ENTITY.Persona(3, "prdro", 35, "M", 75);
            var reposotorio = new DAL.PersonaRepository();
            //reposotorio.Guardar(persona);
            //reposotorio.Guardar(persona2);
            //reposotorio.Guardar(persona3);
            var personas = reposotorio.ConsultarTodos();

            Console.WriteLine("idetificacion\t\tnombre\t\t Sexo");
            foreach (var item in personas)
            {
                Console.WriteLine($"\t{item.Identificacion} \t\t {item.Nombre}  \t {item.Sexo}");
            }

            Console.WriteLine("*****************************");
            personas.RemoveAt(1);
            Console.WriteLine(reposotorio.Guardar(personas));
            Console.WriteLine("*****************************");
            Console.WriteLine("idetificacion\t\tnombre\t\t Sexo");
            foreach (var item in personas)
            {
                Console.WriteLine($"\t{item.Identificacion} \t\t {item.Nombre}  \t {item.Sexo}");
            }
            Console.ReadKey();
        }
    }
}
