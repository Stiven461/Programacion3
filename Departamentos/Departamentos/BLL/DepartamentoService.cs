using DAL.Interface;
using DAL.Repositorios;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.Service
{
    public class DepartamentoService
    {
        private readonly RepositorioDepartamento repositorioDepartamento;
        private readonly RepositorioMunicipio repositorioMunicipio;

        public DepartamentoService()
        {
            repositorioDepartamento = new RepositorioDepartamento();
            repositorioMunicipio = new RepositorioMunicipio();
        }

        public bool CrearDepartamento(Departamento departamento)
        {
            try
            {
                Departamento departamentoAnterior = repositorioDepartamento.BuscarDepartamento(departamento.idDepartamento);
                if (departamentoAnterior != null)
                {
                    MessageBox.Show("No se puede crear este departamento, debido a que ya existe uno con este codigo");
                    return false;
                }
                repositorioDepartamento.Crear(departamento);
                MessageBox.Show($"El departamento {departamento.idDepartamento} se ha creado correctamente");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el departamento: {ex.Message}");
                return false;
            }
        }

        public Departamento buscarDepartamento(int idDepartamento)
        {
            return repositorioDepartamento.BuscarDepartamento(idDepartamento);
        }

        public Departamento buscarDepartamento(string nombre)
        {
            return repositorioDepartamento.BuscarDepartamento(nombre);
        }

        public List<Departamento> departamentos()
        {
            return repositorioDepartamento.departamentos();
        }

        public List<Municipio> listadoMunicipios(int codigo)
        {
            return repositorioMunicipio.departamentoAsociado(codigo);
        }

        public bool CrearMunicipio(Municipio municipio)
        {
            try
            {
                Municipio municipioAnterior = repositorioMunicipio.BuscarMunicipio(municipio.idMunicipio);
                if (municipioAnterior != null)
                {
                    MessageBox.Show("No se puede crear este municipio, debido a que ya existe uno con este codigo");
                    return false;
                }
                repositorioMunicipio.Crear(municipio);
                MessageBox.Show($"El Municipio {municipio.idMunicipio} se ha creado correctamente");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el municipio: {ex.Message}");
                return false;
            }
        }

        public Municipio buscarMunicipio(int idMunicipio)
        {
            return repositorioMunicipio.BuscarMunicipio(idMunicipio);
        }

        public List<Municipio> municipios()
        {
            return repositorioMunicipio.municipios();
        }

    }
}
