using System;

namespace _42.uzd_Array2d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }
        }
    }
}
// Izveidot divdimensiju masīvu int[5,5] un piešķirt elementiem vērtības. Izdrukāt visu elementu vērtības console.
