using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Runtime;


namespace SudokuSolverApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }
        
        int[,] array = new int[9, 9];

        private void a1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = e.KeyChar == '0';
            }
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {           
            PythonDictionary pydict = Sudoku.Solve(array);

            if (pydict == null)
            {
                MessageBox.Show("Two or more same numbers in row, column or 3x3 boxes (there is no solution).");
            }
            else { 
            foreach (var s in pydict)
            {
                switch (s.Key.ToString())
                {
                    case "A1":
                        a1.Text = s.Value.ToString();
                        break;
                    case "A2":
                        a2.Text = s.Value.ToString();
                        break;
                    case "A3":
                        a3.Text = s.Value.ToString();
                        break;
                    case "A4":
                        a4.Text = s.Value.ToString();
                        break;
                    case "A5":
                        a5.Text = s.Value.ToString();
                        break;
                    case "A6":
                        a6.Text = s.Value.ToString();
                        break;
                    case "A7":
                        a7.Text = s.Value.ToString();
                        break;
                    case "A8":
                        a8.Text = s.Value.ToString();
                        break;
                    case "A9":
                        a9.Text = s.Value.ToString();
                        break;
                    case "B1":
                        b1.Text = s.Value.ToString();
                        break;
                    case "B2":
                        b2.Text = s.Value.ToString();
                        break;
                    case "B3":
                        b3.Text = s.Value.ToString();
                        break;
                    case "B4":
                        b4.Text = s.Value.ToString();
                        break;
                    case "B5":
                        b5.Text = s.Value.ToString();
                        break;
                    case "B6":
                        b6.Text = s.Value.ToString();
                        break;
                    case "B7":
                        b7.Text = s.Value.ToString();
                        break;
                    case "B8":
                        b8.Text = s.Value.ToString();
                        break;
                    case "B9":
                        b9.Text = s.Value.ToString();
                        break;
                    case "C1":
                        c1.Text = s.Value.ToString();
                        break;
                    case "C2":
                        c2.Text = s.Value.ToString();
                        break;
                    case "C3":
                        c3.Text = s.Value.ToString();
                        break;
                    case "C4":
                        c4.Text = s.Value.ToString();
                        break;
                    case "C5":
                        c5.Text = s.Value.ToString();
                        break;
                    case "C6":
                        c6.Text = s.Value.ToString();
                        break;
                    case "C7":
                        c7.Text = s.Value.ToString();
                        break;
                    case "C8":
                        c8.Text = s.Value.ToString();
                        break;
                    case "C9":
                        c9.Text = s.Value.ToString();
                        break;
                    case "D1":
                        d1.Text = s.Value.ToString();
                        break;
                    case "D2":
                        d2.Text = s.Value.ToString();
                        break;
                    case "D3":
                        d3.Text = s.Value.ToString();
                        break;
                    case "D4":
                        d4.Text = s.Value.ToString();
                        break;
                    case "D5":
                        d5.Text = s.Value.ToString();
                        break;
                    case "D6":
                        d6.Text = s.Value.ToString();
                        break;
                    case "D7":
                        d7.Text = s.Value.ToString();
                        break;
                    case "D8":
                        d8.Text = s.Value.ToString();
                        break;
                    case "D9":
                        d9.Text = s.Value.ToString();
                        break;
                    case "E1":
                        e1.Text = s.Value.ToString();
                        break;
                    case "E2":
                        e2.Text = s.Value.ToString();
                        break;
                    case "E3":
                        e3.Text = s.Value.ToString();
                        break;
                    case "E4":
                        e4.Text = s.Value.ToString();
                        break;
                    case "E5":
                        e5.Text = s.Value.ToString();
                        break;
                    case "E6":
                        e6.Text = s.Value.ToString();
                        break;
                    case "E7":
                        e7.Text = s.Value.ToString();
                        break;
                    case "E8":
                        e8.Text = s.Value.ToString();
                        break;
                    case "E9":
                        e9.Text = s.Value.ToString();
                        break;
                    case "F1":
                        f1.Text = s.Value.ToString();
                        break;
                    case "F2":
                        f2.Text = s.Value.ToString();
                        break;
                    case "F3":
                        f3.Text = s.Value.ToString();
                        break;
                    case "F4":
                        f4.Text = s.Value.ToString();
                        break;
                    case "F5":
                        f5.Text = s.Value.ToString();
                        break;
                    case "F6":
                        f6.Text = s.Value.ToString();
                        break;
                    case "F7":
                        f7.Text = s.Value.ToString();
                        break;
                    case "F8":
                        f8.Text = s.Value.ToString();
                        break;
                    case "F9":
                        f9.Text = s.Value.ToString();
                        break;
                    case "G1":
                        g1.Text = s.Value.ToString();
                        break;
                    case "G2":
                        g2.Text = s.Value.ToString();
                        break;
                    case "G3":
                        g3.Text = s.Value.ToString();
                        break;
                    case "G4":
                        g4.Text = s.Value.ToString();
                        break;
                    case "G5":
                        g5.Text = s.Value.ToString();
                        break;
                    case "G6":
                        g6.Text = s.Value.ToString();
                        break;
                    case "G7":
                        g7.Text = s.Value.ToString();
                        break;
                    case "G8":
                        g8.Text = s.Value.ToString();
                        break;
                    case "G9":
                        g9.Text = s.Value.ToString();
                        break;
                    case "H1":
                        h1.Text = s.Value.ToString();
                        break;
                    case "H2":
                        h2.Text = s.Value.ToString();
                        break;
                    case "H3":
                        h3.Text = s.Value.ToString();
                        break;
                    case "H4":
                        h4.Text = s.Value.ToString();
                        break;
                    case "H5":
                        h5.Text = s.Value.ToString();
                        break;
                    case "H6":
                        h6.Text = s.Value.ToString();
                        break;
                    case "H7":
                        h7.Text = s.Value.ToString();
                        break;
                    case "H8":
                        h8.Text = s.Value.ToString();
                        break;
                    case "H9":
                        h9.Text = s.Value.ToString();
                        break;
                    case "I1":
                        i1.Text = s.Value.ToString();
                        break;
                    case "I2":
                        i2.Text = s.Value.ToString();
                        break;
                    case "I3":
                        i3.Text = s.Value.ToString();
                        break;
                    case "I4":
                        i4.Text = s.Value.ToString();
                        break;
                    case "I5":
                        i5.Text = s.Value.ToString();
                        break;
                    case "I6":
                        i6.Text = s.Value.ToString();
                        break;
                    case "I7":
                        i7.Text = s.Value.ToString();
                        break;
                    case "I8":
                        i8.Text = s.Value.ToString();
                        break;
                    case "I9":
                        i9.Text = s.Value.ToString();
                        break;
                }
                }             
            }
            
        }      
                
        private void TextBoxChanged(object sender, EventArgs e)
        {            
            string textboxName = ((TextBox)sender).Name;
            if (((TextBox)sender).Text != "")
            {
                switch (textboxName)
                {
                    case "a1":
                        array[0, 0] = Int32.Parse(a1.Text);                        
                        break;
                    case "a2":
                        array[0, 1] = Int32.Parse(a2.Text);
                        break;
                    case "a3":
                        array[0, 2] = Int32.Parse(a3.Text);
                        break;
                    case "a4":
                        array[0, 3] = Int32.Parse(a4.Text);
                        break;
                    case "a5":
                        array[0, 4] = Int32.Parse(a5.Text);
                        break;
                    case "a6":
                        array[0, 5] = Int32.Parse(a6.Text);
                        break;
                    case "a7":
                        array[0, 6] = Int32.Parse(a7.Text);
                        break;
                    case "a8":
                        array[0, 7] = Int32.Parse(a8.Text);
                        break;
                    case "a9":
                        array[0, 8] = Int32.Parse(a9.Text);
                        break;
                    case "b1":
                        array[1, 0] = Int32.Parse(b1.Text);
                        break;
                    case "b2":
                        array[1, 1] = Int32.Parse(b2.Text);
                        break;
                    case "b3":
                        array[1, 2] = Int32.Parse(b3.Text);
                        break;
                    case "b4":
                        array[1, 3] = Int32.Parse(b4.Text);
                        break;
                    case "b5":
                        array[1, 4] = Int32.Parse(b5.Text);
                        break;
                    case "b6":
                        array[1, 5] = Int32.Parse(b6.Text);
                        break;
                    case "b7":
                        array[1, 6] = Int32.Parse(b7.Text);
                        break;
                    case "b8":
                        array[1, 7] = Int32.Parse(b8.Text);
                        break;
                    case "b9":
                        array[1, 8] = Int32.Parse(b9.Text);
                        break;
                    case "c1":
                        array[2, 0] = Int32.Parse(c1.Text);
                        break;
                    case "c2":
                        array[2, 1] = Int32.Parse(c2.Text);
                        break;
                    case "c3":
                        array[2, 2] = Int32.Parse(c3.Text);
                        break;
                    case "c4":
                        array[2, 3] = Int32.Parse(c4.Text);
                        break;
                    case "c5":
                        array[2, 4] = Int32.Parse(c5.Text);
                        break;
                    case "c6":
                        array[2, 5] = Int32.Parse(c6.Text);
                        break;
                    case "c7":
                        array[2, 6] = Int32.Parse(c7.Text);
                        break;
                    case "c8":
                        array[2, 7] = Int32.Parse(c8.Text);
                        break;
                    case "c9":
                        array[2, 8] = Int32.Parse(c9.Text);
                        break;
                    case "d1":
                        array[3, 0] = Int32.Parse(d1.Text);
                        break;
                    case "d2":
                        array[3, 1] = Int32.Parse(d2.Text);
                        break;
                    case "d3":
                        array[3, 2] = Int32.Parse(d3.Text);
                        break;
                    case "d4":
                        array[3, 3] = Int32.Parse(d4.Text);
                        break;
                    case "d5":
                        array[3, 4] = Int32.Parse(d5.Text);
                        break;
                    case "d6":
                        array[3, 5] = Int32.Parse(d6.Text);
                        break;
                    case "d7":
                        array[3, 6] = Int32.Parse(d7.Text);
                        break;
                    case "d8":
                        array[3, 7] = Int32.Parse(d8.Text);
                        break;
                    case "d9":
                        array[3, 8] = Int32.Parse(d9.Text);
                        break;
                    case "e1":
                        array[4, 0] = Int32.Parse(e1.Text);
                        break;
                    case "e2":
                        array[4, 1] = Int32.Parse(e2.Text);
                        break;
                    case "e3":
                        array[4, 2] = Int32.Parse(e3.Text);
                        break;
                    case "e4":
                        array[4, 3] = Int32.Parse(e4.Text);
                        break;
                    case "e5":
                        array[4, 4] = Int32.Parse(e5.Text);
                        break;
                    case "e6":
                        array[4, 5] = Int32.Parse(e6.Text);
                        break;
                    case "e7":
                        array[4, 6] = Int32.Parse(e7.Text);
                        break;
                    case "e8":
                        array[4, 7] = Int32.Parse(e8.Text);
                        break;
                    case "e9":
                        array[4, 8] = Int32.Parse(e9.Text);
                        break;
                    case "f1":
                        array[5, 0] = Int32.Parse(f1.Text);                    break;
                    case "f2":
                        array[5, 1] = Int32.Parse(f2.Text);
                        break;
                    case "f3":
                        array[5, 2] = Int32.Parse(f3.Text);
                        break;
                    case "f4":
                        array[5, 3] = Int32.Parse(f4.Text);
                        break;
                    case "f5":
                        array[5, 4] = Int32.Parse(f5.Text);
                        break;
                    case "f6":
                        array[5, 5] = Int32.Parse(f6.Text);
                        break;
                    case "f7":
                        array[5, 6] = Int32.Parse(f7.Text);
                        break;
                    case "f8":
                        array[5, 7] = Int32.Parse(f8.Text);
                        break;
                    case "f9":
                        array[5, 8] = Int32.Parse(f9.Text);
                        break;
                    case "g1":
                        array[6, 0] = Int32.Parse(g1.Text);
                        break;
                    case "g2":
                        array[6, 1] = Int32.Parse(g2.Text);
                        break;
                    case "g3":
                        array[6, 2] = Int32.Parse(g3.Text);
                        break;
                    case "g4":
                        array[6, 3] = Int32.Parse(g4.Text);
                        break;
                    case "g5":
                        array[6, 4] = Int32.Parse(g5.Text);
                        break;
                    case "g6":
                        array[6, 5] = Int32.Parse(g6.Text);
                        break;
                    case "g7":
                        array[6, 6] = Int32.Parse(g7.Text);
                        break;
                    case "g8":
                        array[6, 7] = Int32.Parse(g8.Text);
                        break;
                    case "g9":
                        array[6, 8] = Int32.Parse(g9.Text);
                        break;
                    case "h1":
                        array[7, 0] = Int32.Parse(h1.Text);
                        break;
                    case "h2":
                        array[7, 1] = Int32.Parse(h2.Text);
                        break;
                    case "h3":
                        array[7, 2] = Int32.Parse(h3.Text);
                        break;
                    case "h4":
                        array[7, 3] = Int32.Parse(h4.Text);
                        break;
                    case "h5":
                        array[7, 4] = Int32.Parse(h5.Text);
                        break;
                    case "h6":
                        array[7, 5] = Int32.Parse(h6.Text);
                        break;
                    case "h7":
                        array[7, 6] = Int32.Parse(h7.Text);
                        break;
                    case "h8":
                        array[7, 7] = Int32.Parse(h8.Text);
                        break;
                    case "h9":
                        array[7, 8] = Int32.Parse(h9.Text);
                        break;
                    case "i1":
                        array[8, 0] = Int32.Parse(i1.Text);
                        break;
                    case "i2":
                        array[8, 1] = Int32.Parse(i2.Text);
                        break;
                    case "i3":
                        array[8, 2] = Int32.Parse(i3.Text);
                        break;
                    case "i4":
                        array[8, 3] = Int32.Parse(i4.Text);
                        break;
                    case "i5":
                        array[8, 4] = Int32.Parse(i5.Text);
                        break;
                    case "i6":
                        array[8, 5] = Int32.Parse(i6.Text);
                        break;
                    case "i7":
                        array[8, 6] = Int32.Parse(i7.Text);
                        break;
                    case "i8":
                        array[8, 7] = Int32.Parse(i8.Text);
                        break;
                    case "i9":
                        array[8, 8] = Int32.Parse(i9.Text);
                        break;
                }
            }
                
            else 
            {
                switch (textboxName)
                {
                    case "a1":
                        array[0, 0] = 0;
                        break;
                    case "a2":
                        array[0, 1] = 0;
                        break;
                    case "a3":
                        array[0, 2] = 0;
                        break;
                    case "a4":
                        array[0, 3] = 0;
                        break;
                    case "a5":
                        array[0, 4] = 0;
                        break;
                    case "a6":
                        array[0, 5] = 0;
                        break;
                    case "a7":
                        array[0, 6] = 0;
                        break;
                    case "a8":
                        array[0, 7] = 0;
                        break;
                    case "a9":
                        array[0, 8] = 0;
                        break;
                    case "b1":
                        array[1, 0] = 0;
                        break;
                    case "b2":
                        array[1, 1] = 0;
                        break;
                    case "b3":
                        array[1, 2] = 0;
                        break;
                    case "b4":
                        array[1, 3] = 0;
                        break;
                    case "b5":
                        array[1, 4] = 0;
                        break;
                    case "b6":
                        array[1, 5] = 0;
                        break;
                    case "b7":
                        array[1, 6] = 0;
                        break;
                    case "b8":
                        array[1, 7] = 0;
                        break;
                    case "b9":
                        array[1, 8] = 0;
                        break;
                    case "c1":
                        array[2, 0] = 0;
                        break;
                    case "c2":
                        array[2, 1] = 0;
                        break;
                    case "c3":
                        array[2, 2] = 0;
                        break;
                    case "c4":
                        array[2, 3] = 0;
                        break;
                    case "c5":
                        array[2, 4] = 0;
                        break;
                    case "c6":
                        array[2, 5] = 0;
                        break;
                    case "c7":
                        array[2, 6] = 0;
                        break;
                    case "c8":
                        array[2, 7] = 0;
                        break;
                    case "c9":
                        array[2, 8] = 0;
                        break;
                    case "d1":
                        array[3, 0] = 0;
                        break;
                    case "d2":
                        array[3, 1] = 0;
                        break;
                    case "d3":
                        array[3, 2] = 0;
                        break;
                    case "d4":
                        array[3, 3] = 0;
                        break;
                    case "d5":
                        array[3, 4] = 0;
                        break;
                    case "d6":
                        array[3, 5] = 0;
                        break;
                    case "d7":
                        array[3, 6] = 0;
                        break;
                    case "d8":
                        array[3, 7] = 0;
                        break;
                    case "d9":
                        array[3, 8] = 0;
                        break;
                    case "e1":
                        array[4, 0] = 0;
                        break;
                    case "e2":
                        array[4, 1] = 0;
                        break;
                    case "e3":
                        array[4, 2] = 0;
                        break;
                    case "e4":
                        array[4, 3] = 0;
                        break;
                    case "e5":
                        array[4, 4] = 0;
                        break;
                    case "e6":
                        array[4, 5] = 0;
                        break;
                    case "e7":
                        array[4, 6] = 0;
                        break;
                    case "e8":
                        array[4, 7] = 0;
                        break;
                    case "e9":
                        array[4, 8] = 0;
                        break;
                    case "f1":
                        array[5, 0] = 0;
                        break;
                    case "f2":
                        array[5, 1] = 0;
                        break;
                    case "f3":
                        array[5, 2] = 0;
                        break;
                    case "f4":
                        array[5, 3] = 0;
                        break;
                    case "f5":
                        array[5, 4] = 0;
                        break;
                    case "f6":
                        array[5, 5] = 0;
                        break;
                    case "f7":
                        array[5, 6] = 0;
                        break;
                    case "f8":
                        array[5, 7] = 0;
                        break;
                    case "f9":
                        array[5, 8] = 0;
                        break;
                    case "g1":
                        array[6, 0] = 0;
                        break;
                    case "g2":
                        array[6, 1] = 0;
                        break;
                    case "g3":
                        array[6, 2] = 0;
                        break;
                    case "g4":
                        array[6, 3] = 0;
                        break;
                    case "g5":
                        array[6, 4] = 0;
                        break;
                    case "g6":
                        array[6, 5] = 0;
                        break;
                    case "g7":
                        array[6, 6] = 0;
                        break;
                    case "g8":
                        array[6, 7] = 0;
                        break;
                    case "g9":
                        array[6, 8] = 0;
                        break;
                    case "h1":
                        array[7, 0] = 0;
                        break;
                    case "h2":
                        array[7, 1] = 0;
                        break;
                    case "h3":
                        array[7, 2] = 0;
                        break;
                    case "h4":
                        array[7, 3] = 0;
                        break;
                    case "h5":
                        array[7, 4] = 0;
                        break;
                    case "h6":
                        array[7, 5] = 0;
                        break;
                    case "h7":
                        array[7, 6] = 0;
                        break;
                    case "h8":
                        array[7, 7] = 0;
                        break;
                    case "h9":
                        array[7, 8] = 0;
                        break;
                    case "i1":
                        array[8, 0] = 0;
                        break;
                    case "i2":
                        array[8, 1] = 0;
                        break;
                    case "i3":
                        array[8, 2] = 0;
                        break;
                    case "i4":
                        array[8, 3] = 0;
                        break;
                    case "i5":
                        array[8, 4] = 0;
                        break;
                    case "i6":
                        array[8, 5] = 0;
                        break;
                    case "i7":
                        array[8, 6] = 0;
                        break;
                    case "i8":
                        array[8, 7] = 0;
                        break;
                    case "i9":
                        array[8, 8] = 0;
                        break;
                    }
                }
            }      
        }
    }

