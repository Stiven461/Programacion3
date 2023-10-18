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
    public class ServicioVenta
    {
        private readonly RepositorioProducto repositorioProducto;
        private readonly RepositorioVenta repositorioVenta;
        public ServicioVenta()
        {
            repositorioVenta = new RepositorioVenta();
            repositorioProducto = new RepositorioProducto();
        }


        public bool Agregar(Venta venta) 
        {
            if (venta.cantidad > venta.producto.existencia)
            {
                MessageBox.Show($"Cantidad no disponible: disponible {venta.producto.existencia}");
                return false;
            }
            else
            {
                venta.valorPagar = valorPagar(venta);
                if (repositorioVenta.Crear(venta))
                {
                    repositorioProducto.Modificar(venta.producto);
                    MessageBox.Show("Venta agregada");
                    return true;
                }
                return true;
            }
        }


        private decimal valorPagar(Venta v)
        {
            decimal valor = v.cantidad * v.producto.precio;
            return valor;
        }
    }
}
