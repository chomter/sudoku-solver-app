using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SudokuSolverApp
{
    class Sudoku
    {
        public static void Solve(int[,] board)
        {
            foreach (int x in board)
            {
                Console.Write(x + " ");
            }
        }
    }
}
