using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
	class СпортКар
	{
		public string name;
		public string color;
		public string age;

		public СпортКар(string v1, string v2, string v3)
		{
			V1 = v1;
			V2 = v1;
			V3 = v1;
		}
		public string V1 { get; }
		public string V2 { get; }
		public string V3 { get; }

		internal void On(string v)
		{
			Console.WriteLine(V1 + " : Машина заведена" + v);
		}
		internal void Off(string v)
		{
			Console.WriteLine(V1 + " : Машина выключена" + v);
		}
		internal void KillallPeople(string v)
		{
			Console.WriteLine(V1 + " : Машина убивает всех людей" + v);
		}
		internal void Fire(string v)
		{
			Console.WriteLine(V1 + " : Машина стреляет" + v);
		}
		internal void Reload(string v)
		{
			Console.WriteLine(V1 + " : Машина перезаряжается" + v);
		}
	}
}
