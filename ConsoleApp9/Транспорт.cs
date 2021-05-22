using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
	class Транспорт
	{
		public string Name;
		public string Kuzov;
		public string Color;
		public int Age;

		public Транспорт(string name, string kuzov, string color, int age)
		{
			Name = name;
			Kuzov = kuzov;
			Color = color;
			Age = age;
		}
		internal void On(string a)
		{
			Console.WriteLine(Name + " : Машина заведена");
		}
		internal void Off(string a)
		{
			Console.WriteLine(Name + " : Машина заглушена");
		}
	}
}
