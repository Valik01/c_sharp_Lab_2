using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCalculate1_Click(object sender, EventArgs e)
        {
            int[,] matrixA = { { 1, 2, 2 }, { 0, 3, 1 }, { 1, 0, 0 } };
            int[,] matrixB = { { 0, 0, 1 }, { 0, 0, 1 }, { 0, 0, -1 } };
            Matrix A = new Matrix(3, matrixA, matrixB); //создание объектов класса
            int[,] matrixD;
            matrixD = A.Sum(A.Const(A.Multiplic(A.MatrixB, A.MatrixA), 3), A.Sub(A.MatrixB, A.MatrixA));
            rTextBox1.Text = "A= \n" + A.ArrayPrint(A.MatrixA) + "B= \n" + A.ArrayPrint(A.MatrixB) + 
                "D= 3 * B * A + ( B - A ) \n\nD=\n" + A.ArrayPrint(matrixD) + 
                "Diagonal matrix D : " + A.Diagonal1(matrixD) + "\nZero matrix D : " 
                + A.Zero1(matrixD) +  "\nIdentity matrix D : " + A.Unit1(matrixD);
           
        }
    }
}
