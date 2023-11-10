using BLL.Services;
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
        static ServicioUsuario servicioUsuario = new ServicioUsuario(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.cedula = 1;
            usuario.nombre = "dsd";
            usuario.apellido = "ddd";
            usuario.telefono = 22;
            usuario.UserName = txtUserName.Text;
            usuario.password = txtPass.Text;
            usuario.tipoUsuario = "admin";


            if (servicioUsuario.Login(usuario))
            {
                MessageBox.Show("Sesion iniciada correctamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
