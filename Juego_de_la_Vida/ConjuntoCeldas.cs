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
                for (int j= 0; j < columnas; j++)
                {
                    celdas[i, j] = new Celda(0);
                }
            }

        }
        public void ActualizarConjunto(int filas, int columnas)
        {
            Celda[,] celdasViejas = new Celda[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    celdasViejas[i, j] = new Celda(celdas[i,j].alive);
                }
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    int VecinosVivos = compararCeldas(i, j, filas-1, columnas-1,celdas);
                    celdasViejas[i, j].AplicarReglas(VecinosVivos);
                }
            }
            celdas = celdasViejas;
        }
        public int compararCeldas(int i, int j, int maxFilas, int maxColumnas, Celda[,] celdasViejas)

        {
            int sum=0;

            if (i != 0 && j == 0 && i != maxFilas)                              //Celdas contiguas al eje horizontal
                sum = celdasViejas[i + 1, j].alive + celdasViejas[i + 1, j + 1].alive + celdasViejas[i - 1, j].alive + celdasViejas[i - 1, j + 1].alive + celdasViejas[i, j + 1].alive;
            else if (i == 0 && j != 0 && j != maxColumnas)                      //Celdas contiguas al eje vertical
                sum = celdasViejas[i + 1, j].alive + celdasViejas[i + 1, j + 1].alive + celdasViejas[i + 1, j - 1].alive + celdasViejas[i, j - 1].alive + celdasViejas[i, j + 1].alive;
            else if (i == 0 && j == 0)                                          //Celda vértice superior izquierdo (0,0)
                sum = celdasViejas[i + 1, j].alive + celdasViejas[i + 1, j + 1].alive + celdasViejas[i, j + 1].alive;
            else if (j != 0 && i == maxFilas && j != maxColumnas)               //Celdas contiguas al eje de máximo valor horizontal
                sum = celdasViejas[i - 1, j].alive + celdasViejas[i - 1, j - 1].alive + celdasViejas[i - 1, j + 1].alive + celdasViejas[i, j - 1].alive + celdasViejas[i, j + 1].alive;
            else if (i != 0 && i != maxFilas && j == maxColumnas)               //Celdas contiguas al eje de máximo valor vertical
                sum = celdasViejas[i + 1, j].alive + celdasViejas[i + 1, j - 1].alive + celdasViejas[i - 1, j].alive + celdasViejas[i - 1, j - 1].alive + celdasViejas[i, j - 1].alive;
            else if (i == 0 && j == maxColumnas)                                //Celda vértice superior derecho (0,max)
                sum = celdasViejas[i + 1, j].alive + celdasViejas[i + 1, j - 1].alive + celdasViejas[i, j - 1].alive;
            else if (i == maxFilas && j == 0)     //Celda vértice inferior izquierdo(max,0)
                sum = celdasViejas[i - 1, j].alive + celdasViejas[i - 1, j + 1].alive + celdasViejas[i, j + 1].alive;
            else if ( i == maxFilas && j == maxColumnas)     //Celda vértice inferior derecho(max,max)
                sum = celdasViejas[i - 1, j].alive + celdasViejas[i - 1, j - 1].alive + celdasViejas[i, j - 1].alive;
            else                                                                //Celdas interiores de la malla
                sum = celdasViejas[i + 1, j].alive + celdasViejas[i + 1, j + 1].alive + celdasViejas[i + 1, j - 1].alive + celdasViejas[i - 1, j].alive + celdasViejas[i - 1, j - 1].alive + celdasViejas[i - 1, j + 1].alive + celdasViejas[i, j - 1].alive + celdasViejas[i, j + 1].alive;
            return sum;
        }


    }
}
