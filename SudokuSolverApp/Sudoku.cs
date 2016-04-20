using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using IronPython.Runtime;
using System.Windows.Forms;


namespace SudokuSolverApp
{
    class Sudoku
    {
        public static PythonDictionary Solve(int[,] board)
        {
            List<int> nums = new List<int>();

            foreach (int x in board)
            {
                nums.Add(x);                
            }

            string numbers = string.Join("", nums);

            var engine = Python.CreateEngine();
            dynamic py = engine.ExecuteFile(@"C:\sudoku.py");
            dynamic sud = py.Sudoku();
            PythonDictionary d = null;
            try
            {
                d = sud.solve(numbers);
            }
            catch
            {
                return d;
            }
            return d;
        }
    }
}
