using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public static void ATMachine2()
        {
            Random rnd = new Random();
            int balance = rnd.Next(1, 500000);

            while (true)
            {
                Console.WriteLine("Хотите ли вы вставить карту в банкомат? 1 - да 2 - нет");
                string condition = Console.ReadLine();

                if (char.TryParse(condition, out char entryСondition))
                {
                    if (entryСondition == '1')
                    {
                        Console.WriteLine("Вы вставили карту, добро пожаловать в банк!\n");
                        while (true)
                        {
                            Console.WriteLine("Выберите операцию для взаимодействия со счетом - \n");

                            //Операции 
                            Console.WriteLine("1. Проверить баланс");
                            Console.WriteLine("2. Пополнить карту");
                            Console.WriteLine("3. Снять наличные"); //Выдача тоже имитируется
                            Console.WriteLine("4. Показать нужное количество средств в другой валюте");
                            Console.WriteLine("5. Хотите выйти?\n");

                            string operation = Console.ReadLine();

                            if (char.TryParse(operation, out char entryOperation))
                            {
                                switch (entryOperation)
                                {
                                    case '1':
                                        CheckingBalance(balance);
                                        continue;

                                    case '2':
                                        balance = AddFundsToCards(balance);
                                        continue;

                                    case '3':
                                        balance = CashWithdrawal(balance);
                                        continue;

                                    case '4':
                                        ViewingTheExchangeRate();
                                        continue;

                                    case '5':

                                        Console.WriteLine("Хорошего дня!");
                                        break;

                                    default:
                                        Console.WriteLine("Неизвестная операция, повторите запрос.");
                                        continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nВы ввели некорректные данные! Повторите.\n");
                                continue;
                            }

                            break;
                        }
                        break;
                    }
                    else if (entryСondition == '2')
                    {
                        Console.WriteLine("\nПриятно видеть что вы пользуетесь нашим банком хоть и уходите!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nВвели не верный вариант - пожалуйста повторите");
                        continue;
                    }
                }
            }
        }
        public static void CheckingBalance(int valueBalance)
        {
            Console.WriteLine("\nВаш баланс - " + valueBalance + "\n");
        }
        public static int AddFundsToCards(int valueBalance)
        {
            while (true)
            {
                Console.WriteLine("\nСколько средств поступит на карту?");
                Console.WriteLine("Условия: Мелочь не принимается, Наличные 10, 50, 1000, 5000. Количество купюр не ограничено.");
                Console.WriteLine("Если хотите выйте напишите НАЗАД\n");
                string moneyInCard = Console.ReadLine();
                string moneyCheckOut = moneyInCard;
                moneyCheckOut = moneyCheckOut.ToLower();
                if (moneyCheckOut == "назад")
                {
                    break;
                }

                if (int.TryParse(moneyInCard, out int payment))
                {
                    if (payment > 0)
                    {
                        if (payment % 10 == 0)
                        {
                            valueBalance += payment;
                            Console.WriteLine("\nКарта пополнена, ваш баланс - " + $"{valueBalance}\n");
                        }
                        else
                        {
                            Console.WriteLine("Сумма должна быть кратна 10. Повторите.");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели число которое меньше или равно нулю. Повторите.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не корректные данные! Число должно быть больше нуля и не текстом. Повторите.");
                    continue;
                }
                break;
            }
            return valueBalance;
        }
        public static int CashWithdrawal(int valueBalance)
        {
            while (true)
            {
                Console.WriteLine("\nСколько средств хотели бы снять с карты?");
                Console.WriteLine("Условия: Мелочь не выдается, Наличные 10, 50, 1000, 5000. Количество купюр не ограничено.");
                Console.WriteLine("Если хотите выйте напишите НАЗАД\n");

                string withdrawalOfMoney = Console.ReadLine();
                string moneyCheckOut = withdrawalOfMoney;
                moneyCheckOut = moneyCheckOut.ToLower();

                if (moneyCheckOut == "назад")
                {
                    break;
                }

                if (int.TryParse(withdrawalOfMoney, out int moneyOutput))
                {
                    if (moneyOutput > 0 && valueBalance > 0)
                    {
                        if (moneyOutput % 10 == 0)
                        {
                            if (moneyOutput <= valueBalance)
                            {
                                Console.WriteLine("\nПересчитали банкноты, выдаем вам сумму - " + $"{moneyOutput}");
                                valueBalance -= moneyOutput;
                                Console.WriteLine("Ваш баланс - " + $"{valueBalance}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введенная сумма должна быть меньше или равна балансу. Повторите.");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Сумма должна быть кратна 10. Повторите.");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Баланс или введенная сумма меньше нуля. Повторите.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Кажется вы ввели некорректные данные, повторите.");
                    continue;
                }
            }
            return valueBalance;
        }
        public static double CurrencyContainer(char currency)
        {
            double valueNewCurrency = 0;
            switch (currency)
            {
                case '1':
                    valueNewCurrency = 77.7027;
                    break;
                case '2':
                    valueNewCurrency = 90.3438;
                    break;
                case '3':
                    valueNewCurrency = 21.1580;
                    break;
                case '4':
                    valueNewCurrency = 10.9581;
                    break;
                case '5':
                    valueNewCurrency = 18.3292;
                    break;
                case '6':
                    valueNewCurrency = 15.1606;
                    break;
                default:
                    break;
            }
            return valueNewCurrency;
        }
        public static void ViewingTheExchangeRate()
        {
            Console.WriteLine("\nВалюты по нынешнему курсу: \n");

            Console.WriteLine("1. Доллар США(USD) — 77,7027 рубля за 1 доллар;");
            Console.WriteLine("2. Евро(EUR) — 90,3438 рубля за 1 евро;");
            Console.WriteLine("3. Дирхам ОАЭ(AED) — 21,1580 рубля за 1 дирхам;");
            Console.WriteLine("4. Китайский юань(CNY) — 10,9581 рубля за 1 юань;");
            Console.WriteLine("5. Турецкая лира(TRY) — 18,3292 рубля за 10 лир;");
            Console.WriteLine("6. Казахстанский тенге(KZT) — 15,1606 рубля за 100 тенге.\n");

            double newCurrencyValue = 0;

            while (true)
            {
                Console.Write("Выберите нужнаю валюту - ");
                string currencyStr = Console.ReadLine();

                string currencyOut = currencyStr;
                currencyOut = currencyOut.ToLower();

                if (currencyOut == "назад")
                {
                    break;
                }

                if (char.TryParse(currencyStr, out char currency))
                {
                    switch (currency)
                    {
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                            while (true)
                            {
                                Console.WriteLine("Введите сумму для просмотра ее в другой валюте");
                                string rubx = Console.ReadLine();

                                if (double.TryParse(rubx, out double rub))
                                {
                                    if (rub > 0)
                                    {
                                        newCurrencyValue = (rub / CurrencyContainer(currency));
                                        Console.WriteLine("Ваша сумма в установленной валюте равна - " + $"{newCurrencyValue}");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели некорректные данные! Повторите!");
                                    continue;
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Неизвестная операция, повторите запрос.");
                            continue;
                    }
                }
                else
                {
                    Console.WriteLine("Кажется вы ввели некорректные данные или такого выбора не существует, повторите.");
                    continue;
                }
                break;
            }
        }

        public static int SumOddNumbers(int border)
        {
            if (border == 0)
            {
                return 0;
            }
            
            int results = 0;

            for (int i = 1; i <= border; i+=2)
            {
               results += i;
            }
            return results;
        }
        public static void UserOddNumbers()
        {
            while (true)
            {
                Console.WriteLine("Задайте границу для подсчета");
                string border = Console.ReadLine();

                if (int.TryParse(border, out int currentBorder))
                {
                    if (currentBorder >= 0)
                    {
                        Console.WriteLine("Сумма нечетных чисел до заданной границы - " + SumOddNumbers(currentBorder));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите положительное число!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не корректное значение, повторите!");
                    continue;
                }
            }
        }

    }
}

