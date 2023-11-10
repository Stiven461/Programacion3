using DAL.Repositorios;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ServicioUsuario
    {
        private readonly RepositorioUsuario repositorio;
        public ServicioUsuario() 
        {
            repositorio = new RepositorioUsuario();
        }

        public string Crear(Usuario usuario)
        {
            try
            {
                Usuario usuarioAnterior = repositorio.buscarUsuario(usuario.cedula);
                if (usuarioAnterior != null)
                {
                    return ("No se puede crear este Usuario, debido a que ya existe uno con esta identificacion");
                }

                repositorio.Crear(usuario);
                return ($"El usuario {usuario.cedula} se ha creado correctamente");
            }
            catch (Exception ex)
            {
                return ($"Error al crear el usuario: {ex.Message}");
            }
        }

        public List<Usuario> listaUsuariosl() 
        {
            return repositorio.listaUsuarios();
        }

        public Usuario buscarUsuario(int cedula)
        {
            return repositorio.buscarUsuario(cedula);
        }


        public bool Login(Usuario usuario)
        {
            foreach (Usuario u in repositorio.listaUsuarios())
            {
                if (usuario.UserName == u.UserName && usuario.password == u.password)
                {
                    return true;
                }
                else 
                    return false;
            }
            return false;
        }

    }
}
