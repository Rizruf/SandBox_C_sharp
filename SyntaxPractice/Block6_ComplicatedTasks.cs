using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxPractice
{
    internal class Block6_ComplicatedTasks
    {
        public static void GameGuessNumber2()
        {
            Random rnd = new Random();
            int guessNum = rnd.Next(1, 101);
            int counts = 0;
            bool isWin = false;

            Console.WriteLine("Компьютер задал число от 1 до 100 угадывай.");

            while (counts < 7)
            {
                Console.WriteLine("Введите число которое считаете нужным -  если хотите выйте напишите 0.");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int numInput))
                {
                    counts++;
                    if (numInput == 0)
                    {
                        Console.WriteLine("Выходим");
                        break;
                    }
                    else if (numInput < 0)
                    {
                        Console.WriteLine("Вы ввели число меньше нуля, попробуйте снова!");
                        continue;
                    }

                    if (guessNum > numInput)
                    {
                        Console.WriteLine("Больше!");
                    }
                    else if (guessNum < numInput)
                    {
                        Console.WriteLine("Меньше!");
                    }
                    else
                    {
                        Console.WriteLine("Вы угадали!");
                        isWin = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели что-то не то, повторим!");
                    continue;
                }
                
            }
            if (counts == 7 && isWin != true)
            {
                Console.WriteLine("Кончились попытки, вы проиграли!");
            }
        }
    }
}
