using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
	class Военная : Транспорт
	{
		public Военная(string name, int age, string color, string kuzov) : base(name, kuzov, color, age)
		{

		}

		internal void ValitBokom(string c)
		{
			Console.WriteLine(Name + " : Машина ValitBokom");
		}
		internal void Fire(string c)
		{
			Console.WriteLine(Name + " : Машина стреляет");
		}
		internal void Reload(string c)
		{
			Console.WriteLine(Name + " : Машина перезаряжается");
		}

	}
}
