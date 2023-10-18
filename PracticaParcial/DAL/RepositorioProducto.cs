using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class RepositorioProducto
    {

        private readonly string FileName = "Productos.txt";

        public bool Crear(Producto producto)
        {
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine($"{producto.referencia};{producto.nombre};{producto.existencia};{producto.stockMini};{producto.precio};{producto.estado}");
                writer.Close();
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el producto: {ex.Message}");
                return false;

            }
        }

        public Producto buscarProducto (int referencia)
        {
            try
            {
                List<Producto> productos = listaProductos();
                foreach (Producto p in productos)
                {
                    if (referencia == p.referencia)
                    {
                        return p;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar por referencia: {ex.Message}");
                return null;
            }
        }

        public Producto buscarProducto(string nombre)
        {
            try
            {
                List<Producto> productos = listaProductos();
                foreach (Producto p in productos)
                {
                    if (nombre == p.nombre)
                    {
                        return p;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar por nombre: {ex.Message}");
                return null;
            }
        }
        public bool Modificar(Producto producto)
        {
            List<Producto> productos = new List<Producto>();
            productos = listaProductos();

            try
            {
                FileStream file = new FileStream(FileName, FileMode.Create);
                file.Close();

                foreach (var productoAnterior in productos)
                {
                    if (productoAnterior.referencia != producto.referencia)
                    {
                        Crear(productoAnterior);
                    }
                    else
                        Crear(producto);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el producto: {ex.Message}");
                return false;
            }
        }

        public bool Eliminar(int referencia)
        {
            List<Producto> productos = new List<Producto>();
            productos = listaProductos();

            try
            {
                FileStream file = new FileStream(FileName, FileMode.Create);
                file.Close();

                foreach (var producto in productos)
                {
                    if (producto.referencia != referencia)
                    {
                        Crear(producto);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al elminar un producto: {ex.Message}");
                return false;
            }
        }
        public List<Producto> listaProductos()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string linea = string.Empty;
                while ((linea = reader.ReadLine()) != null)
                {
                    Producto producto = Map(linea);
                    productos.Add(producto);
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los productos: {ex.Message}");
            }
            return productos;
        }

        private Producto Map(String linea)
        {
            try
            {
                Producto producto = new Producto();
                char delimiter = ';';
                string[] matrizProducto = linea.Split(delimiter);
                producto.referencia = int.Parse(matrizProducto[0]);
                producto.nombre = matrizProducto[1];
                producto.existencia = int.Parse(matrizProducto[2]);
                producto.stockMini = int.Parse(matrizProducto[3]);
                producto.precio = decimal.Parse(matrizProducto[4]);
                producto.estado = matrizProducto[5];
                
                return producto;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mapear: {ex.Message}");
                return null;
            }
        }
    }
}
