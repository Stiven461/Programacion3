using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.Repositorios
{
    public class RepositorioUsuario
    {

        private readonly string FileName = "Usuarios.txt";

        public bool Crear(Usuario usuario)
        {
            try
            { 
                FileStream file = new FileStream(FileName, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine($"{usuario.cedula};{usuario.nombre};{usuario.apellido};{usuario.telefono};{usuario.UserName};{usuario.password};{usuario.tipoUsuario}");
                writer.Close();
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear El usuario: {ex.Message}");
                return false;

            }
        }

        public Usuario buscarUsuario(int cedula)
        {
            try
            {
                foreach (var usuario in listaUsuarios())
                {
                    if (cedula == usuario.cedula)
                    {
                        return usuario;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar por cedula: {ex.Message}");
                return null;
            }
        }
        public List<Usuario> listaUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();    
            try
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string linea = string.Empty;
                while ((linea = reader.ReadLine()) != null)
                {
                    Usuario usuario = Map(linea);
                    usuarios.Add(usuario);
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los usuarios: {ex.Message}");
            }
            return usuarios;
        }
        private Usuario Map(String linea)
        {
            try
            {
                Usuario usuario = new Usuario();
                char delimiter = ';';
                string[] matrizUsuario = linea.Split(delimiter);
                usuario.cedula = int.Parse(matrizUsuario[0]);
                usuario.nombre = matrizUsuario[1];
                usuario.apellido = matrizUsuario[2];
                usuario.telefono = int.Parse((matrizUsuario[3]));
                usuario.UserName = matrizUsuario[4];
                usuario.password = matrizUsuario[5];
                usuario.tipoUsuario = matrizUsuario[6];
                return usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mapear: {ex.Message}");
                return null;
            }
        }
    }
}
