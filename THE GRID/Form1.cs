using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THE_GRID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CREACION DE LA NUEVA INSTANCIA DE LA CLASE
            Tron tron = new Tron();
            tron.Grid = new double[3, 3];
            double prom;
            double prom1;

            //LLENANDO LA MATRIZ
            for (int i = 0; i < tron.Grid.GetLength(0); i++)
            {
                for (int j = 0; j < tron.Grid.GetLength(1); j++)
                {
                    tron.Grid[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("introducir valor", "introducir valor"));
                }
            }

            prom = tron.promedio();
            prom1 = tron.prom1();
            tabla.Rows.Add(prom,prom1);

           
           
        }
    }
}
