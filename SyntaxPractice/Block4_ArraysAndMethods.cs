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
    }
}
