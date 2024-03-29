using System;
using Nancy.Hosting.Self;

namespace ConsoleLauncher
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var url = "http://localhost:8080";
			var host = new NancyHost(new Uri(url));
			host.Start();
			Console.WriteLine ("Server now running on: " + url);
			Console.ReadLine ();
			host.Stop();
		}
	}
}
