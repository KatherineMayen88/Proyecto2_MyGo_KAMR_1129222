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

    public partial class Form2 : Form
    {
        public int posicion_x = 0;
        public int posicion_y = 0;
        public string nom1 = "";
        public string nom2 = "";
        public string pied1 = "";
        public string pied2 = "";
        public Image im1 = null;
        public Image im2 = null;


        public Form2()
        {
            InitializeComponent();
        }

        //constructor
        public Form2(int x, int y)
        {
            InitializeComponent();
            posicion_x = x;
            posicion_y = y;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(130, 0, 0, 0); //transparente negro
        }


        private void button_ingresar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(this);
            button_empezar.Enabled = true;
        }


        private void button_empezar_Click(object sender, EventArgs e)
        {
            Form4_tablero form_Tablero = new Form4_tablero(posicion_x, posicion_y, nom1, nom2, pied1, pied2, im1, im2);
            form_Tablero.Show(this);
        }


        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ObtenerDatosJugadores(string nombre1, string nombre2, string piedras1, string piedras2, Image pic1, Image pic2)
        {
            nom1 = Convert.ToString(nombre1);
            nom2 = Convert.ToString(nombre2);
            pied1 = Convert.ToString(piedras1);
            pied2 = Convert.ToString(piedras2);
            im1 = pic1;
            im2 = pic2;
        }
    }
}
