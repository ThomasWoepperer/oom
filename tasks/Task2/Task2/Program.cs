using System;

namespace Task2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Auto roterBMW = new Auto ("rot", "BMW");
			roterBMW.printProperties();
			Auto Audi1 = new Auto (10000, "schwarz", true, "Audi"); 
			Audi1.printProperties();
			roterBMW.updateprice();
			roterBMW.printProperties();
			Audi1.lackieren();
			Audi1.printProperties();
		}
	}
}
