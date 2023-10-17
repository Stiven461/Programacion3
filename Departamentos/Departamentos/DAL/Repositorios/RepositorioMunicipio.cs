using DAL.Interface;
using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.Repositorios
{
    public class RepositorioMunicipio : IMunicipioRepositorio
    {
        private readonly string FileName = "Municipios.txt";
        private readonly RepositorioDepartamento repositorio;

        public RepositorioMunicipio()
        {
            repositorio = new RepositorioDepartamento();
        }

        public bool Crear(Municipio municipio)
        {
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine($"{municipio.idMunicipio};{municipio.nombreMunicipio};{municipio.departamento.idDepartamento}");
                writer.Close();
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el municipio: {ex.Message}");
                return false;
            }
        }

        public Municipio BuscarMunicipio(int idMunicipio)
        {
            try
            {
                List <Municipio> lista = municipios();
                foreach (var municipio in lista)
                {
                    if (idMunicipio == municipio.idMunicipio)
                    {
                        return municipio;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar por identificacion: {ex.Message}");
                return null;
            }
        }


        public List<Municipio> departamentoAsociado(int codigo)    // 1 -> cesar
        {                                                          // valledupar
            List<Municipio> listado = new List<Municipio>();
            foreach(var municipio in municipios())
            {
                if (municipio.departamento.idDepartamento == codigo)
                {
                    listado.Add(municipio);
                }
            }
            return listado;
        }

        public List<Municipio> municipios()
        {
            List<Municipio> municipios = new List<Municipio>();
            try
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string linea = string.Empty;
                while ((linea = reader.ReadLine()) != null)
                {
                    Municipio municipio = Map(linea);
                    municipios.Add(municipio);
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar los municipios: {ex.Message}");
            }
            return municipios;
        }

        private Municipio Map(String linea)
        { 
            int codigo;
            try
            {
                Municipio municipio = new Municipio();
                char delimiter = ';';                                          
                string[] matrizMunicipio = linea.Split(delimiter);
                municipio.idMunicipio = int.Parse(matrizMunicipio[0]);
                municipio.nombreMunicipio = matrizMunicipio[1];
                codigo = int.Parse(matrizMunicipio[2]);
                municipio.departamento = repositorio.BuscarDepartamento(codigo);
                
                return municipio;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mapear: {ex.Message}");
                return null;
            }
        }
    }
}
