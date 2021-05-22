using System;

namespace ConsoleApp9
{
	class Program
	{
		static void Main(string[] args)
		{
			Легковая a = new Легковая("Reno Sandero Stepway", 5, "Red", "Купе");
			Грузовая b = new Грузовая("KAMAZ", 6, "Blue", "Деда");
			Военная c = new Военная("T-62a", 14, "Green", "Шишига");
			ЧеловекМашина d = new ЧеловекМашина("T1000", 4, "Black", "Терминатор");
			СпортКар e = new СпортКар("Viper", 5, "White", "спорт");
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

			e.On("");
			e.Razgon("");
			e.Fire("");
			e.Reload("");
			e.Off("");
		}
	}
}
