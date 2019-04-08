using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Matrix
    {
        private int index;
        public int[,] matrixA;
        public int[,] matrixB;

        public Matrix(int index, int[,] matrixA, int[,] matrixB)
        {
            this.index = index;
            this.matrixA = matrixA;
            this.matrixB = matrixB;
        }
    }
}
