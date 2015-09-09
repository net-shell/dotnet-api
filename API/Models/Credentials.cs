namespace Microweber.API.Models
{
    public class Credentials
    {
        public string Password { get; set; }

        public string Username { get; set; }

        public Credentials(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
