using System;
using Microweber.API.Models;

namespace Microweber.API
{
	public class REST
	{
		public Server Server { get; set; }

		public REST ()
		{
			this.Server = new Server();
		}
	}
}

