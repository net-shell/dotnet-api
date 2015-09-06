using System;

namespace Microweber.Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Microweber.API.REST api = new Microweber.API.REST();
			api.Server.Host = "http://nypub.microweber.com/";
			Console.WriteLine (api.Server.Host);
		}
	}
}
