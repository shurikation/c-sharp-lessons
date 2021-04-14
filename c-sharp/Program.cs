using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello world!");
			Console.WriteLine("Привет мир!");
		}
	}
}

/*
 * Управляемая куча при выделении памяти
 * Управляется CLR - которая следит за утечкой памяти
 * При компиляции она копилисриуется на CIL с помощью...
 * ...JIT - Just In Time компиляция - пробразовывает асемблерный код в машинный
 *
 *using - подключение пространств имен
 *это блоки кода которые разграничивают классы, код чтобы они не конфликовали
 *белые юзинги испольуются, серые - нет
 *Так, класс Console подключается из пространства имени System
 *Если не подключено System, то придется писать System.Console.WriteLine("Hello world!");
 *
 *
 */