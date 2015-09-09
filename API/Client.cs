using Microweber.API.Models;
using Newtonsoft.Json;

namespace Microweber.API
{
    public class Client
	{
		public Server Server { get; set; }

        public HTTP HTTP { get; set; }

        public Auth Auth { get; set; }

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

        public object Call(string method)
        {
            string response = this.HTTP.MakeRequest(method);
            return JsonConvert.DeserializeObject(response);
        }

		public Client()
		{
			this.Server = new Server();
            this.HTTP = new HTTP();
            this.Auth = new Auth();
		}
	}
}

