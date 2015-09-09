using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;

namespace Microweber.API
{
	public class HTTP
	{
        public HTTP()
		{
		}

        private UriBuilder makeUriBuilder()
        {
            return new UriBuilder(Client.Instance.Server.Host);
        }

        private Uri makeApiUri(string url)
        {
            UriBuilder builder = this.makeUriBuilder();
            builder.Path += "api/" + url;
            return builder.Uri;
        }

        public string GetQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + Uri.EscapeUriString(p.GetValue(obj, null).ToString());

            return String.Join("&", properties.ToArray());
        }


        public string MakeRequest(string url, string method = "GET", string postData = null)
		{
            try
            {
                Uri uri = makeApiUri(url);
                WebRequest request = WebRequest.Create(uri);

                if (method != "GET")
                {
                    request.Method = method;

                    if (postData.Length > 0)
                    {
                        byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                        request.ContentType = "application/x-www-form-urlencoded";
                        request.ContentLength = byteArray.Length;

                        using (Stream dataStream = request.GetRequestStream())
                        {
                            dataStream.Write(byteArray, 0, byteArray.Length);
                        }
                    }
                }

                using (WebResponse response = request.GetResponse())
                {
                    Console.WriteLine(String.Format(" > {0}\t{1} {2}", uri.ToString(), (int)((HttpWebResponse)response).StatusCode, ((HttpWebResponse)response).StatusDescription));
                    Stream dataStream = response.GetResponseStream();
                    using (StreamReader reader = new StreamReader(dataStream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
            catch { }

            return null;
		}
	}
}

