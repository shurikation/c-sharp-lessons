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
			//Еще один способ конвертации
			//Parse заточен именно на работу со строками, в отличие от общего Convert
			string str = "5";
			int a = int.Parse(str);

			//Для числа с плавающей точкой
			string str2 = "5.9";
			double a = double.Parse(str2);

			//Может быть как с точкой, так и с запятой в заивисмоти о региональных настроек
			NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
			{
				NumberDecimalSeparator = " . ",
			};
			double b = double.Parse(str2, numberFormatInfo);

			//Если в строку приходит какая-то фигня
			string str3 = "5.9выыфвыфв";
			double с = double.Parse(str3); //получим ошибку
			int d = Convert.ToInt32(str3); //...и тут получаем ошибку

			//Можно использовать try catch
			try
			{
				int f = Convert.ToInt32(str3);
			}
			catch(Exception)
			{
				Console.WriteLine("Its fuckin convertation error!");
			}

			//Или tryparse - который не бросает исключения в случае ошибки в отличие от parse or convert
			int a2;

			int.TryParse(str, out a2); //out - перемеенная будет инициализирована внутри метода и возвращена

			//Если он не сможет распарсить, то в a2 уйдет 0 - значение по умолчанию
			//Поэтому лучше вернуть булевый результат

			bool result = int.TryParse(str, out a2);
			if(result)
			{
				Console.WriteLine("Succeces!");
			}
			else
			{
				Console.WriteLine("Error!");
			}

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

