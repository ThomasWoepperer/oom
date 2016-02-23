using System;
using System.Linq;

namespace Task2
{
	public class Auto
	{ 
		private decimal Verkaufspreis;
		private string Lackfarbe;
		private bool Allrad;
		private string Automarke;

		public string Marke
		{
			get {
				return Automarke;
			}
		}

		public string Farbe
		{
			get {
				return Lackfarbe;
			}
			set{
				Lackfarbe = value;
			}
		}

		public decimal Preis
		{
			get {
				return Verkaufspreis;
			}
			set {
				if (value < 0)
					throw new Exception ("Der Preis kann nicht negativ sein");
				Verkaufspreis = value;

			}
		}
			
		public bool hatAllrad {
			get {
				return Allrad;
			}
		}



		public Auto (decimal Preis, string Farbe, bool Allrad, string Marke)
		{
			Lackfarbe = Farbe; 
			Verkaufspreis = Preis;
			this.Allrad = Allrad;
			Automarke = Marke;
		}
		public Auto (string Farbe, string Marke)
		{
			Lackfarbe = Farbe;
			Automarke = Marke;
			Verkaufspreis = 0;
			Allrad = false;
		}

		public void lackieren ()
		{
			string[] zLackfarben = new string[] { "schwarz", "rot", "grün", "blau", "weiß", "silber" };
			Console.WriteLine("Zulässige Farben: ");
			foreach(string i in zLackfarben)
			{
				Console.Write ("{0} ", i);
			}
			Console.WriteLine("");


			string newColor = Console.ReadLine();
			newColor.ToLower ();
			foreach(string i  in zLackfarben)
			{
				if(newColor.Contains(i))
				{
					this.Lackfarbe = newColor;
					return;
				}

			}

				Console.WriteLine("Keine gültige Farbe eingegeben.");
		}
		public void updateprice ()
		{
			string price = Console.ReadLine();
			decimal newPrice;
			bool isDecimal = Decimal.TryParse (price, out newPrice);
			if (isDecimal) {
		     

				this.Preis = newPrice;
			} else {
				this.Preis = Preis;
			}

		}

		public void printProperties()
		{
			Console.WriteLine("Verkaufspreis = {0}",this.Preis);
			Console.WriteLine ("Automarke = {0}", this.Marke);
			Console.WriteLine ("Lackfarbe = {0}", this.Farbe);
			Console.WriteLine ("Allrad = {0}", this.Allrad);


		}


	}
}

