using System;
using System.Globalization;

namespace cmp
{
    class aBeautifulMatrix
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5 , 5];

            for (int i = 0; i < 5; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }
            
            int currentRow = 0;
            int currentCol = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        currentRow = i;
                        currentCol = j;
                    }
                }
            }
            
            int move = Math.Abs(currentRow - 2) + Math.Abs(currentCol - 2);
            Console.WriteLine(move);
        }
    }
}

