using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[,] matrix = new string[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                for (int a = 0; a < matrix.GetLength(1); a++)
                {
                    matrix[i, a] = input[a];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int a = 0; a < matrix.GetLength(1); a++)
                {
                    Console.Write("Neighbour for " + matrix[i, a] + " is:");
                    if (i > 0)
                    {
                        Console.Write(matrix[i - 1, a]);
                    }

                    if (i < matrix.GetLength(0) - 1)
                    {
                        Console.Write(matrix[i + 1, a]);
                    }

                    if (a > 0)
                    {
                        Console.Write(matrix[i, a - 1]);
                    }

                    if (a < matrix.GetLength(1) - 1)
                    {
                        Console.Write(matrix[i, a + 1]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
