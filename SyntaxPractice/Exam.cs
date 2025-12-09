using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SyntaxPractice
{
    internal class Exam
    {
        public static int[] RndArray()
        {
            Random rnd = new Random();
            int size = rnd.Next(1,10);
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
            return array;
        }
        public static void GetArrayStatistics(int[] inputData, out int max, out int min, out int sum, out decimal avg)
        {
            max = inputData[0]; min = inputData[0];

            sum = 0; avg = 0; 
            int counts = inputData.Length;

            for (int i = 0; i < inputData.Length; i++)
            {
                if (inputData[i] > max) max = inputData[i]; //максимальный элемент
                if (inputData[i] < min) min = inputData[i]; //минимальный элемент
                sum += inputData[i];
            }
            avg = (decimal)sum / (decimal)counts;
        }

        public static void Test_GetArrayStatistics()
        {
            int[] array = RndArray(); // получил рандомно наполненный массив
            int max = 0, min = 0, sum = 0; decimal avg = 0;
            GetArrayStatistics(array, out max, out min, out sum, out avg);

            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.Write($"\n{max} {min} {sum} " + avg);
        }
    }
}
