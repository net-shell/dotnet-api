# Microweber.NET

Multi-platform .NET API for interaction with Microweber websites.

This project is currently in development and is not ready for use.

## Example Usage

Simply add a reference to the assembly. The example code is pretty self-explanatory.

```
using System;

namespace MyApplication
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            Microweber.API.Client api = Microweber.API.Client.Instance;
            api.Auth.Credentials = new Microweber.API.Models.Credentials("username", "password");
            api.Server.Host = "http://your-site.microweber.com";
            api.Call("is_logged");
		}
	}
}

```
