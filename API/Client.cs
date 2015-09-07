using System;
using Microweber.API.Models;

namespace Microweber.API
{
	public class Client
	{
		public Server Server { get; set; }

        public HTTP HTTP { get; set; }

        private static Client instance;

        public static Client Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Client();
                }
                return instance;
            }
        }

        public bool Call(string method)
        {
            return this.HTTP.MakeRequest(method);
        }

		public Client()
		{
			this.Server = new Server();
            this.HTTP = new HTTP();
		}
	}
}

