using System;

namespace Arrays_Task01
{
    class Program
    {
        static void Main()
        {
            MyMatrix matrix = new MyMatrix(4, 5);
            matrix.FillMatrix();
            matrix.PrintMatrix();
            Console.WriteLine("\n\nChange width: ");
            matrix.ChangeWidth(7);
            matrix.PrintMatrix();
            Console.WriteLine("\n\nChange height: ");
            matrix.ChangeHeight(10);
            matrix.PrintMatrix();
            Console.ReadKey();
        }
    }

    internal class MyMatrix
    {
        private int[,] mtrx;
        private int m, n;

        public MyMatrix(int m, int n)
        {
            this.m = m;
            this.n = n;
            mtrx = new int[m,n];
        }

        public void FillMatrix()
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[j, i] = count++;
                }
            }
        }

        public void ChangeWidth(int m)
        {
            this.m = m;
            mtrx = new int[m,n];
            FillMatrix();
        }

        public void ChangeHeight(int n)
        {
            this.n = n;
            mtrx = new int[m, n];
            FillMatrix();
        }

        public void PrintMatrix()
        {
            Console.WriteLine("Matrix [{0}x{1}]: ", m, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[j,i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
