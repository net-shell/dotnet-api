using System;

namespace Microweber.Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Microweber.API.Client api = Microweber.API.Client.Instance;
			api.Server.Host = "http://nypub.microweber.com";
			Console.WriteLine (api.Call("is_logged"));
            Console.ReadKey();
		}
	}
}
