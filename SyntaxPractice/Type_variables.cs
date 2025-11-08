using Microsoft.VisualBasic;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public static class Type_variables
{
	public static void AcquaintanceTask()
	{
		int number = 1;
		short little_num = 2;
		byte micro_num = 3;
		long bigest_num = 5;
		sbyte macro_num = 4;

		// преписка uint, ushort беззнаковый, ulong делает так что число не может быть меньше 0

		bool trye_or_false = false;

		// логическая переменная которая принимает только строго 2 значения true или false

		char a = '6';

		// это символьная меременная принимает значение одного символа

		string text = "7";

		double dot_num = 8.14;
		float c = 9.1f;


		// с плавающей точкой

		decimal money = 10m;

		// годится для подсчета денег, для этого и придуман

		//object; принимает в себя любое значение структур и классов
		//dynamic; без понятия

		Console.WriteLine(number + " - " + "Превая переменная это int целочисленная пременная принимающая значение числа целого");
		Console.WriteLine(little_num + " - " + "Вторая переменная это short принимает в себя тоже самое что и int но урезана больше по границам числа которое может принять int");
		Console.WriteLine(micro_num + " - " + "Третья переменная это byte принимает в себя тоже самое что и short но урезана больше по границам числа которое может принять short");
		Console.WriteLine(macro_num + " - " + "Четвертая переменная это sbyte принимает в себя тоже самое что и byte но урезана больше по границам числа которое может принять byte");
		Console.WriteLine(bigest_num + " - " + "Пятая переменная это long принимает в себя тоже самое что и int это самая большая величина в целочисленных переменных"); 

		Console.WriteLine(a + " - " + "Принимает в себя любой символ Char");
		Console.WriteLine(text + " - " + "Преобразует любые данные в строковой формат String");

        Console.WriteLine(dot_num + " - " + "Принимает в себя значения с плавающей точкой Float");
        Console.WriteLine(c + " - " + "Принимает в себя значение с плавающей точкой но ограничена больше чем double");

        Console.WriteLine(money + " - " + "Принимает в себя точные значения удобна для подсчета денег decimal");
    }

    public static void StructFloatAndOperation()
    {
		Console.WriteLine("Введите дробное число 1 для выполнения операция над ним");
		float InputNum1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Введите дробное число 2 для выполнения операция над ним");
        float InputNum2 = float.Parse(Console.ReadLine());

		Console.WriteLine();

        Console.WriteLine("При умножении друг на друга, числа дают " + " " + (InputNum1 * InputNum2));
        Console.WriteLine("При делении друг на друга, числа дают " + " " + (InputNum1 / InputNum2));
        Console.WriteLine("При разности друг на друга, числа дают " + " " + (InputNum1 - InputNum2));
        Console.WriteLine("При сумме друг на друга, числа дают " + " " + (InputNum1 + InputNum2));
    }
	public static void ConvertStringAndAgePerson()
	{
		Console.WriteLine("Введите число которое соотвествует вашим годам жизни");
		int Age = Convert.ToInt32 (Console.ReadLine());

		Console.WriteLine("В следующем году вам будет - " +  (++Age));
	}

	public static void CalculeteSCircle()
	{
		Console.Write("Введите радиус вашего круга  - ");
		double radius = Convert.ToDouble(Console.ReadLine());

		double S = Math.PI * Math.Pow(radius, 2);

		Console.WriteLine("Площать вашего круга - " + S);
	}

	public static void Remainder()
	{
		Console.WriteLine("Введите целое число для определения четное оно или не четное");
		int number = Convert.ToInt32(Console.ReadLine());

		if (number % 2 == 0)
		{
			Console.WriteLine("Число четное вариант 1");
		}
        else
        {
			Console.WriteLine("Число не четное вариант 1");
        }

		bool value = number % 2 == 0;

		if (value)
		{
            Console.WriteLine("Число четное вариант 2");
        }
		else
		{
            Console.WriteLine("Число не четное вариант 2");
        }

		string resault = number % 2 == 0 ? "Чет" : "Нечет";
		Console.WriteLine(resault + " вариант 3");
    }

	public static void InfoObPerson()
	{
		Console.Write("Введите введите свое имя - ");
		string name = Console.ReadLine();

        Console.Write("Введите свою фамилию - ");
        string secondName = Console.ReadLine();

        Console.Write("Введите ввеите город в котором вы проживаете - ");
        string city = Console.ReadLine();

		Console.WriteLine("Вы проживаете в городе - " + city + " вас зовут - " + name + " " + secondName);
    }

	public static void CalculetIMT()
	{
		Console.WriteLine("Введите ваши параметры\n");

		Console.Write("Ваш вес в кг - ");
		double weight = Convert.ToDouble(Console.ReadLine());

		Console.Write("Ваш рост в см - ");
        double height = Convert.ToDouble(Console.ReadLine());
		height = height / 100;

		Console.WriteLine("Ваш ИМТ - " + (weight / Math.Pow(height, 2)));
    }

	public static void ExchangeOfValues()
	{
		int a = 10,b = 20, c = 0;

		Console.WriteLine("Изначальнае значения " + a + " и " + b);

		c = a;
		a = b;
		b = c;

		Console.WriteLine("Получившиеся значение после перемешки - " + a + " и " + b);
	}

	public static void LeightText()
	{
		Console.WriteLine("Введите любое слово чтобы высчитать длину этого слоав");
		string text = Console.ReadLine();

		Console.WriteLine("Длинна вашего слова или текста - " + text.Length);
	}

	public static void CalculeteColories()
	{

        Console.Write("Введите колличество белков - ");
		double proteins = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите колличество жиров - ");
        double fats = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите колличество угливодов - ");
        double carbohydrates = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Калорийность - " + (((proteins + carbohydrates) * 4) + fats * 9));
    }

	public static void CurrencyTransfer()
	{
		const decimal coursRub = 0.012363m;

        Console.Write("Введите сумму в рублях для перевода в доллары - ");
		decimal rubles = Convert.ToDecimal(Console.ReadLine());

		decimal dollars = rubles * coursRub;
		Console.WriteLine("После конвертации, ваша сумма в долларах составила - " + dollars);
    }

	public static void HoursMinutes()
	{
		Console.Write("Введите колличество минут - "); 
		int allMinutes = Convert.ToInt32(Console.ReadLine());

		int hours = allMinutes / 60;
		int minutes = allMinutes % 60;

		Console.WriteLine("Ваши минуты соответствуют - " + hours + " часам " + minutes + " минутам."); 
	}

	public static void Counter()
	{
		Console.Write("Введите любое целое число - ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Прибавим к числу 1 через инкремент (префиксный) который сначала прибавляется, а потом записывается - " + ++num);
		Console.WriteLine("Прибавим к числу 1 через инкремент (постфиксный) который сначала получает в переменную число,\n а потом уже прибавляется - " + num++);
        Console.WriteLine("\nОтнимим от числа 1 аналогично с декрементом (постфиксным) - " + num--);
        Console.WriteLine("Отнимим от числа 1 аналогично с декрементом (префиксным) - " + --num);

		Console.WriteLine("\n\nОтметим что после прибавления или отнимания, число всегда становится новым т.е меняется сама переменная,\n а так же постфиксный декремент и инкремент, при дейтвии над переменной учитывают только на следующем шаге свое значение.");

    }

	public static void CompoundAssignmentAndChar()
	{
		int num = 10;


		Console.WriteLine("\tДействия num += 5; num -= 3; num *= 2; tnum /= 4;\n");

		num += 5;
		num -= 3;
		num *= 2;
		num /= 4;

		Console.WriteLine("Число равняется - " + num + " Данные действия являются сокращением для обычных бинарных операций над переменной.\nИзначальное значение числа = 10.\nДальше оно изменяется 15, 12, 24, 6. Поэтому и в ответ получем шесть.");

		char letter1 = 'A', letter2 = 'B', letter3 = 'C';

		Console.WriteLine("\nТак же вывожу значения хранящиеся в char переменных по заданию.");

		Console.Write($"{letter1} {letter2} {letter3}");

    }

	public static void DateAndLogicalOperators()
	{
		DateTime rightNow = DateTime.Now;
		string formatToData = rightNow.ToString("dd.MM.yyyy");

		Console.WriteLine("Сегодняшняя дата в формате ДД.ММ.ГГГГ - " +  formatToData + "\n");

		Console.WriteLine("Логические операции: && - сокращенное И, \n|| - сокращенное ИЛИ, \n! - НЕ,  \n& - не сокращенное И, \n| - не сокращенное ИЛИ");

		Console.WriteLine("\nЛогические опрераторы делают тоже самое что и в логической математике. По расшифровке все понятно." +
                            "\nОтличие сокращенных (&&, ||) от несокращенных (&, |) операторов в том, что сокращенные не всегда вычисляют правую часть выражения." +
                            "\nА несокращенные (&, |) операторы всегда вычисляют обе части выражения, независимо от результата левой части.\"");

	}
	
	public static void STriangleTemperature()
	{
		Console.Write("Введите основание вашего треугольник - ");
		double baseTriangle = Convert.ToDouble(Console.ReadLine());

		Console.Write("Введите высоту вашего треугольника - ");
		double heightTriangle = Convert.ToDouble(Console.ReadLine());

		double STriangle = 0.5 * baseTriangle * heightTriangle;

		Console.Write("Площадь вашего треугольника равняется - " + STriangle);

		Console.Write("\n\nТеперь введите температуру в цельсиях - ");
		double Celsius = Convert.ToDouble(Console.ReadLine());

		double FTemperature = Celsius*9.0/5+32;

		Console.Write("Ваша температура по фаренгейтам равна - " + FTemperature);
	}
	
	public static void CostAndDiscountAlsoLong()
	{
		//x 100

		//y %

		Console.Write("Введите цену своего товара - ");
		double cost = Convert.ToDouble(Console.ReadLine());

		Console.Write("Введите процент скидки на этикетке - ");
		double procentDiscount = Convert.ToDouble(Console.ReadLine());

		double discount = cost * procentDiscount / 100;

		double costWithDiscount = cost - discount;

		Console.WriteLine("Ваша цена с учето скидки - " + costWithDiscount);

		long tenMilliards = Convert.ToInt64(Math.Pow(10, 10));

		Console.WriteLine($"{tenMilliards} {(tenMilliards-(Math.Pow(10,2)))}");
	}

	public static void WayToFileAndVerbatum()
	{
        Console.WriteLine("Путь к файлу: \"C:\\Program Files\\MyApp\"");

		Console.WriteLine(@"""C:\Program Files\MyApp"".");

    }

	public static void ObjectAndValues()
	{
		object obj = "Hello";

		Console.WriteLine("Проверяем является ли наш obj строкой");

		if (obj is string)
		{
			Console.WriteLine("Наш obj является строкой");
		}
		else if (obj is int)
		{
			Console.WriteLine("Наш obj является целым числом");
		}
		else
		{
            Console.WriteLine("Наш obj является не числом и не строкой");
        }

		Console.WriteLine(@"""С\Programm Files\drone\next.exe"""); //Отработка вербатум и экранирование для запоминания.
		Console.WriteLine("C\\Program Files\\drone\\next.exe");


		Console.WriteLine($"{default(int)} {default(bool)} {default(string)} {default(long)} {default(decimal)} {default(short)}");
		
		DateTime rightNow = DateTime.Now;
		string dateTimeFormat = rightNow.ToString("dd.MM.yyyy"); //повторение вывода сегодняшней даты в определенном формате.

		Console.WriteLine(dateTimeFormat);
	}

	public static void EvenAndOddNumberRange()
	{
		Console.WriteLine("Введите число для проверки на четность и положительность, отритательность");
		int num = Convert.ToInt32(Console.ReadLine());

		if (num % 2 == 0)
		{
            if (num < 0)
            {
                Console.WriteLine("Число четное, но отрицательное");
            }
            else
            {
                Console.WriteLine("Число четное, но положительное");
            }
        }
		else
		{
            if (num < 0)
            {
                Console.WriteLine("Число не четное, но отрицательное");
            }
            else
            {
                Console.WriteLine("Число не четное, но положительное");
            }
        }

		if (num % 2 == 0 && num < 0)
		{

		}
		else if (num % 2 == 0 && num > 0)
		{

		}
		else if (num % 2 != 0 && num < 0)
		{

		}
		else

			Console.Write("Введите целое число которое хотите - ");
		int numberToRange = Convert.ToInt32(Console.ReadLine());

        Console.Write("Укажите начальное число для диапазона - ");
        int rangeForNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Укажите конечное число для диапазона - ");
        int rangeForNumberEnd = Convert.ToInt32(Console.ReadLine());

        bool ans = numberToRange <= rangeForNumberEnd && numberToRange>= rangeForNumber;

		switch (ans)
		{
			case true:
                Console.Write("Ваше число входит в диапазон");
                break;
			case false:
                Console.Write("Ваше число не входит в диапазон");
                break;
			default:
				Console.WriteLine("Вы ввели не число");
				break;
		}

		if (numberToRange <= rangeForNumberEnd && numberToRange >= rangeForNumber)
		{
            Console.WriteLine("\nВаше число входит в диапазон");
        }
		else
		{
            Console.WriteLine("\nВаше число не входит в диапазон");
        }
	}

	public static void CalculatorLeapYearAndTernaryOper()
	{
		Console.Write("Введите первое число - ");
		double num1 = Convert.ToDouble(Console.ReadLine());

		Console.Write("Введите второе число - ");
		double num2 = Convert.ToDouble(Console.ReadLine());

		Console.Write("Введите одно из перечисленных операций над числами +, -, /, * - ");
		char simbol = Convert.ToChar(Console.ReadLine());

		double ans;

		if (simbol == '+') Console.WriteLine("Ответ -" + (num1 + num2));
		else if (simbol == '-') Console.WriteLine("Ответ -" + (num1 - num2));
		else if (simbol == '*') Console.WriteLine("Ответ -" + (num1 * num2));
		else if (simbol == '/') Console.WriteLine("Ответ -" + (num1 / num2));
		else Console.WriteLine("Ввели что-то не то.");


		Console.Write("\nА теперь давайте определим высокосный ли год, введите год который хотите - ");
		int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("Год высокосный");
        }
        else
        {
            Console.WriteLine("Год не высокосный");
        }

		Console.WriteLine ("Вернусь к задаче 5 и напишу ее через тернарный оператор напиши мне целое число - ");
		int num = Convert.ToInt32(Console.ReadLine());

		string newans = num % 2 == 0 ? "четное" : "нечетное";

        Console.WriteLine(newans);
    }

	public static void DaysDrinksLoginAndPassword()
	{
        Console.Write("Введите номер дня недели чтобы мы поняли что это за день - ");
		int day = Convert.ToInt32(Console.ReadLine());

		switch (day)
		{
			case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторник");
                break;
            case 3:
                Console.WriteLine("Среда");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятница");
                break;
            case 6:
                Console.WriteLine("Суббота");
                break;
            case 7:
                Console.WriteLine("Воскресенье");
                break;
			default:
                Console.WriteLine("Вы ввели не номер дня недели");
				break;
        }

		Console.WriteLine("Вижу вы хотите выпиить у нас есть 1 - кофе, 2 - чай, 3 - сок, 4 - коктейль\n");
		int numDrinks = Convert.ToInt32(Console.ReadLine());

		switch (numDrinks)
		{
            case 1:
                Console.WriteLine("Вы выбрали кофе - его стоимость 250 рублей");
                break;
            case 2:
                Console.WriteLine("Вы выбрали чай - его стоимость 350 рублей");
                break;
            case 3:
                Console.WriteLine("Вы выбрали сок - его стоимость 450 рублей");
                break;
            case 4:
                Console.WriteLine("Вы выбрали коктейль - его стоимость 550 рублей");
                break;
			default:
                Console.WriteLine("Сожалееем такого напитка нет в меню!");
                break;

        }

		Console.WriteLine("Введите пароль и логин для входа в систему лояльности отеля");
        Console.Write("\nЛогин: ");
		string loginPers = Console.ReadLine();
        Console.Write("Пароль: ");
        string passwordPers = Console.ReadLine();

		const string login = "HelloWorld";
		const string password = "1";

		if (loginPers == login && passwordPers == password)
		{
            Console.Write("Спасибо что выбрали нас - Доступ разрешен!");
        }
		else Console.Write("Ошибка - Доступ заблокирован!\n");

    }

	public static void StringTextDaysWorkAgeCategory ()
	{
		Console.WriteLine("Введите 2 имени и мы проверим их на совпадение");
        Console.Write("\nВведите 1 имя");
        string name1 = Console.ReadLine();

        Console.Write("\nВведите 2 имя");
        string name2 = Console.ReadLine();

		if (name1.ToLower() == name2.ToLower())
		{
			Console.WriteLine("браво имена одинаковые");
		}
        else Console.WriteLine("имена разные");

		if (name1.Equals(name2, StringComparison.OrdinalIgnoreCase)) // сложное какое-то для новичка.
		{
            Console.WriteLine("браво имена одинаковые");
        }
		else Console.WriteLine("имена разные");


		Console.WriteLine("Введите теперь свой возраст");
		int age = Convert.ToInt32(Console.ReadLine());

		if (age > 0 && age <= 12) Console.WriteLine("Вы подросток");
        else if (age >= 18 && age <= 59) Console.WriteLine("Вы взрослый");
        else if (age > 59) Console.WriteLine("Вы состарились");


        Console.WriteLine("Введите номер дня недели - ");
		int day = Convert.ToInt32(Console.ReadLine());

		if (day <= 5 && day > 0) Console.WriteLine("Рабочий день");
		else if (day > 5 && day <= 7) Console.WriteLine("Не рабочий день");
		else Console.WriteLine("Чет вы не то ввели");

    }

	public static void TriangleEstimationQuadraticEquation()
	{
		Console.WriteLine("Введите стороны треугольника для того чтобы понять существует ли треугольник");
		Console.WriteLine("Первая сторона");
		double Aside = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Вторая сторона");
		double Bside = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Стретья сторона");
		double Cside = Convert.ToInt32(Console.ReadLine());

		if (Aside + Bside > Cside && Bside + Cside > Aside && Aside + Cside > Bside) Console.WriteLine("Треугольник существует");
		else Console.WriteLine("Треугольник не существует");

		Console.WriteLine("Давайте найдем решение квадратного уравнения");

		Console.WriteLine("Введите число a - ");
		double a = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Введите число b - ");
		double b = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Введите число c - ");
		double c = Convert.ToInt32(Console.ReadLine());

		double dis = Math.Pow(b, 2) - 4.0 * a * c;


		Console.WriteLine("Дискременант равен - " + dis);

		if (dis > 0) Console.WriteLine("два корня");
		else if (dis < 0) Console.WriteLine("нет корней");
		else Console.WriteLine("один корень");

		Console.WriteLine("Введите число баллов для оценки от 0 до 100 - ");
		int score = Convert.ToInt32(Console.ReadLine());

		if (score >= 0 && score <= 20) Console.WriteLine("F");
		else if (score <= 40) Console.WriteLine("D");
		else if (score <= 60) Console.WriteLine("C");
		else if (score <= 80) Console.WriteLine("B");
		else if (score <= 100) Console.WriteLine("A");
		else Console.WriteLine("Такого значения не существуюет");

    }

	public static void HoursLoginPasswordSwitchFalling()
	{
		Console.Write("Введите логин: ");
		string loginPerson = Console.ReadLine();
		const string login = "LOOP";

		if (login == loginPerson)
		{
            const string password = "Pass";
            Console.Write("Введите пароль:");
			string passwordPerson = Console.ReadLine();
			if (password == passwordPerson)
			{
                Console.WriteLine("Доступ открыт.");
                Console.WriteLine("Теперь вы можете посмотреть по формату 24 часа, какая сейчас часть дня.");

				Console.Write("\nВведите число от 0 до 23 чтобы узнать какая сейчас часть дня - ");
				int time = Convert.ToInt32(Console.ReadLine());

                if (time >= 5 && time <= 11) 
                {
                    Console.WriteLine("Сейчас утро");
                }
                else if (time >= 12 && time <= 17) 
                {
                    Console.WriteLine("Сейчас день");
                }
                else if (time >= 18 && time <= 23) 
                {
                    Console.WriteLine("Сейчас вечер");
                }
                else if (time >= 0 && time <= 4)
                {
                    Console.WriteLine("Сейчас ночь");
                }
                else 
                {
                    Console.WriteLine("Неверное время");
                }

            }
			else Console.WriteLine("Доступ запрещен.");

        }
		else Console.WriteLine("Доступ запрещен.");


		Console.WriteLine("Введите число от 1 до 7");
		int days = Convert.ToInt32(Console.ReadLine());

		switch (days)
		{
			case 1:
			case 2:
			case 3:
            case 4:
            case 5:
				Console.WriteLine("Это рабочий день.");
                break;
			default:
				Console.WriteLine("Что то не то записали.");
				break;
        }
    }

	public static void SimbolsMaxBalanceGroupSwich()
	{
		int value1 = 10000;
		int value2 = 200;
        int value3 = 3500;
		int ans = Math.Max(value1, value2);
		ans = Math.Max(ans, value3);

		double balance = 123342.32;

        Console.WriteLine("Снимите деньгу");
		int sum = Convert.ToInt32(Console.ReadLine());

		if (sum > 0 && sum <= balance && sum % 100 == 0)
		{
			balance -= sum;
			Console.WriteLine("Вы сняли - " + sum + " Ваш баланс - " + balance);
		}
		else
		{
            Console.WriteLine("Не хватает средств или что-то пошло не так");
        }

			Console.WriteLine("Введите символ или одно число от 1 до 9.");
		char symbol = Convert.ToChar(Console.ReadLine());

		if (char.IsDigit(symbol))
		{
			Console.WriteLine("Это число");

        }
		else if (char.IsLetter(symbol))
		{
            Console.WriteLine("Это символ");
        }
		else Console.WriteLine("Что то не то");


    }

	public static void Coffee2NullVowelOrAConsonantTaxCalculate()
	{
		Console.WriteLine("Введите напиток который хотите выпить 1 - сок, 2 - кофе, 3 - коктейль.");
		int drinks = Convert.ToInt32(Console.ReadLine);
		switch (drinks)
		{
			case 1:
				Console.WriteLine("Вы выбрали сок, с каким вкусом желаете? 1 - апельсин, 2 - манго, 3 - банан.");
				int taste1 = Convert.ToInt32(Console.ReadLine());
				switch (taste1)
				{
					case 1:
						Console.WriteLine("Ваш напиток, сок апельсиновый");
						break;
					case 2:
						Console.WriteLine("Ваш напиток, сок из манго");
						break;
					case 3:
						Console.WriteLine("Ваш напиток, сок банановый");
						break;
					default:
						Console.WriteLine("Такого вкуса сока нет в меню");
						break;
				}
				break;
			case 2:
				Console.WriteLine("Вы выбрали кофе, какой желаете? 1 - эспрессо, 2 - капучино, 3 - фрапучино.");
				int taste2 = Convert.ToInt32(Console.ReadLine());
				switch (taste2)
				{
					case 1:
						Console.WriteLine("Ваш напиток, кофе эспрессо");
						break;
					case 2:
						Console.WriteLine("Ваш напиток, кофе купучино");
						break;
					case 3:
						Console.WriteLine("Ваш напиток, кофе фрапучино");
						break;
					default:
						Console.WriteLine("Такого кофе нет в меню");
						break;
				}
				break;
			case 3:
				Console.WriteLine("Вы выбрали коктейль, какой желаете? 1 - пинчер-розе, 2 - золотой апельсин, 3 - пина-колада.");
				int taste3 = Convert.ToInt32(Console.ReadLine());
				switch (taste3)
				{
					case 1:
						Console.WriteLine("Ваш напиток, коктейль пинчер розе");
						break;
					case 2:
						Console.WriteLine("Ваш напиток, коктейль золотой апельсин");
						break;
					case 3:
						Console.WriteLine("Ваш напиток, коктейль пина-колада");
						break;
					default:
						Console.WriteLine("Такого коктейля нет в меню");
						break;
				}
				break;

			default:
				Console.WriteLine("Такого напитка нет в меню");
				break;
        }

		Console.WriteLine("Введите ничего или же что-то");
        string nullOrEmpty = Console.ReadLine();

		if (string.IsNullOrEmpty(nullOrEmpty))
		{
            Console.WriteLine("Вы ввели ничего");
        }
		else Console.WriteLine("Вы что-то ввели");

		Console.WriteLine("Введите одну букву, а мы скажем глассная она или согласня");
		string letter = Console.ReadLine();

		switch (letter.ToUpper())
		{
			case "A": //гласные через проваливание
            case "E":
            case "I":
            case "O":
            case "U":
				Console.WriteLine("Ваша буква гласная");
				break;

            case "B": //согласные через проваливание
            case "C":
            case "D":
            case "F":
            case "G":
            case "H":
            case "J":
            case "K":
            case "L":
            case "N":
            case "M":
            case "P":
            case "Q":
            case "R":
            case "S":
            case "T":
            case "V":
            case "W":
            case "X":
            case "Y":
            case "Z":
                Console.WriteLine("Ваша буква согласная");
				break;


			default:
				Console.WriteLine("Вы ввели что-то не то");
				break;
        }

        Console.Write("Введите ваш доход - ");
        double cash = Convert.ToDouble(Console.ReadLine());

        if (cash <= 0)
        {
            Console.WriteLine("Доход должен быть положительным.");
        }
        else if (cash <= 10000) 
        {
            
            Console.WriteLine("Налог 5%");
        }
        else if (cash <= 50000) 
        {
            
            Console.WriteLine("Налог 10%");
        }
        else 
        {
            
            Console.WriteLine("Налог 15%");
        }
    }
	public static void ForSumNumberDoWhile()
	{
		Console.WriteLine("Выводим все числа которые делятся на 5 без остатка, ограничение до 100");
		for (int i = 1; i < 100; i++)
		{
			if (i % 5 == 0)
			{
				Console.Write(i + " ");
			}
		}

		int sum = 0;

		Console.WriteLine("\nВывод суммы все чисел от 1 до 50");
		for (int k = 1; k <= 50; k++)
		{
			sum += k;
		}
		Console.WriteLine("Сумма - " + sum);

		Console.WriteLine("Вводи число а мы его суммируем");
		int value;
		bool condition = true;
        int summator = 0;


		while (condition)
		{
			Console.Write("Вводи число - ");
			value = Convert.ToInt32(Console.ReadLine());

			if (value == 0)
			{
				Console.WriteLine("Подсчет закончен ваше число - " + summator);
				condition = false;
			}
			else
			{
				summator += value;
				Console.WriteLine("Добавили число - " + value);
			}
		}

		while (true)
		{
            Console.Write("Вводи число - ");
            value = Convert.ToInt32(Console.ReadLine());

            if (value == 0)
			{
				break;
			}
			else
			{
                summator += value;
                Console.WriteLine("Добавили число - " + value);
            }
		}
		
		Console.WriteLine("Поиграем в угадайку");
		Random rnd = new Random();
		int numberSecret = rnd.Next(1, 100);
		int number = 0;

		while (true)
		{
            Console.Write("Вводи число - ");
			number = Convert.ToInt32(Console.ReadLine());

			if (number > numberSecret)
			{
                Console.WriteLine("Меньше");
            }
			else if (number < numberSecret)
			{
                Console.WriteLine("Больше");
            }
			else
			{
                Console.WriteLine("Угадал! Это число - " + numberSecret);
				break;
            }
        }

		Console.WriteLine("Будем вводить пароль крутой.");
		const string password = "AcBd31";
		string input;

		while (true)
		{
			Console.Write("Введите пароль - ");
			input = Console.ReadLine();
			if (input == password) 
			{
                Console.WriteLine("Доступ разрешен");
				break;
            }
			else
			{
                Console.WriteLine("Не верный пароль");
            }
		}

		do
		{
            Console.Write("Введите пароль - ");
            input = Console.ReadLine();

            if (input != password)
            {
				Console.WriteLine("Доступ запрещен");
            }
			

        } while (input != password);
        Console.WriteLine("Доступ разрешен");
    }
}
