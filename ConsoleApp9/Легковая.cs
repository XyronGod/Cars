using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
	class Легковая : Транспорт
	{

		public Легковая(string name, int age, string color, string kuzov) : base(name, kuzov, color, age)
		{

		}
		internal void ValitBokom(string a)
		{
			Console.WriteLine(Name + " : Машина ValitBokom");
		}
	}

}
