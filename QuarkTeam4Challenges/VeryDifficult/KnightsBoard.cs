using System;
using System.Collections.Generic;
using System.Text;

namespace QuarkTeam4Challenges.VeryDificult
{
    class KnightsBoard
    {
        /*
        Write a function that returns true if the knights are placed on a chessboard such that no knight can capture another knight. 
        Here, 0s represent empty squares and 1s represent knights.
         */
        /*
         CannotCapture(new int[,] {
            { 0, 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 1, 0 },
            { 0, 1, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 1, 0, 0, 0 }
        }) ➞ True
         
         */
        public bool CannotCapture(int[,] board) {
            int width = 8, height = 8;
            for (int i = 0; i < width; i++) {
                for (int j = 0; j < height; j++) {
                    if (board[i, j] == 1 && CanCaptureKnight(i, j, board))
                        return false;                        
                }
            }
            return true;
        }

        public bool CanCaptureKnight(int posX, int posY, int[,] board) {
            //int width = 8, height = 8;
            int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };

            for (int i = 0; i < xMove.Length; i++) {
                if (IsKnight(posX + xMove[i], posY + yMove[i], board))
                    return true;
            }
            return false;
        }

        /* A utility function to
            check if i,j are valid
            indexes for N*N chessboard */
        //static int N = 8;
        static bool IsSafe(int x, int y)
        {
            return (x >= 0 && x < 8 && y >= 0 && y < 8);
        }

        public bool IsKnight(int x, int y, int[,] sol) {
            return IsSafe(x, y) && sol[x,y]==1;
        }

        //Estimado: 20 minutos
        //Reales: 40 minutos
        //Integrantes: Equipo 4
    }
}
