using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using System.Threading;

namespace Task6
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Run();
		}

		public static void Run()
		{	int numberofruns = 0;
			var ts = new CancellationTokenSource();
			CancellationToken ct = ts.Token;

			var task = Task.Factory.StartNew(() =>
			                                 {


				ct.ThrowIfCancellationRequested();


				while (!ct.IsCancellationRequested)
				{
					numberofruns++;

					Thread.Sleep(100);
				}
			}, ts.Token);

			Console.ReadKey();

			ts.Cancel ();
			Console.WriteLine("\n"+numberofruns+" seconds running");

			string json = "";
			var o = Observable.Start(() =>
			{
			var autotest = new Auto(9999, "blau", true, "Lamborg");
			var autoSubscription = autotest.Subscribe(autotest);
			Console.ReadKey();
			autoSubscription.Dispose();
			}).Finally(() => Console.WriteLine("Main Thread"));






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

			var Autos = new Auto[]
			{
				new Auto(10000, "schwarz", true, "BMWA"),
				new Auto(30000, "rot", true, "Audi"),
				new Auto("silber","Mercedes"),
				new Auto("gelb", "Ferrari")
			};

			foreach (var x in fahrzeuge)
			{
				json = JsonConvert.SerializeObject (x);
				x.printProperties ();
				Console.WriteLine (json);
				Console.WriteLine("");

			}		
			using (StreamWriter file = File.CreateText(@"./Auto.json")) {
				JsonSerializer serializer = new JsonSerializer ();
				List<Auto> autoin = new List<Auto> ();
				foreach (var x in Autos) {

					autoin.Add (x);
				}
				serializer.Serialize(file, autoin);
			}

			List<Auto> auto1 = new List<Auto>();

			using (StreamReader file2 = File.OpenText(@"./Auto.json"))
			{

				JsonSerializer serializer2 = new JsonSerializer();


				//  List<Auto> auto1= new List<Auto>();


				auto1 = (List<Auto>)serializer2.Deserialize(file2, typeof(List<Auto>));


				//auto1.printProperties ();
			}

			foreach (Auto x in auto1) {
				x.printProperties ();
			}
			o.Wait();
		}
	}

}
