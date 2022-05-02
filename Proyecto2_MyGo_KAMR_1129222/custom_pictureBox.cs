using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto2_MyGo_KAMR_1129222
{

    /*Creacion de la clase custom_pictureBox de tipo PictureBox, esto significa que esta clase obtendra todas las propiedades
     que tiene un picture box y aparte se le podran añadir unas nuevas.*/
    public class custom_pictureBox : PictureBox
    {
        public int x = 0;
        public int y = 0;

        public bool habilitada = true;

        public int color_ficha = 0; 
        //por defecto tienen 0, el 1 se usa para las fichas negras y 2 se usa para las fichas blancas.
    }
}
