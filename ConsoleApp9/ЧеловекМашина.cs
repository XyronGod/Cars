using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
	class ЧеловекМашина : Транспорт
	{
		public ЧеловекМашина(string name, int age, string color, string kuzov) : base(name, kuzov, color, age)
		{
		}


		internal void KillallPeople(string d)
		{
			Console.WriteLine(Name + " : Машина убивает всех людей");
		}
		internal void Fire(string d)
		{
			Console.WriteLine(Name + " : Машина стреляет");
		}
		internal void Reload(string d)
		{
			Console.WriteLine(Name + " : Машина перезаряжается");
		}
	}
}
