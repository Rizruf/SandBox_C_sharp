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

        public static int[] FindMaxValueCoordinates(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                return new int[] { 0, 0 }; 
            }

            int max = matrix[0, 0];
            int coordX = 0;
            int coordY = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max) 
                    {
                        max = matrix[i, j]; 
                        coordX = i;         
                        coordY = j;
                    }
                }
            }

            return new int[] { coordX, coordY };
        }
        public static void Test_FindMaxValueCoordinates()
        {
            int[,] matrix =
            {
                {1,3,5,7},
                {11,23,57,21 },
                {213,43,231,4312}
            };

            int[] coordinates = Block5_ComplicatedTasks.FindMaxValueCoordinates(matrix);
            foreach (int item in coordinates)
            {
                Console.Write($"{item}");
            }
        }

        public static int[,] TransposeMatrix(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                return new int[,] { { 0, 0 } };
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] newArray = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newArray[j, i] = matrix[i, j];
                }
            }
            return newArray;
        }
        public static void Test_TransposeMatrix()
        {
            int[,] matrix =
            {
                {1,3,5,7},
                {11,23,57,21 },
                {213,43,231,4312}
            };

            int[,] newArray = Block5_ComplicatedTasks.TransposeMatrix(matrix);

            for (int k = 0; k < newArray.GetLength(0); k++)
            {
                for (int l = 0; l < newArray.GetLength(1); l++)
                {
                    Console.Write($"{newArray[k, l]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] MirrorMatrixHorizontally (int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                return new int[,] { { 0, 0 } };
            }

            int temp, value1, value2;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1)/2; j++)
                {
                    temp = matrix[i, j];
                    matrix[i,j] = matrix[i, matrix.GetLength(1) - 1 - j];
                    matrix[i, matrix.GetLength(1) - 1 - j] = temp;
                }
            }

            return matrix;
        }
        public static void Test_MirrorMatrixHorizontally()
        {
            int[,] matrix =
            {
                {1,3,5,7},
                {11,23,57,21 },
                {213,43,231,4312}
            };

            int[,] newMatrix = Block5_ComplicatedTasks.MirrorMatrixHorizontally(matrix);

            for (int k = 0; k < newMatrix.GetLength(0); k++)
            {
                for (int l = 0; l < newMatrix.GetLength(1); l++)
                {
                    Console.Write($"{newMatrix[k, l]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
