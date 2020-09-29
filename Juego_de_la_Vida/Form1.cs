using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_la_Vida
{
    public partial class Form1 : Form
    {
        int columnas = 20;
        int filas = 20;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox hola = new PictureBox();
            hola.Location = new Point(255, 255);
            hola.BackColor = Color.Red;
            hola.Visible = true;

        }




        private void MyGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MyGrid[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Green;
            MyGrid.Update();
        }

        private void Dibujar_Click(object sender, EventArgs e) 
        {
            try
            {
                columnas = Convert.ToInt32(colInput.Text);
                filas = Convert.ToInt32(filasInput.Text);
                MyGrid.ColumnHeadersVisible = false;
                MyGrid.RowHeadersVisible = false;
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
            catch (Exception )
            {
                string message = "Error al introucir los datos. ¿Quiere crear una tabla predeterminada de 20x20?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    MyGrid.ColumnHeadersVisible = false;
                    MyGrid.RowHeadersVisible = false;
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
                
                
            }
            
        }


    }
}
