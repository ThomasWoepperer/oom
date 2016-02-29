using System;

namespace Task3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var fahrzeuge = new IAusgabe[]
			{
				new Auto(10000, "schwarz", true, "BMW"),
				new Auto(30000, "rot", true, "Audi"),
				new Auto("silber","Mercedes"),
				new Auto("gelb", "Ferrari"),
				new Motorrad(8000, "Mazda", "grün"),
				new Motorrad(30000, "Lamborghini", "gelb"),
				new Motorrad("Ferrari", "rot"),
				new Motorrad("Mitsubishi", "grün"),
			};


			foreach (var x in fahrzeuge)
			{
				x.printProperties ();
			}
		}
	}
}
