using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SyntaxPractice
{
    public static class Block4_ArraysAndMethods
    {
        public static void PrintArray(int[] arryaToPrint)
        {
            foreach (int ArrayElement in arryaToPrint)
            {
                Console.Write($"{ArrayElement} ");
            }
        }
        public static void Test_PrintArray()
        {
            int[] fristArray = { 1, 2, 3, 4, 5 };
            int[] secondArray = { 2, 3, 5, 1, -6, -2 };

            //int thirdArray = 10;

            Block4_ArraysAndMethods.PrintArray(fristArray);
            Console.WriteLine();
            Block4_ArraysAndMethods.PrintArray(secondArray);

            //При попытке засунуть инт под видом массива, среда разработки говорит что нельзя так делать. 2 разных типа.
            //Block4_ArraysAndMethods.PrintArray(thirdArray);


        }

        public static void FillArrayWithRandoms(int[] arrayToFill, int beginningInterval, int boundaryInterval, Random randGenerator)
        {


            if (boundaryInterval < beginningInterval)
            {
                int gap = beginningInterval;
                beginningInterval = boundaryInterval;
                boundaryInterval = gap;
            }

            for (int elementNumber = 0; elementNumber < arrayToFill.Length; elementNumber++)
            {
                int RandomElement = randGenerator.Next(beginningInterval, boundaryInterval);
                arrayToFill[elementNumber] = RandomElement;
            }
        }
        public static void Test_FillArrayWithRandoms()
        {
            Random randGenerator = new Random();
            int[] array = new int[5];

            Console.WriteLine("Введите ограничение для генерации целых чисел, от и до числа, для массива");

            Console.Write("\nВведите начало интервала - ");
            int beginningInterval = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nВведите конец интервала - ");
            int boundaryInterval = Convert.ToInt32(Console.ReadLine());

            if (beginningInterval == 0 && beginningInterval == 0)
            {
                Console.WriteLine("Вы ввели массив с нулями");
            }
            else if (beginningInterval == beginningInterval && boundaryInterval == boundaryInterval)
            {
                Console.WriteLine("Вы ввели массив с одним числом");
            }

            Block4_ArraysAndMethods.FillArrayWithRandoms(array, beginningInterval, boundaryInterval, randGenerator);
            Block4_ArraysAndMethods.PrintArray(array);
        }

        public static int[] FillCreateArrayFromUserInput(int size)
        {
            int[] array = new int[size];

            for (int arrayElement = 0; arrayElement < size; arrayElement++)
            {
                Console.WriteLine("Введите " + (arrayElement + 1) + " элемент массива");
                int inputElementValue = Convert.ToInt32(Console.ReadLine());
                array[arrayElement] = inputElementValue;
            }

            return array;
        }
        public static void Test_FillCreateArrayFromUserInput()
        {
            Console.Write("Введите размерность массива - ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            if (sizeArray == 0)
            {
                Console.Write("Ваш массив не существует т.к размер его 0");
                return;
            }

            int[] creatArray = FillCreateArrayFromUserInput(sizeArray);

            Block4_ArraysAndMethods.PrintArray(creatArray);

        }

        public static int GetSum(int[] array)
        {
            int sumNumbers = 0;

            foreach (int arrayElement in array)
            {
                sumNumbers += arrayElement;
            }

            return sumNumbers;
        }
        public static double GetAverage(int[] array)
        {
            double value = Convert.ToDouble(Block4_ArraysAndMethods.GetSum(array));
            double counts = array.Length;
            double avr;

            avr = value / counts;

            return avr;
        }
        public static void Test_SumAndAverage()
        {
            Console.WriteLine("Задан массив из случайных чисел");
            Random rnd = new Random();

            Console.Write("Задайте размер массива - ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            if (sizeArray == 0 || sizeArray < 0)
            {
                Console.WriteLine("Вы ввели массив в котором ничего нет - 0");
            }
            else
            {
                int[] CurrentArray = Block4_ArraysAndMethods.CreateRandomArray(sizeArray, rnd);

                Console.WriteLine("\nСумма чисел в массива - " + Block4_ArraysAndMethods.GetSum(CurrentArray));
                Console.WriteLine("Усредненное число массива - " + Block4_ArraysAndMethods.GetAverage(CurrentArray));
            }

        }


        public static int[] CreateRandomArray(int size, Random rnd)
        {
            if (size == 0 || size < 0)
            {
                return new int[0];
            }
            int[] array = new int[size];
            for (int arrayElement = 0; arrayElement < array.Length; arrayElement++)
            {
                array[arrayElement] = rnd.Next(0, 100);
            }
            return array;
        }


        public static int FindMin(int[] array)
        {
            if (array.Length == 0)
            {
                throw new InvalidOperationException("Невозможно найти минимальный элемент в пустом массиве.");
            }
            int minValue = array[0];
            foreach (int minElement in array)
            {
                if (minValue > minElement)
                {
                    minValue = minElement;
                }
            }
            return minValue;
        }
        public static int FindMax(int[] array)
        {

            if (array.Length == 0)
            {
                throw new InvalidOperationException("Невозможно найти минимальный элемент в пустом массиве.");
            }
            int maxValue = array[0];
            foreach (int maxElement in array)
            {
                if (maxValue < maxElement)
                {
                    maxValue = maxElement;
                }
            }
            return maxValue;
        }
        public static void Test_FindMaxAndFindMin()
        {
            Console.Write("Введите размер массива - ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            int[] currentArray = Block4_ArraysAndMethods.CreateRandomArray(sizeArray, rnd);

            Block4_ArraysAndMethods.PrintArray(currentArray);
            Console.WriteLine("\nМинимальное значение в массиве - " + Block4_ArraysAndMethods.FindMin(currentArray));
            Console.WriteLine("Максимальное значение в массиве - " + Block4_ArraysAndMethods.FindMax(currentArray));
        }

        public static int[] PrintReversedArray(int[] array)
        {
            int elementsReversed = 0;
            if (array.Length == 0)
            {
                return new int[0];
            }

            int[] reversedArray = new int[array.Length];
            for (int arrayElements = array.Length - 1; arrayElements >= 0; arrayElements--)
            {
                reversedArray[elementsReversed] = array[arrayElements];
                elementsReversed++;
            }
            return reversedArray;
        }
        public static void Test_PrintReversedArray()
        {
            Console.Write("Введите размер массива - ");
            int size = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int[] currentArray = Block4_ArraysAndMethods.CreateRandomArray(size, rnd);

            Block4_ArraysAndMethods.PrintArray(currentArray);
            int[] reversedARray = Block4_ArraysAndMethods.PrintReversedArray(currentArray);
            Console.Write("\nПеревернутый массив - ");
            Block4_ArraysAndMethods.PrintArray(reversedARray);
        }

        public static bool Contains(object[] array, object element)
        {
            bool find = false;
            foreach (object item in array)
            {
                if (item == element)
                {
                    find = true;
                    break;
                }
            }
            return find;
        }
        public static void Test_Contains()
        {
            object[] array = { 1, "telephone", "bomba", "legs", "eye" };

            object findElement = "bomba";
            object findElement2 = "bimba";

            bool isBombaFound = Block4_ArraysAndMethods.Contains(array, findElement);
            bool isBimbaFound = Block4_ArraysAndMethods.Contains(array, findElement2);

            Console.WriteLine("Ищем 'bomba'. Результат: " + isBombaFound);
            Console.WriteLine("Ищем 'bimba'. Результат: " + isBimbaFound);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                }
                Console.WriteLine();
            }
        }
        public static void Test_PrintMatrix()
        {
            int[,] matrix =
            {
                {1, 2, 3, 4, 5, 6},
                {7, 8, 9, 10, 11, 12}
            };

            Block4_ArraysAndMethods.PrintMatrix(matrix);
        }

        public static int[] CopyArray(int[] array)
        {
            int size = array.Length;
            int[] copyArray = new int[size];

            for (int elements = 0; elements < copyArray.Length; elements++)
            {
                copyArray[elements] = array[elements];
            }
            return copyArray;
        }
        public static void Test_CopyArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            int[] copyArray = Block4_ArraysAndMethods.CopyArray(array);

            foreach (int elements in copyArray)
            {
                Console.Write($"{elements} ");
            }

            array[3] = 10; Console.WriteLine();

            foreach (int elements in array)
            {

                Console.Write($"{elements} ");
            }
        }

        public static int[] Sort(int[] array)
        {
            Array.Sort(array);
            return array;
        }
        public static void Test_Sort()
        {
            int[] array = { 10, 20, 54123, 123, 122, 123 };

            int[] sort = Block4_ArraysAndMethods.Sort(array);

            foreach (int elementSortArray in sort)
            {
                Console.Write($"{elementSortArray} ");
            }
        }

        public static int[] MergeArrays(int[] array1, int[] array2)
        {
            int lengthMrgeArray = array1.Length + array2.Length;
            int[] mergeArray = new int[lengthMrgeArray];

            for (int elementsArray1 = 0; elementsArray1 < array1.Length; elementsArray1++)
            {
                mergeArray[elementsArray1] = array1[elementsArray1];

            }
            for (int elementsArray2 = 0; elementsArray2 < array2.Length; elementsArray2++)
            {
                mergeArray[array1.Length + elementsArray2] = array2[elementsArray2];
            }
            return mergeArray;
        }
        public static void Test_MergeArrays()
        {
            int[] array1 = new int[0];
            int[] array2 = new int[0];

            int[] mergeArray = Block4_ArraysAndMethods.MergeArrays(array1, array2);

            if (mergeArray.Length == 0)
            {
                Console.WriteLine("Массив ничего в себя не получил, потому что его размер 0");
            }

            foreach (int mergeElements in mergeArray)
            {
                Console.Write($"{mergeElements} ");
            }
        }

        public static int[] ShiftLeft(int[] array)
        {
            int[] shiftLeftArray = array;
            int elementToSave = shiftLeftArray[0];

            for (int elementsArrayShift = 1; elementsArrayShift < shiftLeftArray.Length; elementsArrayShift++)
            {
                shiftLeftArray[elementsArrayShift - 1] = shiftLeftArray[elementsArrayShift];
            }
            shiftLeftArray[shiftLeftArray.Length - 1] = elementToSave;

            return shiftLeftArray;
        }
        public static int[] ShiftRight(int[] array)
        {
            int[] shiftRightArray = array;
            int elementToSave = shiftRightArray[shiftRightArray.Length - 1];

            for (int elementsArrayShift = shiftRightArray.Length - 1; elementsArrayShift >= 1; elementsArrayShift--)
            {
                shiftRightArray[elementsArrayShift] = shiftRightArray[elementsArrayShift - 1];
            }
            shiftRightArray[0] = elementToSave;

            return shiftRightArray;
        }
        public static void Test_ShiftLeft()
        {
            int[] array1 = { 10, 20, 30, 10, 20, 50, 140, 90 };

            if (array1.Length <= 0)
            {
                Console.WriteLine("Массив пустой!");
            }
            else
            {
                Block4_ArraysAndMethods.ShiftLeft(array1);
                Block4_ArraysAndMethods.ShiftRight(array1);
            }
        }

        public static void PrintArrayOverload(string[] array)
        {
            foreach (string element in array)
            {
                Console.Write($"{element} ");
            }
        }
        public static void PrintArrayOverload(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
        }
        public static void Test_PrintArrayOverload()
        {
            int[] array = { 10, 20, 30, 40 };
            string[] array1 = { "nothing", "gfgf" };

            Block4_ArraysAndMethods.PrintArrayOverload(array1);
            Block4_ArraysAndMethods.PrintArrayOverload(array);

        }

        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
        public static void Test_Swap()
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"До: x={x}, y={y}");

            Block4_ArraysAndMethods.Swap(ref x, ref y);
            Console.WriteLine($"После: x={x}, y={y}");
        }

        public static void GetArrayStats(int[] array, out int sum, out int max, out int min)
        {

            if (array.Length <= 0)
            {
                min = 0; max = 0; sum = 0;
                Console.WriteLine("Массив не заполнен ничем!");
                return;
            }

            min = array[0]; max = array[0]; sum = 0;
            foreach (int element in array)
            {
                if (max < element)
                {
                    max = element;
                }
                if (min > element)
                {
                    min = element;
                }

                sum += element;
            }
        }
        public static void Test_GetArrayStats()
        {
            int[] array = { 1000, 200, 50, 200, 220, 150, 300, 900, 7000 };

            Block4_ArraysAndMethods.GetArrayStats(array, out int sum, out int max, out int min);

            Console.WriteLine("Сумма ваших чисел в массиве - " + sum);
            Console.WriteLine("Минимум ваших чисел в массиве - " + max);
            Console.WriteLine("Максимум ваших чисел в массиве - " + min);

        }

        public static long RecursFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            long resault = n * RecursFactorial(n - 1);
            return resault;
        }
        public static void Test_RecursFactorial()
        {
            int number = 7;

            Console.WriteLine("Факториал " + number + " равен - " + Block4_ArraysAndMethods.RecursFactorial(number));
        }

        public static int CalculateSum(params int[] array)
        {
            int sum = 0;
            if (array.Length == 0)
            {
                return sum;
            }

            
            foreach (int elements in array)
            {
                sum += elements;
            }
            return sum;
        }
        public static void Test_CalculateSum()
        {
            int[] array = { 10, 30, 50, 70, 90 };
            Console.WriteLine(Block4_ArraysAndMethods.CalculateSum(10,20,50,70,90));
            Console.WriteLine(Block4_ArraysAndMethods.CalculateSum(array));
        }

        public static char[] SplitString (string text)
        {
            char[] textSeparate;
            textSeparate = text.ToCharArray();
        }
    }
}
