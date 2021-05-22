using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
	class СпортКар : Транспорт
	{
		public СпортКар(string name, int age, string color, string kuzov): base (name, kuzov, color, age)
		{
		}


		internal void Razgon(string e)
		{
			Console.WriteLine(Name + " : Машина делает razgon");
		}
		internal void Fire(string e)
		{
			Console.WriteLine(Name + " : Машина стреляет");
		}
		internal void Reload(string e)
		{
			Console.WriteLine(Name + " : Машина перезаряжается");
		}
	}
}
