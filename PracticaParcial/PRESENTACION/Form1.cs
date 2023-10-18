using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class Form1 : Form
    {
        private static ServicioProducto servicioProducto = new ServicioProducto();

        public Form1()
        {
            InitializeComponent();
            cmbEstado.SelectedIndex = 0;
            limpiarTextos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = tblProductos.CurrentCell.RowIndex;

            txtReferencia.Text = tblProductos[0, fila].Value.ToString();
            txtNombre.Text = tblProductos[1, fila].Value.ToString();
            txtExistencia.Text = tblProductos[2, fila].Value.ToString();
            txtStock.Text = tblProductos[3, fila].Value.ToString();
            txtPrecio.Text = tblProductos[4, fila].Value.ToString();
            cmbEstado.Text = tblProductos[5, fila].Value.ToString();
        }

        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCrearP_Click(object sender, EventArgs e)
        {

            Producto p = new Producto();

            if (validarVacios())
            {
                p.referencia = int.Parse(txtReferencia.Text);
                p.nombre = txtNombre.Text;
                p.existencia = int.Parse(txtExistencia.Text);
                p.stockMini = int.Parse(txtStock.Text);
                p.precio = decimal.Parse(txtPrecio.Text);
                p.estado = cmbEstado.Text;
                if (servicioProducto.Crear(p))
                {
                    MessageBox.Show("Producto creado");
                }
                else
                {
                    MessageBox.Show("Error al crear el producto");
                }
                limpiarTextos();
            }
            else
            {
                MessageBox.Show("No se puede crear un producto si hay campos vacios");
            }

        }

        private void limpiarTextos()
        {
            txtReferencia.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtExistencia.Text = string.Empty;  
            txtStock.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            cmbEstado.SelectedIndex = 0;
            tablaProductos(servicioProducto.listaProductos());
        }

        private bool validarVacios()
        {
            if (txtReferencia.Text == string.Empty)
            {
                MessageBox.Show("Falta referencia");
                return false;
            }
            else if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Falta Nombre");
                return false;
            }
            else if (txtExistencia.Text == string.Empty)
            {
                MessageBox.Show("Falta existencia");
                return false;
            }
            else if (txtStock.Text == string.Empty)
            {
                MessageBox.Show("Falta stock minimo");
                return false;
            }
            else if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Falta precio unitario");
                return false;
            }
            else
                return true;
        }

        private void tablaProductos(List<Producto> lista)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Referencia");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Existencias");
            dt.Columns.Add("Stock");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Estado");

            tblProductos.DataSource = dt;

            foreach (Producto p in lista)
            {
                DataRow dr = dt.NewRow();
                dr[0] = p.referencia;
                dr[1] = p.nombre;
                dr[2] = p.existencia;
                dr[3] = p.stockMini;
                dr[4] = p.precio;
                dr[5] = p.estado;

                dt.Rows.Add(dr);
            }
        }

        private void txtFiltrarNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltrarNombre.Text == string.Empty)
            {
                tablaProductos(servicioProducto.listaProductos());
            }
            else
            {
                tablaProductos(servicioProducto.filtradoNombre(txtFiltrarNombre.Text));

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Producto p = new Producto();

            if (validarVacios())
            {
                p.referencia = int.Parse(txtReferencia.Text);
                p.nombre = txtNombre.Text;
                p.existencia = int.Parse(txtExistencia.Text);
                p.stockMini = int.Parse(txtStock.Text);
                p.precio = decimal.Parse(txtPrecio.Text);
                p.estado = cmbEstado.Text;
                if (servicioProducto.Modificar(p))
                {
                    MessageBox.Show("Producto Modificado");
                }
                else
                {
                    MessageBox.Show("Error al MOdificar el producto");
                }
                limpiarTextos();
            }
            else
            {
                MessageBox.Show("No se puede modificar un producto si hay campos vacios");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int referencia = int.Parse(txtReferencia.Text);
            if (servicioProducto.Eliminar(referencia))
            {
                MessageBox.Show("Producto Eliminado ");
                limpiarTextos();
            }
            else
            {
                MessageBox.Show(" No se pudo Eliminar el Producto");
            }
        }
    }
}
