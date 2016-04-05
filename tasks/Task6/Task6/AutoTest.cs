using System;
using NUnit.Framework;

namespace Task6
{	
	[TestFixture()]
	public class AutoTest
	{
		[Test()]
		public void CanCreateAutoFullConstructor()
		{
			var x = new Auto(10000, "schwarz", true, "BMW");

			Assert.IsTrue(x.Preis == 10000);
			Assert.IsTrue(x.Farbe == "schwarz");
			Assert.IsTrue(x.hatAllrad == true);
			Assert.IsTrue(x.Marke == "BMW");
		}

		[Test()]
		public void CannotCreateAutowithEmptyColor1()
		{
			Assert.Catch(() =>
			             {
				var x = new Auto(10000, "", true, "BMW");
			});
		}

		[Test()]
		public void CannotCreateAutowithEmptyColor2()
		{
			Assert.Catch(() =>
			             {
				var x = new Auto(10000, null, true, "BMW");
			});
		}

		[Test]
		public void CannotCreateAutowithEmptyMarke1()
		{
			Assert.Catch(() =>
			             {
				var x = new Auto(10000, "schwarz", true, "");
			});
		}

		[Test()]
		public void CannotCreateAutowithEmptyMarke2()
		{
			Assert.Catch(() =>
			             {
				var x = new Auto(10000, "schwarz", true, null);
			});
		}

		[Test()]
		public void CannotCreateAutoWithNegativePrice()
		{
			Assert.Catch(() =>
			             {
				var x = new Auto(-10000, "schwarz", true, "BMW");
			});
		}

		[Test()]
		public void CanCreateAutoShortConstructor()
		{
			var x = new Auto("schwarz", "BMW");

			Assert.IsTrue(x.Farbe == "schwarz");
			Assert.IsTrue(x.Marke == "BMW");
		}

		[Test()]
		public void CannotCreateAutowithEmptyColor1SC()
		{
			Assert.Catch(() =>
			             {
				var x = new Auto("", "BMW");
			});
		}

		[Test()]
		public void CannotCreateAutowithEmptyColor2SC()
		{
			Assert.Catch(() =>
			             {
				var x = new Auto(null, "BMW");
			});
		}

		[Test()]
		public void CannotCreateAutowithEmptyMarke1SC()
		{
			Assert.Catch(() =>
			             {
				var x = new Auto("schwarz", "");
			});
		}

		[Test()]
		public void CannotCreateAutowithEmptyMarke2SC()
		{
			Assert.Catch(() =>
			             {
				var x = new Auto("schwarz", null);
			});
		}


	}
}

