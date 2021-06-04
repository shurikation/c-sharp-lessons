using System;
using System.Globalization; //Просторанство имён
/**
 * #6 - Конвертация строки в число
 */

namespace Lessons
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			string str;
			int a, b;
			Console.WriteLine("Enter number 1");
			str = Console.ReadLine();
			a = Convert.ToInt32(str);
			Console.WriteLine("Enter number 2");
			str = Console.ReadLine();
			b = Convert.ToInt32(str);
			int result = a + b;
			Console.WriteLine("Сумма чисел = " + result);
			*/

			string str2 = "1.9";
		

			//Подключаем выше using System.Globalization;
			//Создаем экземпляр класса NumberFormatInfo
			NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
			{
				NumberDecimalSeparator = ".", //указываем разделитель
			};

			double a = Convert.ToDouble(str2, numberFormatInfo);
			Console.WriteLine(a);
		}
	}
}

/*
 * Конвертация строки в число происходит с помощью Convert.
 * Но мето не всегдла может конвертнуть в double строку с точкой: 1.9
 * Ему нужна 1,9 - с запятой
 * Могут быть разыне настрйоки в заивсимости от региона, метод не всегда работает
 * 
 * */

