using System;
using System.Collections.Generic;
using System.Text;

namespace QuarkTeam4Challenges.VeryDificult
{
    /*
    Write a method that accepts two integer parameters rows and cols.
    The output is a 2d array of numbers displayed in column-major order,
    meaning the numbers shown increase sequentially down each column and wrap to the top of the next column to the right once the bottom of the current column is reached.
     */
    class PrintGrid
    {
        public static int[,] PrintGridResult(int rows, int cols)
        {
            /*Ej: PrintGrid(3, 6) ➞ new int[,] { 
              new int[] { 1, 4, 7, 10, 13, 16 },
              new int[] { 2, 5, 8, 11, 14, 17 },
              new int[] { 3, 6, 9, 12, 15, 18 }
            ]
            PrintGrid(new int[3,6] {
                { 1, 4, 7, 10, 13, 16 },
                { 2, 5, 8, 11, 14, 17 },
                { 3, 6, 9, 12, 15, 18 }
            })
             */

            int[,] grid = new int[rows, cols];

            int contador = 0;

            for (int i = 0; i < rows; i++)
            {
                contador = i + 1;

                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = contador;
                    contador += rows;
                }
            }
            return grid;
        }
    }

    //Estimado: 20 minutos
    //Reales: 10 minutos
    //Integrantes: Equipo 4
}
