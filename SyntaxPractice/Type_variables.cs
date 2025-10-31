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
}
