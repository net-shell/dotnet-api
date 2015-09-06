using System;

namespace Microweber.API.Models
{
	public class Server
	{
		public string Host { get; set; }

		public int Port { get; set; }

		public Server ()
		{
			this.Port = 80;
		}
	}
}

