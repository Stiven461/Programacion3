using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ENTITY;
using System.Data;

namespace DAL
{
    public class PersonaRepository
    {
        string fileName = "persona.txt";
        public string Guardar(Persona persona)
        {
            //1 abrir el archivo
            StreamWriter escritor = new StreamWriter(fileName, true);
            
            //2 operaciones
            escritor.WriteLine(persona.ToString());

            // cerrar el flujo -  guardar
            escritor.Close();


            return $"datos guardadados ->  {persona.Nombre}";
        }
        public string Guardar(List<Persona> personas)
        {
         
            StreamWriter escritor = new StreamWriter(fileName,false);
            foreach (var item in personas)
            {
                escritor.WriteLine(item.ToString());
            }
           
            escritor .Close();
            return $"datos actualizados ";
        }

        public List<Persona> ConsultarTodos()
        {
            List<Persona > personas= new List<Persona>();
            StreamReader lector= new StreamReader(fileName);
            while (!lector.EndOfStream)
            {
               var linea= lector.ReadLine();
                personas.Add(Map(linea));
            }
            lector.Close(); 
            return personas;
        }

        private Persona Map(string linea)
        {
            var persona = new Persona();  
            persona.Identificacion= int.Parse(linea.Split(';')[0]);
            persona.Nombre  = linea.Split(';')[1];
            persona.Edad = int.Parse(linea.Split(';')[2]);
            persona.Sexo = linea.Split(';')[3];
            persona.Pulsacion = decimal.Parse(linea.Split(';')[4]);

            return persona;
        }
    }
}
