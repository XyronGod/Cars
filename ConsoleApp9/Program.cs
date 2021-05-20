using System;

namespace ConsoleApp9
{
	class Program
	{
		static void Main(string[] args)
		{
			Легковая a = new Легковая("Reno Sandero Stepway", "Red", "4");
			Грузовая b = new Грузовая("KAMAZ", "Black angus", "39T");
			Военная c = new Военная("T-62a", "79km", "107K");
			ЧеловекМашина d = new ЧеловекМашина("T1000", "189cm", "250kg");
			a.On("");
			a.ValitBokom("");
			a.Off("");
			Console.WriteLine("");

			b.On("");
			b.ValitBokom("");
			b.PricepOn("");
			b.PricepOff("");
			b.Off("");
			Console.WriteLine("");

			c.On("");
			c.ValitBokom("");
			c.Fire("");
			c.Reload("");
			c.Off("");
			Console.WriteLine("");

			d.On("");
			d.KillallPeople("");
			d.Fire("");
			d.Reload("");
			d.Off("");
			Console.WriteLine("");
		}
	}
}
