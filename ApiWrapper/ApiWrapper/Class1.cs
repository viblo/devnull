using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ApiWrapper
{
    public class ApiWrapper
    {
        static string addr = "https://lostinspace.lanemarknad.se:8000/api2";
        private static int port = 8000;
        private static string apiKey = "7bcd9893-bb21-464f-b4a7-48a8a8663334";
        private static string session = "3af98f60-0a24-4867-a889-71c1b878eab1";


        public static JObject GetData(string command, Dictionary<string, string> vars = null)
        {
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ValidateRemoteCertificate);

            string uriString = addr;

            uriString += "/?session=" + session;
            if (vars != null)
                foreach (KeyValuePair<string, string> kvp in vars)
                {
                    uriString += "&" + kvp.Key + "=" + kvp.Value;
                }

            uriString += "&command=" + command;

            Uri uri = new Uri(uriString);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            //request.CookieContainer.Add(uri, new Cookie("devnull_apikey", apiKey));
            //request.CookieContainer.Add(uri, new Cookie("devnull_session", session));



            var response = request.GetResponse();

            Stream resStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(resStream);
            return JObject.Parse(reader.ReadToEnd());
        }

        private static bool ValidateRemoteCertificate(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
