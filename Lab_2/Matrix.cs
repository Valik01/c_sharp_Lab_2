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
        private int[,] matrixA;
        private int[,] matrixB;
        private bool identity;
        private bool zero;
        private bool diagonal;

        public int Index { get => index; set => index = value < 0 ? 0 : value; }
        public int[,] MatrixA { get => matrixA; set => matrixA = value; }
        public int[,] MatrixB { get => matrixB; set => matrixB = value; }
        public bool Unit { get => identity; set => identity = value; }
        public bool Zero { get => zero; set => zero = value; }
        public bool Diagonal { get => diagonal; set => diagonal = value; }


        public Matrix(int index, int[,] matrixA, int[,] matrixB) //конструктор
        {
            this.index = index;
            this.matrixA = matrixA;
            this.matrixB = matrixB;
        }

        public String ArrayPrint(int[,] matrixA) // метод вывода матрицы, преобразования из int в string
        {
            String str = "";

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    str += $"{matrixA[i, j]}" + "   ";
                }
                str += '\n';
            }
            str += '\n';
            return str;
        }

        public int[,] Sum(int[,] matrixА, int[,] matrixВ) // метод прибавления матриц
        {
            int[,] matrixC = new int[index, index];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                    matrixC[i, j] = matrixА[i, j] + matrixВ[i, j];
            }

            return matrixC;
        } 

        public int[,] Sub(int[,] matrixА, int[,] matrixВ) // метод вычитания матриц
        {

            int[,] matrixE = new int[index, index];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                    matrixE[i, j] = matrixА[i, j] - matrixВ[i, j];
            }

            return matrixE;
        } 

        public int[,] Const(int[,] matrixА, int c) // метод умножения матрицы на константу
        {

            int[,] matrixE = new int[index, index];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                    matrixE[i, j] = matrixА[i, j] * c;
            }

            return matrixE;
        }

        public int[,] Multiplic(int[,] matrixА, int[,] matrixВ) // умножения матриц
        {

            int[,] matrixE = new int[index, index];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                    for (int t = 0; t < matrixA.GetLength(0); t++)
                        matrixE[i, j] += matrixA[i, t] * matrixB[t, j];
            }
            return matrixE;
        }

        public bool Unit1(int[,] matrixA)
        {
            identity = true;
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                    if (!(((i == j) && (matrixA[i, j] == 1)) || ((i != j) && (matrixA[i, j] == 0))))
                        identity = false;
            }
            return identity;
        } //является ли матрица единичной 

        public bool Zero1(int[,] matrixA) // диагональной 
        {
            zero = true;
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                    if (!(matrixA[i, j] == 0))
                        zero = false;
            }
            return zero;
        }

        public bool Diagonal1(int[,] matrixA) // является ли матрица нулевой
        {
            diagonal = true;
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                    if (!((i != j) && matrixA[i, j] == 0))
                        diagonal = false;
            }
            return diagonal;
        }

        ~Matrix()
        {

        }
    }
}


