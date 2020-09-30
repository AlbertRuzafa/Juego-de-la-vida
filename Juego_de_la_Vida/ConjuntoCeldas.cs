using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_la_Vida
{
   public class ConjuntoCeldas
    {
        public Celda[,] celdas;


        public ConjuntoCeldas(int filas, int columnas)
        {
            this.celdas = new Celda[filas, columnas];
            for (int i =0;i<filas;i++)
            {
                for (int j= 0; j < filas; j++)
                {
                    celdas[i, j] = new Celda(false);
                }
            }

        }
        

    }
}
