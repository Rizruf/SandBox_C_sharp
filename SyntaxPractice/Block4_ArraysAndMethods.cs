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
        public static void PrintArray (int[] arryaToPrint)
        {
            foreach (int ArrayElement in arryaToPrint)
            {
                Console.Write($"{ArrayElement} ");
            }
        }
        public static void Test_PrintArray()
        {
            int[] fristArray = {1, 2, 3, 4, 5};
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
            int[] array = new int [5];

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
                Console.WriteLine("Введите " +  (arrayElement + 1) + " элемент массива");
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

        public static int GetSum (int[] array)
        {
            int sumNumbers = 0;

            foreach (int arrayElement in array)
            {
                sumNumbers += arrayElement;
            }

            return sumNumbers;
        }
        public static double GetAverage (int[] array)
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
            else
            {
                int[] array = new int[size];
                for (int arrayElement = 0; arrayElement < array.Length; arrayElement++)
                {
                    array[arrayElement] = rnd.Next(0, 100);
                }
                return array;
            }
        }


        public static int FindMin( int[] array )
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Размер массива 0");
                return 0;
            }
            else
            {
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
                
        }
        public static int FindMax ( int[] array )
        {

            if (array.Length == 0)
            {
                Console.WriteLine("Размер массива 0");
                return 0;
            }
            else
            {
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

        

    }
}
