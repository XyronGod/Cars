using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
	class Грузовая : Транспорт
	{

		public Грузовая(string name, int age, string color, string kuzov) : base(name, kuzov, color, age)
		{
		}
		internal void ValitBokom(string b)
		{
			Console.WriteLine(Name + " : Машина ValitBokom");
		}
		internal void PricepOn(string b)
		{
			Console.WriteLine(Name + " : Прицеп Podnimaetsa");
		}
		internal void PricepOff(string b)
		{
			Console.WriteLine(Name + " : Прицеп opuskaetsa");
		}
	}

}
