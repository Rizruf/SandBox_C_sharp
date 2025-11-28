using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            int temp;

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

        public static void MultiplyMatrixByNumber(int number, int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                return; 
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] *= number;
                }
            }
        }
        public static void Test_MultiplyMatrixByNumber()
        {
            int[,] matrix =
            {
                {1,3,5,7},
                {11,23,57,21 },
                {213,43,231,4312}
            };
            int num = 10;

            Block5_ComplicatedTasks.MultiplyMatrixByNumber(num, matrix);

            if (matrix != null)
            {
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    for (int l = 0; l < matrix.GetLength(1); l++)
                    {
                        Console.Write($"{matrix[k, l]} ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Тест с null пройден: Матрица осталась null, метод не упал.");
            }
        }

        public static int GetTotalLengthOfJaggedArray(int[][] array)
        {
            if(array == null)
            {
                return 0;
            }
            int count = 0;
            //int sum = 0;

            
             for (int i = 0; i < array.Length; i++)
             {
                 if (array[i] != null)
                 {
                  count += array[i].Length;
                  //sum += array[i][j];
                 }
             }
            
            return count;
        }
        public static void Test_GetTotalLengthOfJaggedArray()
        {
            int[][] array = new int [5][];
            {
                array[0] = new int[] {1,3,5,7};
                array[1] = new int[] { 11, 23, 57, 21 };
                array[2] = new int[] { 213, 43, 231, 4312 };
                array[3] = new int[] { 213, 5543, 24431, 431112 };
                array[4] = new int[] { 213, 423, 2331, 4312 };
            }
            Console.WriteLine(Block5_ComplicatedTasks.GetTotalLengthOfJaggedArray(array));
        }

        public static int[][] CreateRandomJaggedArray(int rows, int cols)
        {
            if (rows == 0 || cols == 0)
            {
                int[][] array1 =  new int [1][];
                array1[0] = new int[] { 0 };
                return array1;
            }

            Random rnd = new Random();
            int[][] array = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[rnd.Next(1,cols + 1)];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array [i][j] = rnd.Next (0, 100);
                }
            }
            return array;
        }
        public static void Test_CreateRandomJaggedArray()
        {
           int rows = 10, cols = 10;
            int[][] array = Block5_ComplicatedTasks.CreateRandomJaggedArray(rows, cols);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[][] SortJaggedArrayRows (int[][] array)
        {
            if (array.Length == 0)
            {
                int[][] array1 = new int[1][];
                array1[0] = new int[] { 0 };
                return array1;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Array.Sort(array[i]);
            }
            return array;
        }
        public static void Test_SortJaggedArrayRows()
        {
            int[][] array = Block5_ComplicatedTasks.CreateRandomJaggedArray(10, 10);

            Block5_ComplicatedTasks.SortJaggedArrayRows(array);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[] GetLongestRow(int[][] array)
        {

            if (array.Length == 0)
            {
                int[] array1 = new int[1];
                array1[0] = 0;
                return array1;
            }

            int maxLength = array[0].Length;
            int[] arrayOut = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > maxLength)
                {
                    maxLength = array[i].Length;
                    arrayOut = array[i];
                }
            }
            return arrayOut;
        }
        public static void Test_GetLongestRow()
        {
            int[][] array = Block5_ComplicatedTasks.CreateRandomJaggedArray(10, 10);
            int[] arrayOut = Block5_ComplicatedTasks.GetLongestRow(array);

            for (int i = 0; i < arrayOut.Length; i++)
            {
               Console.Write($"{arrayOut[i]} ");
            }

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }
        }


    }
}
