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
    public partial class Form3 : Form
    {
        public int x = 0;
        public int y = 0;

        public string nombrej1 = "";
        public string piedrasj1 = "";
        public string nombrej2 = "";
        public string piedrasj2 = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string seleccion = (string)comboBox_piedrasj1.SelectedItem;
                if (seleccion == "Piedras negras")
                {
                    piedrasj1 = "Negras";
                    piedrasj2 = "Blancas";
                }
                else
                {
                    piedrasj1 = "Blancas";
                    piedrasj2 = "Negras";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: datos erroneos.");
            }

            nombrej1 = textBox_nombrej1.Text;
            piedrasj1 = Convert.ToString(piedrasj1);
            nombrej2 = textBox_nombrej2.Text;
            piedrasj2 = Convert.ToString(piedrasj2);

            /*en este caso, el form 3 es un formulario que se "deriva" o "nace" a partir del form2, por lo que el form 3 actuaria como el hijo
             y el form 2 actuaria como el padre. Para enviar la informacion del formulario hijo al padre, se crea la referencia de abajo.*/

            Form2 parent = (Form2)this.Owner; //aqui se crea la referencia al Form padre, que en este caso es el form 2.
            parent.ObtenerDatosJugadores(nombrej1, nombrej2, piedrasj1, piedrasj2, pictureBox_avatarj1.Image, pictureBox_avatarj2.Image);
            this.Close();
        }

        private void button_avatarj1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;)|*.jpg;*.jpeg;.*.gif;.*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_avatarj1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void button_avatarj2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_avatarj2.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
