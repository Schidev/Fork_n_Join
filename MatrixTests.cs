using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fork_n_Join;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fork_n_Join.Tests
{
    [TestClass()]
    public class MatrixTests
    {
        [TestMethod()]
        public void SumOfElementTest()
        {
            int[][] matrix = new int[3][]{
                                        new int[] { 1, 2, 3, 4, 5 },
                                        new int[] { 6, 7, 8, 9, 10 },
                                        new int[] { 11, 12, 13, 14, 15 } };

            int expected = 0;
            for (int m = 0; m < matrix.Length; m++)
            {
                for (int n = 0; n < matrix[m].Length; n++)
                {
                    expected += matrix[m][n];
                }
            }

            int actual = Matrix.SumOfElement(matrix);
            Assert.AreEqual(expected, actual);
        }
    }
}