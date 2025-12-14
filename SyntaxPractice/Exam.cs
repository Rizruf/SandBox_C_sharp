using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SyntaxPractice
{
    internal class Exam
    {
        public static int[] RndArray()
        {
            Random rnd = new Random();
            int size = rnd.Next(1, 10);
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

        //Конец первого задания.
        public static string ValidText()
        {
            while (true)
            {
                Console.Write("Введите текст для расшифровки:");
                string text = Console.ReadLine();

                if (string.IsNullOrEmpty(text))
                {
                    Console.WriteLine("Вы ничего не ввели!");
                    continue;
                }

                string currentText = text.ToLower();
                bool isClean = true;

                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsDigit(text[i]))
                    {
                        isClean = false;
                        break;
                    }
                }
                if (isClean) return currentText;

                Console.WriteLine("Некорректный ввод, проверьте все ли в порядке с текстом");
            }
        }
        public static int ValidSteps()
        {
            while (true)
            {
                Console.Write("Введите число сдвига: ");
                if (int.TryParse(Console.ReadLine(), out int shift) && shift != 0)
                {
                    return shift;
                }
                Console.WriteLine("Нужно целое число, не равное нулю!");
            }
        }

        public static string DecryptAndEncrypt(string text, int shift)
        {
            const string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            StringBuilder sb = new StringBuilder();
            int newIndex; bool isFound = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    sb.Append(' ');
                    continue;
                }

                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (text[i] == alphabet[j])
                    {
                        newIndex = (j + shift) % alphabet.Length;
                        if (newIndex < 0)
                        {
                            newIndex += alphabet.Length;
                        }
                        sb.Append(alphabet[newIndex]);
                        isFound = true;
                        break;
                    }
                    else isFound = false;
                }
                if (!isFound)
                {
                    sb.Append(text[i]);
                }
            }
            return sb.ToString();
        }
        public static void RunCaesarCipher()
        {
            while (true)
            {
                Console.WriteLine("\n1 - Расшифровать, 2 - Зашифровать, 0 - Выход");
                string choice = Console.ReadLine();

                if (choice == "0") break;

                if (choice == "1" || choice == "2")
                {
                    string text = ValidText();
                    int shift = ValidSteps();

                    if (choice == "1")
                    {
                        Console.WriteLine("Расшифровали ваш текст - " + DecryptAndEncrypt(text, -shift));
                    }
                    else
                    {
                        Console.WriteLine("Зашифровали ваш текст - " + DecryptAndEncrypt(text, shift));
                    }
                }
                else
                {
                    Console.WriteLine("Неверный выбор!");
                }
            }
        }
        //Конец второго задания

        public static string ReverseWords(string text)
        {
            string[] arrayWords = text.Split(" ");

            string[] reverseWords = new string[arrayWords.Length];

            for (int i = 0; i < arrayWords.Length; i++)
            {
                reverseWords[i] = arrayWords[arrayWords.Length - 1 - i];
            }

            return string.Join(" ", reverseWords);

            //StringBuilder sb = new StringBuilder();

            //for (int i = arrayWords.Length - 1; i >= 0; i--)
            //{
            //    if (arrayWords[i] == string.Empty)
            //    {
            //        sb.Append(" ");
            //        continue;
            //    }
            //    sb.Append($"{arrayWords[i]} ");
            //}
            //return sb.ToString(); 
        }
        public static void Test_ReverseWords()
        {
            Console.WriteLine("Введите предложение для зазворота его задом на перед!");
            string text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Вы ввели пустую строку, повторите!");
            }
            else Console.WriteLine(ReverseWords(text));
        }
        //Конец задачи 3

        public static string SelectionSort(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexSwap = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[indexSwap])
                    {
                        indexSwap = j;
                    }
                }
                if (indexSwap != i)
                {
                    (array[i], array[indexSwap]) = (array[indexSwap], array[i]);
                }
            }
            return string.Join(" ", array);
        }
        public static void Test_SelectionSort()
        {
            Random rnd = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 100);
                Console.Write($"{array[i]} ");
            } 

            Console.WriteLine("\nСортированый массив! - " + SelectionSort(array));
        }
    }
}
