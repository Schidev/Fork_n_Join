using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fork_n_Join
{
    public class Matrix
    {
        private static Barrier _barrier;
        private static int[][] _matrix;
        private static int[] _rowsum;

        public static int SumOfElement(int[][] matrix)
        {
            _matrix = matrix;
            _rowsum = new int[matrix.Length];
            _barrier = new Barrier(matrix.Length + 1);
            ThreadsControl();
            
            return Result();
        }

        private static void ThreadsControl()
        {
            for (int i = 0; i < _barrier.ParticipantCount - 1; i++)
            {
                new Thread(RowSum).Start(i);
            }
            _barrier.SignalAndWait();
        }

        private static void RowSum(object o)
        {
            int i = (int)o;

            for (int j = 0; j < _matrix[i].Length; j++)
            {
                _rowsum[i] += _matrix[i][j];
            }

            _barrier.SignalAndWait();
        }

        private static int Result()
        {
            int result = 0;
            for (int k = 0; k < _rowsum.Length; k++)
            {
                result += _rowsum[k];
            }
            return result;
        }
    }
}
