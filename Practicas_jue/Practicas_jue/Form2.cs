using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas_jue
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button12.Text == " ")
            {
                button12.Text = button16.Text;
                button16.Text = String.Empty;
                return;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vaidarVacios(button2, button1);
            vaidarVacios(button2, button3);
            vaidarVacios(button2, button6);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //if (button16.Text == "")
            // {
            //    button16.Text = button12.Text;
            //    button12.Text = "";
            //    return;

            //}
            vaidarVacios(button12,button16);
          
        }

        public void vaidarVacios(Button boton1, Button boton2)
        {
            if (boton2.Text == "")
            {
                boton2.Text = boton1.Text;
                boton1.Text = "";
                return;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            vaidarVacios(button8, button12);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vaidarVacios(button4, button8);
            vaidarVacios(button4, button3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vaidarVacios(button3, button4);
            vaidarVacios(button3, button2);
            vaidarVacios(button3, button7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vaidarVacios(button1, button2);
            vaidarVacios(button1, button5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vaidarVacios(button5, button1);
            vaidarVacios(button5, button6);
            vaidarVacios(button5, button9);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vaidarVacios(button6, button2);
            vaidarVacios(button6, button5);
            vaidarVacios(button6, button7);
            vaidarVacios(button6, button10);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            vaidarVacios(button7, button3);
            vaidarVacios(button7, button6);
            vaidarVacios(button7, button8);
            vaidarVacios(button7, button11);
        }
    }
}
