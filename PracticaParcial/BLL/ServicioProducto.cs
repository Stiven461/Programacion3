using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class ServicioProducto
    {

        private readonly RepositorioProducto repositorioProducto;

        public ServicioProducto()
        {
            repositorioProducto = new RepositorioProducto();
        }
        public bool Crear(Producto producto)
        {
            try
            {
                Producto productoAnterior = repositorioProducto.buscarProducto(producto.referencia);
                if (productoAnterior != null)
                {
                    MessageBox.Show("No se puede crear este producto, debido a que ya existe uno con esta identificacion");
                    return false;
                }

                repositorioProducto.Crear(producto);
                MessageBox.Show($"El producto {producto.nombre} se ha creado correctamente");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el producto: {ex.Message}");
                return false;
            }
        }
        public Producto bucarProducto(int referencia)
        {
            return repositorioProducto.buscarProducto(referencia);
        }
        public Producto bucarProducto(string nombre)
        {
            return repositorioProducto.buscarProducto(nombre);
        }

        public bool Modificar(Producto producto)
        {
            return repositorioProducto.Modificar(producto);
        }

        public bool Eliminar(int referencia)
        {
            try
            {
                Producto producto = repositorioProducto.buscarProducto(referencia);
                if (producto != null)
                {
                    repositorioProducto.Eliminar(referencia);
                    MessageBox.Show($"Se ha eliminado el producto numero {producto.referencia}");
                    return true;
                }
                else
                {
                    MessageBox.Show($"El producto de numero {producto.referencia} No se encuentra registrado");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error con la funcion eliminar {ex.Message}");
                return false;
            }
        }

        public List<Producto> listaProductos() {
            
            return repositorioProducto.listaProductos();
        }

        public List<Producto> filtradoNombre(string nombre)
        {
            List<Producto> filtrado = new List<Producto>();

            foreach (Producto p in repositorioProducto.listaProductos())
            {
                if (nombre == p.nombre)
                {
                    filtrado.Add(p);
                }
            }

            return filtrado;
        }


    }

}
    