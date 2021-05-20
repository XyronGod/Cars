using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
	class Легковая
	{
		public string name;
		public string color;
		public string age;

		public Легковая (string v1, string v2, string v3)
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
			Console.WriteLine(V1 + " : Машина заглушена" + v);
		}
		internal void ValitBokom(string v)
		{
			Console.WriteLine(V1 + " : Машина ValitBokom" + v);
		}
	}

}
