using DAL.Interface;
using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class RepositorioDepartamento : IDepartamentoRepositorio
    {
        private readonly string FileName = "Departamentos.txt";

        public bool Crear(Departamento departamento)
        {
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine($"{departamento.idDepartamento};{departamento.nombreDepartamento}");
                writer.Close();
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el departamento: {ex.Message}");
                return false;
            }
        }

        public Departamento BuscarDepartamento(int idDepartamento)
        {
            try
            {
                List<Departamento> lista = departamentos();
                foreach (var deparatamento in lista)
                {
                    if (idDepartamento == deparatamento.idDepartamento)
                    {
                        return deparatamento;
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

        public Departamento BuscarDepartamento(string nombre)
        {
            try
            {
                List<Departamento> lista = departamentos();
                foreach (var deparatamento in lista)
                {
                    if (nombre == deparatamento.nombreDepartamento)
                    {
                        return deparatamento;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar por nombre: {ex.Message}");
                return null;
            }
        }



        public List<Departamento> departamentos()
        {
            List<Departamento> departamentos = new List<Departamento>();
            try
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string linea = string.Empty;
                while ((linea = reader.ReadLine()) != null)
                {
                    Departamento departamento = Map(linea);
                    departamentos.Add(departamento);
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar los departamentos: {ex.Message}");
            }
            return departamentos;
        }

        private Departamento Map(String linea)
        {
            try
            {
                Departamento departamento = new Departamento();
                char delimiter = ';';
                string[] matrizDepartamento = linea.Split(delimiter);
                departamento.idDepartamento = int.Parse(matrizDepartamento[0]);
                departamento.nombreDepartamento = matrizDepartamento[1];
                return departamento;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mapear: {ex.Message}");
                return null;
            }
        }
    }

}
