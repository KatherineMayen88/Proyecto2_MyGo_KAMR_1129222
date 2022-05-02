using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2_MyGo_KAMR_1129222
{
    public partial class Form1 : Form
    {
        public int posicion_x = 0;
        public int posicion_y = 0;

        //constructor
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(130,0,0,0); //transparente negro
        }

        private void button_tablero9_Click(object sender, EventArgs e)
        {
            posicion_x = 9;
            posicion_y = 9;
            Form2 form2 = new Form2(posicion_x,posicion_y);
            form2.Show();
        }

        private void button_tablero13_Click(object sender, EventArgs e)
        {
            posicion_x = 13;
            posicion_y = 13;
            Form2 form2 = new Form2(posicion_x,posicion_y);
            form2.Show();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por participar!");
            Application.Exit();
        }
    }
}
