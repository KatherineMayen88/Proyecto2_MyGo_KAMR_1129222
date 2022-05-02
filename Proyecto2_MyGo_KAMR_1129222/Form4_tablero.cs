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

    public partial class Form4_tablero : Form
    {
        public bool turnojugador1 = false;

        public int posiciones_x = 0;
        public int posiciones_y = 0;

        public string nomj1 = "";
        public string nomj2 = "";
        public string piedrasj1 = "";
        public string piedrasj2 = "";
        public Image imgavatar1 = null;
        public Image imgavatar2 = null;

        public int punteo_fichasnegras = 0;
        public int punteo_fichasblancas = 0;
        public int contador_pasar = 0;

        public string ganador = "";
        public int punteo_ganador = 0;

        public custom_pictureBox[,] tablero;

        public Form4_tablero()
        {
            InitializeComponent();
        }

        //constructor
        public Form4_tablero(int x, int y, string nom1, string nom2, string piedras1, string piedras2, Image img1, Image img2)
        {
            this.posiciones_x = x;
            this.posiciones_y = y;
            tablero = new custom_pictureBox[posiciones_x, posiciones_y]; //creacion de arreglo de forma dinamica.
            nomj1 = nom1;
            nomj2 = nom2;
            piedrasj1 = piedras1;
            piedrasj2 = piedras2;
            imgavatar1 = img1;
            imgavatar2 = img2;
            generarTablero();
            InitializeComponent();

            //PARA PONER LAS MEDIDAS SEGUN SI EL TABLERO ES DE 13 o 9.
            if (posiciones_y == 9)
            {
                this.Size = new Size(840, 600);
                groupBox1.Left = posiciones_y * 57;
                groupBox2.Left = posiciones_y * 57;
                button_punteo.Left = posiciones_y * 57;
                button_pasar.Left = posiciones_y * 57;
                button_terminar.Left = posiciones_y * 57;
                label_puntos_fichasblancas.Left = posiciones_y * 57;
                label_puntos_fichasnegras.Left = posiciones_y * 57;
                label_turno.Left = posiciones_y * 57;
            }
            else
            {
                this.Size = new Size(1000, 780);
                groupBox1.Left = posiciones_y * 53;
                groupBox2.Left = posiciones_y * 53;
                button_pasar.Left = posiciones_y * 53;
                button_punteo.Left = posiciones_y * 53;
                button_terminar.Left = posiciones_y * 53;
                label_puntos_fichasblancas.Left = posiciones_y * 53;
                label_puntos_fichasnegras.Left = posiciones_y * 53;
                label_turno.Left = posiciones_y * 53;
            }

            //PARA IMPRIMIR
            label_nombrej1.Text = nom1;
            label_nombrej2.Text = nom2;
            label_piezasj1.Text = piedrasj1;
            label_piezasj2.Text = piedrasj2;
            pictureBox_avatar1.Image = img1;
            pictureBox_avatar2.Image = img2;
            pictureBox_avatar1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_avatar2.SizeMode = PictureBoxSizeMode.StretchImage;
            label_turno.Text = "TURNO: JUGADOR FICHAS NEGRAS";
        }

        public void generarTablero()
        {
            //para las columnas de y
            for (int j = 0; j < posiciones_y; j++)
            {
                //para crear las filas en x
                for (int i = 0; i < posiciones_x; i++)
                {
                    custom_pictureBox pb = new custom_pictureBox(); //creacion de objeto tipo custom_pictureBox 

                    this.Controls.Add(pb); //aqui se generan los picture box
                    pb.Top = (i + 1) * 60;
                    pb.Left = (j + 1) * 60;

                    pb.BackColor = SystemColors.ControlDark;
                    pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    pb.Width = 62;
                    pb.Height = 60;
                    pb.Click += onClick; //aqui es en donde llamamos al metodo de OnClick
                    pb.x = i;
                    pb.y = j;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    pb.Image = Properties.Resources.fondotablero;

                    tablero[i, j] = pb;
                }
            }
        }

        private void onClick(object sender, EventArgs e)
        {
            /*el objeto llamado sender se convierte a un objeto de tipo custom_pictureBox*/
            var pbactual = sender as custom_pictureBox;
            contador_pasar = 0;

            if (!turnojugador1) //! nos sirve para referirse si la variable booleana es falsa.
            {

                if (pbactual.color_ficha == 0 && pbactual.habilitada)
                {
                    pbactual.Image = Properties.Resources.fichanegra;
                    turnojugador1 = true;
                    pbactual.color_ficha = 1;
                    punteo_fichasnegras++;
                    label_turno.Text = "TURNO: JUGADOR FICHAS BLANCAS";
                }
                else
                {
                    MessageBox.Show("La casilla seleccionada no puede ser utilizada, escoja otra.");
                }
            }
            else
            {
                if (turnojugador1)
                {
                    if (pbactual.color_ficha == 0 && pbactual.habilitada)
                    {
                        //pbprueba.BackColor = Color.White;
                        pbactual.Image = Properties.Resources.fichablanca;
                        turnojugador1 = false;
                        pbactual.color_ficha = 2;
                        punteo_fichasblancas++;
                        label_turno.Text = "TURNO: JUGADOR FICHAS NEGRAS";
                    }
                    else
                    {
                        MessageBox.Show("La casilla seleccionada no puede ser utilizada, escoja otra.");
                    }
                }
            }
            recorrerTablero();
        }

        private void button_punteo_Click(object sender, EventArgs e)
        {
            recorrerTablero();
            label_puntos_fichasnegras.Text = "Fichas negras: " + punteo_fichasnegras;
            label_puntos_fichasblancas.Text = "Fichas blancas: " + punteo_fichasblancas;
        }

        private void button_pasar_Click(object sender, EventArgs e)
        {
            turnojugador1 = !turnojugador1;
            contador_pasar++;

            if (label_turno.Text == "TURNO: JUGADOR FICHAS NEGRAS")
            {
                label_turno.Text = "TURNO: JUGADOR FICHAS BLANCAS";
            }
            else
            {
                label_turno.Text = "TURNO: JUGADOR FICHAS NEGRAS";
            }

            //PARA CALCULAR QUIEN FUE EL GANADOR AL MOMENTO DE TERMINAR EL JUEGO.
            if (punteo_fichasnegras > punteo_fichasblancas)
            {
                ganador = "fichas negras";
                punteo_ganador = punteo_fichasnegras;
            }
            else
            {
                ganador = "fichas blancas";
                punteo_ganador = punteo_fichasblancas;
            }

            if (contador_pasar == 2)
            {
                string mensaje = "¿Desea regresar al menu principal?";
                string titulo = "FIN DEL JUEGO";
                MessageBox.Show("El ganador es el jugador con " + ganador + ", con una puntuacion de " + punteo_ganador + " puntos.", titulo);

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(mensaje, titulo, buttons);

                Form2 parent = (Form2)this.Owner; //aqui se crea la referencia al Form padre, que en este caso es el form 2.
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    parent.Close();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button_terminar_Click(object sender, EventArgs e)
        {
            if (punteo_fichasnegras > punteo_fichasblancas)
            {
                ganador = "fichas negras";
                punteo_ganador = punteo_fichasnegras;
            }
            else
            {
                ganador = "fichas blancas";
                punteo_ganador = punteo_fichasblancas;
            }

            string mensaje = "¿Desea regresar al menu principal?";
            string titulo = "FIN DEL JUEGO";
            MessageBox.Show("El ganador es el jugador con " + ganador + ", con una puntuacion de " + punteo_ganador + " puntos.", titulo);

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, buttons);

            Form2 parent = (Form2)this.Owner; //aqui se crea la referencia al Form padre, que en este caso es el form 2.
            if (result == DialogResult.Yes)
            {
                this.Close();
                parent.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        public void calcularPuntos(custom_pictureBox casilla)
        {
            custom_pictureBox casillaDerecha;
            custom_pictureBox casillaIzquierda;
            custom_pictureBox casillaAbajo;
            custom_pictureBox casillaArriba;

            int color_actual = casilla.color_ficha;
            int color_opuesto = 0;

            if (color_actual == 1)
            {
                color_opuesto = 2;
            }
            else if (color_actual == 2)
            {
                color_opuesto = 1;
            }

            //CASO 1: ESQUINA SUPERIOR IZQUIERDA
            if (casilla.x == 0 && casilla.y == 0)
            {
                casillaDerecha = tablero[0, 1];
                casillaAbajo = tablero[1, 0];

                if (casillaDerecha.color_ficha != 0 && casillaAbajo.color_ficha != 0)
                {
                    if (casillaDerecha.color_ficha == color_opuesto && casillaAbajo.color_ficha == color_opuesto && color_opuesto != 0)
                    {
                        casilla.Image = Properties.Resources.fichatablero;
                        casilla.color_ficha = 0;
                        casilla.habilitada = false;
                        actualizarPuntosCasillaOcupada(color_actual);
                    }
                    else if (color_actual == 0 && casilla.habilitada && casillaDerecha.color_ficha == casillaAbajo.color_ficha)
                    {
                        casilla.habilitada = false;
                        actualizarPuntosCasillaVacia(casillaDerecha.color_ficha);
                    }
                }
            }


            //CASO 2: ARRIBA EN EL CENTRO 
            else if (casilla.x == 0 && casilla.y > 0 && casilla.y < posiciones_y-1)
            {
                casillaIzquierda = tablero[0, casilla.y - 1];
                casillaAbajo = tablero[1, casilla.y];
                casillaDerecha = tablero [0, casilla.y + 1];

                if (casillaIzquierda.color_ficha != 0 && casillaAbajo.color_ficha != 0 && casillaDerecha.color_ficha != 0)
                {
                    if (casillaIzquierda.color_ficha == color_opuesto && casillaAbajo.color_ficha == color_opuesto && casillaDerecha.color_ficha == color_opuesto && color_opuesto != 0)
                    {
                        casilla.Image = Properties.Resources.fichatablero;
                        casilla.color_ficha = 0;
                        casilla.habilitada = false;
                        actualizarPuntosCasillaOcupada(color_actual);
                    }
                    else if (color_actual == 0 && casilla.habilitada && casillaIzquierda.color_ficha == casillaAbajo.color_ficha && casillaAbajo.color_ficha == casillaDerecha.color_ficha)
                    {
                        casilla.habilitada = false;
                        actualizarPuntosCasillaVacia(casillaIzquierda.color_ficha);
                    }
                } 
            }


            //CASO 3: ESQUINA SUPERIOR DERECHA 
            else if (casilla.x == 0 && casilla.y == posiciones_y-1)
            {
                casillaIzquierda = tablero[0, posiciones_y-2];
                casillaAbajo = tablero[1, posiciones_y-1];

                if (casillaIzquierda.color_ficha != 0 && casillaAbajo.color_ficha != 0)
                {
                    if (casillaIzquierda.color_ficha == color_opuesto && casillaAbajo.color_ficha == color_opuesto && color_opuesto != 0)
                    {
                        casilla.Image = Properties.Resources.fichatablero;
                        casilla.color_ficha = 0;
                        casilla.habilitada = false;
                        actualizarPuntosCasillaOcupada(color_actual);
                    }
                    else if (color_actual == 0 && casilla.habilitada && casillaIzquierda.color_ficha == casillaAbajo.color_ficha)
                    {
                        casilla.habilitada = false;
                        actualizarPuntosCasillaVacia(casillaIzquierda.color_ficha);
                    }
                }
            }


            //CASO 4: LADO IZQUIERDO
            else if (casilla.x > 0 && casilla.x < posiciones_x-1 && casilla.y == 0)
            {
                casillaArriba = tablero[casilla.x - 1, 0];
                casillaDerecha = tablero[casilla.x, 1];
                casillaAbajo = tablero[casilla.x + 1, 0];

                if (casillaArriba.color_ficha != 0 && casillaDerecha.color_ficha != 0 && casillaAbajo.color_ficha != 0)
                {
                    if (casillaArriba.color_ficha == color_opuesto && casillaDerecha.color_ficha == color_opuesto && casillaAbajo.color_ficha == color_opuesto && color_opuesto != 0)
                    {
                        casilla.Image = Properties.Resources.fichatablero;
                        casilla.color_ficha = 0;
                        casilla.habilitada = false;
                        actualizarPuntosCasillaOcupada(color_actual);
                    }
                    else if (color_actual == 0 && casilla.habilitada && casillaArriba.color_ficha == casillaDerecha.color_ficha && casillaDerecha.color_ficha == casillaAbajo.color_ficha)
                    {
                        casilla.habilitada = false;
                        actualizarPuntosCasillaVacia(casillaArriba.color_ficha);
                    }
                }
            }


            //CASO 5: EL CENTRO
            else if (casilla.x > 0 && casilla.x < posiciones_x-1 && casilla.y > 0 && casilla.y < posiciones_y-1)
            {
                casillaArriba = tablero[casilla.x - 1, casilla.y];
                casillaAbajo = tablero[casilla.x + 1, casilla.y];
                casillaIzquierda = tablero[casilla.x, casilla.y - 1];
                casillaDerecha = tablero[casilla.x, casilla.y + 1];

                if (casillaArriba.color_ficha != 0 && casillaAbajo.color_ficha != 0 && casillaIzquierda.color_ficha != 0 && casillaDerecha.color_ficha != 0)
                {
                    if (casillaArriba.color_ficha == color_opuesto && casillaAbajo.color_ficha == color_opuesto && casillaIzquierda.color_ficha == color_opuesto && casillaDerecha.color_ficha == color_opuesto && color_opuesto != 0)
                    {
                        casilla.Image = Properties.Resources.fichatablero;
                        casilla.color_ficha = 0;
                        casilla.habilitada = false;
                        actualizarPuntosCasillaOcupada(color_actual);
                    }
                    else if (color_actual == 0 && casilla.habilitada && casillaArriba.color_ficha == casillaAbajo.color_ficha && casillaAbajo.color_ficha == casillaIzquierda.color_ficha && casillaIzquierda.color_ficha == casillaDerecha.color_ficha)
                    {
                        casilla.habilitada = false;
                        actualizarPuntosCasillaVacia(casillaArriba.color_ficha);
                    }
                }
            }


            //CASO 6: LADO DERECHO
            else if (casilla.x > 0 && casilla.x < posiciones_x-1 && casilla.y == posiciones_y - 1)
            {
                casillaArriba = tablero[casilla.x - 1, posiciones_y - 1];
                casillaIzquierda = tablero[casilla.x, posiciones_y - 2];
                casillaAbajo = tablero[casilla.x + 1, posiciones_y - 1];

                if (casillaArriba.color_ficha != 0 && casillaIzquierda.color_ficha != 0 && casillaAbajo.color_ficha != 0)
                {
                    if (casillaArriba.color_ficha == color_opuesto && casillaIzquierda.color_ficha == color_opuesto && casillaAbajo.color_ficha == color_opuesto && color_opuesto != 0)
                    {
                        casilla.Image = Properties.Resources.fichatablero;
                        casilla.color_ficha = 0;
                        casilla.habilitada = false;
                        actualizarPuntosCasillaOcupada(color_actual);
                    }
                    else if (color_actual == 0 && casilla.habilitada && casillaArriba.color_ficha == casillaIzquierda.color_ficha && casillaIzquierda.color_ficha == casillaAbajo.color_ficha)
                    {
                        casilla.habilitada = false;
                        actualizarPuntosCasillaVacia(casillaArriba.color_ficha);
                    }
                }
            }


            //CASO 7: ESQUINA INFERIOR IZQUIERDA
            else if (casilla.x == posiciones_x - 1 && casilla.y == 0)
            {
                casillaArriba = tablero[posiciones_x - 2, 0];
                casillaDerecha = tablero[posiciones_x - 1, 1];

                if (casillaArriba.color_ficha != 0 && casillaDerecha.color_ficha != 0)
                {
                    if (casillaArriba.color_ficha == color_opuesto && casillaDerecha.color_ficha == color_opuesto && color_opuesto != 0)
                    {
                        casilla.Image = Properties.Resources.fichatablero;
                        casilla.color_ficha = 0;
                        casilla.habilitada = false;
                        actualizarPuntosCasillaOcupada(color_actual);
                    }
                    else if (color_actual == 0 && casilla.habilitada && casillaArriba.color_ficha == casillaDerecha.color_ficha)
                    {
                        casilla.habilitada = false;
                        actualizarPuntosCasillaVacia(casillaArriba.color_ficha);
                    }
                }
            }


            //CASO 8: ABAJO EN EL CENTRO
            else if (casilla.x == posiciones_x - 1 && casilla.y > 0 && casilla.y < posiciones_y - 1)
            {
                casillaIzquierda = tablero[posiciones_x - 1, casilla.y - 1];
                casillaArriba = tablero[posiciones_x - 2, casilla.y];
                casillaDerecha = tablero[posiciones_x - 1, casilla.y + 1];

                if (casillaIzquierda.color_ficha != 0 && casillaArriba.color_ficha != 0 && casillaDerecha.color_ficha != 0)
                {
                    if (casillaIzquierda.color_ficha == color_opuesto && casillaArriba.color_ficha == color_opuesto && casillaDerecha.color_ficha == color_opuesto && color_opuesto != 0)
                    {
                        casilla.Image = Properties.Resources.fichatablero;
                        casilla.color_ficha = 0;
                        casilla.habilitada = false;
                        actualizarPuntosCasillaOcupada(color_actual);
                    }
                    else if (color_actual == 0 && casilla.habilitada && casillaIzquierda.color_ficha == casillaArriba.color_ficha && casillaArriba.color_ficha == casillaDerecha.color_ficha)
                    {
                        casilla.habilitada = false;
                        actualizarPuntosCasillaVacia(casillaIzquierda.color_ficha);
                    }
                }
            }


            //CASO 9: ESQUINA INFERIOR DERECHA
            else if (casilla.x == posiciones_x - 1 && casilla.y == posiciones_y - 1)
            {
                casillaArriba = tablero[posiciones_x - 2, posiciones_y - 1];
                casillaIzquierda = tablero[posiciones_x - 1, posiciones_y - 2];

                if (casillaArriba.color_ficha != 0 && casillaIzquierda.color_ficha != 0)
                {
                    if (casillaArriba.color_ficha == color_opuesto && casillaIzquierda.color_ficha == color_opuesto && color_opuesto != 0)
                    {
                        casilla.Image = Properties.Resources.fichatablero;
                        casilla.color_ficha = 0;
                        casilla.habilitada = false;
                        actualizarPuntosCasillaOcupada(color_actual);
                    }
                    else if (color_actual == 0 && casilla.habilitada && casillaArriba.color_ficha == casillaIzquierda.color_ficha)
                    {
                        casilla.habilitada = false;
                        actualizarPuntosCasillaVacia(casillaArriba.color_ficha);
                    }
                }
            }
        }

        public void recorrerTablero()
        {
            for (int i = 0; i < posiciones_x; i++)
            {
                for (int j = 0; j < posiciones_y; j++)
                {
                    custom_pictureBox posicionActual = tablero[i, j];
                    calcularPuntos(posicionActual);
                }
            }
        }

        public void actualizarPuntosCasillaOcupada(int color_actual)
        {
            if (color_actual == 1)
            {
                punteo_fichasnegras--;
                punteo_fichasblancas++;
            }
            else if (color_actual == 2)
            {
                punteo_fichasblancas--;
                punteo_fichasnegras++;
            }
        }

        public void actualizarPuntosCasillaVacia(int color_rodeo)
        {
            if (color_rodeo == 1)
            {
                punteo_fichasnegras++;
            }
            else if (color_rodeo == 2)
            {
                punteo_fichasblancas++;
            }
        }
    }
}
