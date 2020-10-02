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
        //Si esta vivo
        public int v0 = 0;//0 vivos alrededos
        public int v1 = 1;//1 vivo alrededor...
        public int v2 = 1;
        public int v3 = 1;
        public int v4 = 1;
        public int v5 = 0;
        public int v6 = 0;
        public int v7 = 0;
        public int v8 = 0;
        //si esta muerto
        public int m0 = 0;//0 vivos alrededor
        public int m1 = 1;//1 vivo al rededor...
        public int m2 = 1;
        public int m3 = 1;
        public int m4 = 1;
        public int m5 = 0;
        public int m6 = 0;
        public int m7 = 0;
        public int m8 = 0;

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
                    this.alive = v0;
                }
                else if (VecinosVivos==1)
                {
                    this.alive = v1;
                }
                else if (VecinosVivos == 2)
                {
                    this.alive = v2;
                }
                else if (VecinosVivos == 3)
                {
                    this.alive = v3;
                }
                else if (VecinosVivos == 4)
                {
                    this.alive = v4;
                }
                else if (VecinosVivos == 5)
                {
                    this.alive = v5;
                }
                else if (VecinosVivos == 6)
                {
                    this.alive = v6;
                }
                else if (VecinosVivos == 7)
                {
                    this.alive = v7;
                }
                else if (VecinosVivos == 8)
                {
                    this.alive = v8;
                }
            }
            else if (this.alive == 0)
            {
                if (VecinosVivos == 0)
                {
                    this.alive = m0;
                }
                else if (VecinosVivos == 1)
                {
                    this.alive = m1;
                }
                else if (VecinosVivos == 2)
                {
                    this.alive = m2;
                }
                else if (VecinosVivos == 3)
                {
                    this.alive = m3;
                }
                else if (VecinosVivos == 4)
                {
                    this.alive = v4;
                }
                else if (VecinosVivos == 5)
                {
                    this.alive = m5;
                }
                else if (VecinosVivos == 6)
                {
                    this.alive = m6;
                }
                else if (VecinosVivos == 7)
                {
                    this.alive = m7;
                }
                else if (VecinosVivos == 8)
                {
                    this.alive = m8;
                }
            }
        }
    }



}
