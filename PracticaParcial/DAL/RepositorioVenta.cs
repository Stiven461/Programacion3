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
    public class RepositorioVenta
    {

        private readonly string FileName = "Ventas.txt";
        private readonly RepositorioProducto repositorio;
        public RepositorioVenta() { 
            repositorio = new RepositorioProducto();    
        }

        public bool Crear(Venta venta)
        {
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine($"{venta.idVenta};{venta.producto.referencia};{venta.cantidad};{venta.valorPagar}");
                writer.Close();
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la venta: {ex.Message}");
                return false;

            }
        }
        public List<Venta> listaVentas()
        {
            List<Venta> ventas = new List<Venta>();
            try
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string linea = string.Empty;
                while ((linea = reader.ReadLine()) != null)
                {
                    Venta venta = Map(linea);
                    ventas.Add(venta);
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar las ventas: {ex.Message}");
            }
            return ventas;
        }

        private Venta Map(String linea)
        {
            int referncia;
            try
            {
                Venta venta = new Venta();
                char delimiter = ';';
                string[] matrizVenta = linea.Split(delimiter);
                venta.idVenta = int.Parse(matrizVenta[0]);
                referncia = int.Parse(matrizVenta[1]);
                venta.producto = repositorio.buscarProducto(referncia);
                venta.cantidad = int.Parse(matrizVenta[2]);
                venta.valorPagar = decimal.Parse(matrizVenta[4]);
               
                return venta;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mapear: {ex.Message}");
                return null;
            }
        }
    }
}
