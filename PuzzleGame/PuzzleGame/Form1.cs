using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        System.Timers.Timer tiempo;
        int h, m, s, ms;

        int cont;
        public Form1()
        {
            InitializeComponent();
        }

        public void reloj()
        {
            tiempo = new System.Timers.Timer();
            tiempo.Interval = 1;
            tiempo.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                ms += 1;
                if (ms == 100)
                {
                    ms = 0;
                    s += 1;
                }
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }

                label1.Text = string.Format("{0}:{1}:{2}:{3}", h.ToString().ToString().PadLeft(2,'0'), m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'), ms.ToString().ToString().PadLeft(2, '0'));

            }));
        }

        public void ValidarVacios(Button boton1, Button boton2)
        {
            if (boton2.Text == "")
            {
                boton2.Text = boton1.Text;
                boton1.Text = "";
            }
        }

        public void RevisarSolucion()
        {
            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" && btn4.Text == "4" && 
                btn5.Text == "5" && btn6.Text == "6" && btn7.Text == "7" && btn8.Text == "8" &&
                btn9.Text == "9" && btn10.Text == "10" && btn11.Text == "11" && btn12.Text == "12" &&
                btn13.Text == "13" && btn14.Text == "14" && btn15.Text == "15")
            {
                MessageBox.Show("! Bien hecho¡ Ganaste", "Puzzle Game",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            cont = cont + 1;
            textBox2.Text = "Numero de clicks "+cont.ToString();
        }

        public void Combinar()
        {
            int[] btnNumero = new int[16];
            int i,fila;
            Boolean resp = false;

            i = 1;
            do
            {
                Random random = new Random();
                fila = Convert.ToInt32((random.Next(0, 15)) + 1);

                for (int j = 1; j < i; j++)
                {
                    if (btnNumero[j] == fila)
                    {
                        resp = true;
                        break;
                    }
                }
                if (resp)
                {
                    resp = false;
                }
                else
                {
                    btnNumero[i] = fila;
                    i = i + 1;
                }
            } while (i <= 15);

            btn1.Text = Convert.ToString(btnNumero[1]);
            btn2.Text = Convert.ToString(btnNumero[2]);
            btn3.Text = Convert.ToString(btnNumero[3]);
            btn4.Text = Convert.ToString(btnNumero[4]);
            btn5.Text = Convert.ToString(btnNumero[5]);
            btn6.Text = Convert.ToString(btnNumero[6]);
            btn7.Text = Convert.ToString(btnNumero[7]);
            btn8.Text = Convert.ToString(btnNumero[8]);
            btn9.Text = Convert.ToString(btnNumero[9]);
            btn10.Text = Convert.ToString(btnNumero[10]);
            btn11.Text = Convert.ToString(btnNumero[11]);
            btn12.Text = Convert.ToString(btnNumero[12]);
            btn13.Text = Convert.ToString(btnNumero[13]);
            btn14.Text = Convert.ToString(btnNumero[14]);
            btn15.Text = Convert.ToString(btnNumero[15]);
            btnVacio.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea salir","Puzzle Game",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (salir == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea salir", "Puzzle Game", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (salir == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
        
        }
        private void button19_Click(object sender, EventArgs e)
        {
            btn1.Text = Convert.ToString(1);
            btn2.Text = Convert.ToString(2);
            btn3.Text = Convert.ToString(3);
            btn4.Text = Convert.ToString(4);
            btn5.Text = Convert.ToString(5);
            btn6.Text = Convert.ToString(6);
            btn7.Text = Convert.ToString(7);
            btn8.Text = Convert.ToString(8);
            btn9.Text = Convert.ToString(9);
            btn10.Text = Convert.ToString(10);
            btn11.Text = Convert.ToString(11);
            btn12.Text = Convert.ToString(12);
            btn13.Text = Convert.ToString(13);
            btn14.Text = Convert.ToString(14);
            btn15.Text = Convert.ToString(15);
            btnVacio.Text = " ";

            tiempo.Stop();
            MessageBox.Show("! Bien hecho¡ Ganaste", "Puzzle Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Combinar();
            reloj();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn1,btn2);
            ValidarVacios(btn1, btn5);
            RevisarSolucion();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn2, btn1);
            ValidarVacios(btn2, btn3);
            ValidarVacios(btn2, btn6);
            RevisarSolucion();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn3, btn2);
            ValidarVacios(btn3, btn4);
            ValidarVacios(btn3, btn7);
            RevisarSolucion();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn4, btn3);
            ValidarVacios(btn4, btn8);
            RevisarSolucion();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn5, btn1);
            ValidarVacios(btn5, btn6);
            ValidarVacios(btn5, btn9);
            RevisarSolucion();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn6, btn2);
            ValidarVacios(btn6, btn5);
            ValidarVacios(btn6, btn7);
            ValidarVacios(btn6, btn10);  
            RevisarSolucion();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn7, btn3);
            ValidarVacios(btn7, btn6);
            ValidarVacios(btn7, btn11);
            ValidarVacios(btn7, btn8);
            RevisarSolucion();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn8, btn4);
            ValidarVacios(btn8, btn7);
            ValidarVacios(btn8, btn12);
            RevisarSolucion();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn9, btn5);
            ValidarVacios(btn9, btn10);
            ValidarVacios(btn9, btn13);
            RevisarSolucion();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn10, btn6);
            ValidarVacios(btn10, btn9);
            ValidarVacios(btn10, btn11);
            ValidarVacios(btn10, btn14);
            RevisarSolucion();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn11, btn7);
            ValidarVacios(btn11, btn10);
            ValidarVacios(btn11, btn15);
            ValidarVacios(btn11, btn12);
            RevisarSolucion();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn12, btn8);
            ValidarVacios(btn12, btn11);
            ValidarVacios(btn12, btnVacio);
            RevisarSolucion();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn13, btn9);
            ValidarVacios(btn13, btn14);
            RevisarSolucion();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn14, btn13);
            ValidarVacios(btn14, btn10);
            ValidarVacios(btn14, btn15);
            RevisarSolucion();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            ValidarVacios(btn15, btn14);
            ValidarVacios(btn15, btn11);
            ValidarVacios(btn15, btnVacio);
            RevisarSolucion();
        }

        private void btnVacio_Click(object sender, EventArgs e)
        {
            ValidarVacios(btnVacio, btn12);
            ValidarVacios(btnVacio, btn15);
            RevisarSolucion();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Combinar();
            textBox2.Clear();

            this.Refresh();
            this.Hide();
            Form1 Nuevo = new Form1();
            Nuevo.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tiempo.Start();
            HabilitarBotones();

            if (btnTiempo.Text == "Pause")
            {
                tiempo.Stop();
                InhabilitarBotones();
                btnTiempo.Text = "Continue";
            }
            else if (btnTiempo.Text == "Continue")
            {
                tiempo.Start();
                HabilitarBotones();
                btnTiempo.Text = "Pause";
            }
            else
            {
                btnTiempo.Text = "Pause";
               
            }
        }

        public void HabilitarBotones()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn14.Enabled = true;
            btn15.Enabled = true;
            btnVacio.Enabled = true;
        }

        public void InhabilitarBotones()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn10.Enabled = false;
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn14.Enabled = false;
            btn15.Enabled = false;
            btnVacio.Enabled = false;
        }
    }
}
