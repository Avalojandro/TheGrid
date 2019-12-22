using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_GRID
{
    class Tron
    {
        //Atributos
        double[,] grid;
       
        public double[,] Grid { get => grid; set => grid = value; }
       
        //METODOS
        public double promedio()
        {
            double media=0;
            double suma=0;
            for (int i=0;i<3;i++)
            {
             
            for(int j = 0; j < 3; j++)
                {
                    suma = suma + grid[i, j];
                }

            }
            media = suma/9;
            return media;

        }

        public double prom1()
        {
            double prom1 = 0;
            double suma = 0;
            for(int i=0; i < 3; i++)
            {
                suma = grid[0, i] + suma;
            }
            prom1 = suma / 3;
            return prom1;
        }


    }
}
