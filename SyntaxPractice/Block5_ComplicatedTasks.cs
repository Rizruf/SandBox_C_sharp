using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxPractice
{
    internal class Block5_ComplicatedTasks
    {
        public static int GetMatrixSum(int[,] array)
        {
            if (array == null) return 0;

            if (array.GetLength(0) <= 0 || array.GetLength(1) <= 0)
            {
               return 0;
            }

            int row = array.GetLength(0);
            int cols = array.GetLength(1);

            int sumMatrixElements = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sumMatrixElements += array[i, j];
                }
            }

            return sumMatrixElements;
        }
        public static void Test_GetMatrixSum()
        {
            int[,] array =
            {
                {1,2,3,4,5,6},
                {2,3,56,7,3,1},
                {2,5,1,7,19,20}
            };

            Console.WriteLine("Сумма матрицы равна - " + Block5_ComplicatedTasks.GetMatrixSum(array));
        }
    }
}
