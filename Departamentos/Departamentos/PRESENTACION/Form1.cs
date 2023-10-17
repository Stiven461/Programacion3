using BLL.Service;
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
        private static DepartamentoService service = new DepartamentoService();

        public Form1()
        {
            InitializeComponent();
            llenarTablaDepar();
            llenarTablaMuni();
            llenarCmb();
        }

        private void btnCrearDepar_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento();

            departamento.idDepartamento = int.Parse(txtIdDepar.Text);
            departamento.nombreDepartamento = txtNombreDepar.Text;

            if (service.CrearDepartamento(departamento))
            {
                MessageBox.Show("Departamento creado");
            }
            else
            {
                MessageBox.Show("Error al crear");
            }

            limpiar();
        }


        void limpiar()
        {
            txtIdDepar.Text = string.Empty;
            txtIdMuni.Text = string.Empty;
            txtNombreDepar.Text = string.Empty;
            txtNombreMuni.Text = string.Empty;
            cmbDepar.Text = "Seleccionar";

            llenarTablaDepar();
            llenarTablaMuni();
            llenarCmb();
        }

        List<string> lista()
        {
            List<string> nombres = new List<string>();
            foreach (Departamento d in service.departamentos())
            {
                nombres.Add(d.nombreDepartamento);
            }

            return nombres;
        }

        void llenarCmb()
        {
           cmbDepar.DataSource = lista();
        }

        private void btnCrearMuni_Click(object sender, EventArgs e)
        {
           
            Municipio municipio = new Municipio();

            municipio.idMunicipio = int.Parse(txtIdMuni.Text);
            municipio.nombreMunicipio = txtNombreMuni.Text;

            municipio.departamento = service.buscarDepartamento(cmbDepar.Text);

            if (service.CrearMunicipio(municipio))
            {
                MessageBox.Show("Municipio creado");
            }
            else
            {
                MessageBox.Show("Error al crear el municipio");
            }

            limpiar();
        }


        void llenarTablaDepar()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");

            tblDepar.DataSource = dt;
            foreach (Departamento d in service.departamentos())
            {
                DataRow dr = dt.NewRow();
                dr[0] = d.idDepartamento;
                dr[1] = d.nombreDepartamento;
                dt.Rows.Add(dr);
            }     
        }

        void llenarTablaMuni()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Departamento");

            tblMuni.DataSource = dt;
            foreach (Municipio m in service.municipios())
            {
                DataRow dr = dt.NewRow();
                dr[0] = m.idMunicipio;
                dr[1] = m.nombreMunicipio;
                dr[2] = m.departamento.nombreDepartamento;
                dt.Rows.Add(dr);
            }
        }
    }
}
