using System;

namespace Microweber.Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Ready");
            API.Client api = API.Client.Instance;
            api.Auth.Credentials = new API.Models.Credentials("ashmicr1", "M7mw34E5sb");
            api.Server.Host = "http://nypub.microweber.com";
			Console.WriteLine (api.Call("is_logged"));
            Console.ReadKey();
		}
	}
}
