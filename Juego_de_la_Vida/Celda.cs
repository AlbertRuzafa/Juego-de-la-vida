using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Juego_de_la_Vida
{
    public class Celda
    {

        public Boolean alive = false;

        //Constructor
        public Celda( Boolean vive)
        {
            this.alive = vive;
        }
        public Boolean isAlive()
        {
            return this.alive;
        }
        public void setAlive()
        {
            this.alive = true;
        }
    }



}
