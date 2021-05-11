using System;
using System.Threading;
using System.Threading.Tasks;

namespace Fork_n_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedMatrix = new int[3][]
                                                { new int[] { 1,2, 3, 4, 5 },
                                                  new int[] { 6, 7, 8, 9, 10 },
                                                  new int[] { 11, 12, 13, 14, 15 } };

            Console.WriteLine("Sum of all elements in this matrix is equal " + Matrix.SumOfElement(jaggedMatrix));

            Console.ReadKey();
        }
    }
}
