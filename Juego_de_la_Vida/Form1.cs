using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_la_Vida
{
    public partial class Form1 : Form
    {
        ConjuntoCeldas conjunto;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void MyGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conjunto.celdas[e.RowIndex, e.ColumnIndex].alive = true;
            
            if (conjunto.celdas[e.RowIndex, e.ColumnIndex].isAlive()== true)
            {
                MyGrid[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Green;
            }
            MyGrid.ClearSelection();
        }

        private void Dibujar_Click(object sender, EventArgs e) 
        {
            try
            {
                int columnas = Convert.ToInt32(colInput.Text);
                int filas = Convert.ToInt32(filasInput.Text);
                DibujarGrid(filas, columnas);
                conjunto = new ConjuntoCeldas(filas, columnas);
            }
            catch (Exception )
            {
                string message = "Error al introucir los datos. ¿Quiere crear una tabla predeterminada de 20x20?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    int filas = 20;
                    int columnas = 20;
                    DibujarGrid(filas, columnas);
                    conjunto = new ConjuntoCeldas(filas, columnas);
                }
            }
            
        }

        public void DibujarGrid(int filas, int columnas)
        {
            MyGrid.Rows.Clear();
            MyGrid.ColumnHeadersVisible = false;
            MyGrid.RowHeadersVisible = false;
            MyGrid.RowsDefaultCellStyle.BackColor = Color.White;
            MyGrid.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent;
            MyGrid.ColumnCount = columnas;
            MyGrid.RowCount = filas;
            for (int col = 0; col < columnas; col++)
            {
                MyGrid.Columns[col].Width = MyGrid.Width / columnas;
            }
            for (int row = 0; row < columnas; row++)
            {
                MyGrid.Rows[row].Height = MyGrid.Height / filas;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int filas = 20;
            int columnas = 20;
            DibujarGrid(filas, columnas);
            conjunto = new ConjuntoCeldas(filas, columnas);
        }
    }
}
