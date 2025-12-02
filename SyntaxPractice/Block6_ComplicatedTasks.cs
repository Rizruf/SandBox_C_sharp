using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
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
        public static void ATMmachine2()
        {
            Console.WriteLine("Вы вставили карточку в банкомат, выберите действие - ");

            bool card = true;
            Random rnd = new Random();
            int balance = rnd.Next(1, 100000);

            while (card == true)
            {
                Console.WriteLine("1.Проверить баланс");
                Console.WriteLine("2.Снять наличные");
                Console.WriteLine("3.Совершить перевод денежных средств кому-то случайному");
                Console.WriteLine("4.Выход");

                string inputNum = Console.ReadLine();
                if (int.TryParse(inputNum, out int choicenuber))
                {
                    if (choicenuber > 0 && choicenuber <= 4)
                    {
                        switch (choicenuber)
                        {
                            case 1:
                                Console.WriteLine("Ваш баланс - " + balance);
                                continue;
                            case 2:
                                while (true)
                                {
                                    Console.WriteLine("Условия снятия денег: Баланс положительный, запрашиваемые средаства не привышают число баланса, число снятия кратно 100");
                                    Console.WriteLine("Сколько денег хотели бы снять?");
                                    string moneyoff = Console.ReadLine();

                                    if (int.TryParse(moneyoff, out int moneyOut) && moneyOut > 0 && moneyOut <= balance && moneyOut % 100 == 0 && balance > 0)
                                    {
                                        Console.WriteLine("Пересчитываем деньги и выдаем вам - " + moneyOut);
                                        Console.WriteLine("Ваш баланс - " + (balance -= moneyOut));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Некорректный ввод - повторите или условия не соблюдены.");
                                        continue;
                                    }
                                }
                                continue;
                            case 3:
                                while (true)
                                {
                                    Console.WriteLine("Сколько денег хотели бы перевести?");
                                    string transfer = Console.ReadLine();

                                    if (int.TryParse(transfer, out int moneyTransfer) && moneyTransfer > 0 && moneyTransfer <= balance && moneyTransfer % 100 == 0 && balance > 0)
                                    {
                                        Console.WriteLine("Пересчитываем деньги и переводим - " + moneyTransfer);
                                        Console.WriteLine("Ваш баланс - " + (balance -= moneyTransfer));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Некорректный ввод - повторите.");
                                        continue;
                                    }
                                }
                                continue;
                            case 4:
                                Console.WriteLine("Выходим");
                                Console.WriteLine("Всего доброго!");
                                card = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы выбрали что-то не то");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Вы выбрали что-то не то");
                    Console.WriteLine("Возвращаем вашу карту");
                    card = false;
                    Console.WriteLine("Всего доброго!");
                }
            }
                

        }
    }
}
