using System;

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
}
