using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Juego_de_la_Vida
{
    public class Celda
    {

        public int alive =0;

        //Constructor
        public Celda( int vive)
        {
            this.alive = vive;
        }
        public int isAlive()
        {
            return this.alive;
        }
        public void setAlive()
        {
            this.alive = 1;
        }
        public void AplicarReglas(int VecinosVivos)
        {
            if (this.alive == 1)
            {
                if (VecinosVivos==0)
                {
                    this.alive = 0;
                }
                else if (VecinosVivos==1)
                {
                    this.alive = 1;
                }
                else if (VecinosVivos == 2)
                {
                    this.alive = 1;
                }
                else if (VecinosVivos == 3)
                {
                    this.alive = 1;
                }
                else if (VecinosVivos == 4)
                {
                    this.alive = 1;
                }
                else if (VecinosVivos == 5)
                {
                    this.alive = 0;
                }
                else if (VecinosVivos == 6)
                {
                    this.alive = 0;
                }
                else if (VecinosVivos == 7)
                {
                    this.alive = 0;
                }
                else if (VecinosVivos == 8)
                {
                    this.alive = 0;
                }
            }
            else if (this.alive == 0)
            {
                if (VecinosVivos == 0)
                {
                    this.alive = 0;
                }
                else if (VecinosVivos == 1)
                {
                    this.alive = 1;
                }
                else if (VecinosVivos == 2)
                {
                    this.alive = 1;
                }
                else if (VecinosVivos == 3)
                {
                    this.alive = 1;
                }
                else if (VecinosVivos == 4)
                {
                    this.alive = 1;
                }
                else if (VecinosVivos == 5)
                {
                    this.alive = 0;
                }
                else if (VecinosVivos == 6)
                {
                    this.alive = 0;
                }
                else if (VecinosVivos == 7)
                {
                    this.alive = 0;
                }
                else if (VecinosVivos == 8)
                {
                    this.alive = 0;
                }
            }
        }
    }



}
