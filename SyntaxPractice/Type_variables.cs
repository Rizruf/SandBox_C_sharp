using Microsoft.VisualBasic;
using System;
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


}
