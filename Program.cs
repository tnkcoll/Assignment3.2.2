using System.Security.Cryptography.X509Certificates;

namespace Assignment3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
            int[,] matrix3 = new int[2,2];

            AddMatrix(matrix1, matrix2, matrix3);
            PrintMatices(matrix1, "The first matrix is: ");
            PrintMatices(matrix2, "The second matrix is: ");
            PrintMatices(matrix3, "The sum of the two matrices is: ");

        }
        
        public static void AddMatrix(int[,] m1, int[,] m2, int[,] m3)
        {
            int rows = m1.GetLength(0);
            int columns = m1.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    m3[i, j] = m1[i, j] + m2[i,j];
                }
            }
        }

        public static void PrintMatices(int[,] matrix, string matrixNumber)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            Console.WriteLine(matrixNumber);

            for (int i = 0; i < rows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
