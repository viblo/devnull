using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Net.Cache;
using System.Net.Security;
using System.Web;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //var x = [{"x":100, "z":200}, ]
            var s = @"{""stars"":[{""x"":""100"",""y"":""100"",""class"":""M4.5V"",""planets"":""8"",""name"":""Ross 614""},{""x"":""80"",""y"":""30"",""class"":""M3.0V"",""planets"":""5"",""name"":""Wolf 1061""},{""x"":""10"",""y"":""160"",""class"":""DZ7"",""planets"":""8"",""name"":""Van Maanen's star""},{""x"":""140"",""y"":""170"",""class"":""M3.0V"",""planets"":""12"",""name"":""Gliese 1""},{""x"":""142"",""y"":""77"",""class"":""M4.5V"",""planets"":""6"",""name"":""TZ Arietis""},{""x"":""80"",""y"":""120"",""class"":""M3.0V"",""planets"":""3"",""name"":""Gliese 687""},{""x"":""180"",""y"":""28"",""class"":""M4.5V"",""planets"":""4"",""name"":""Gliese 876""},{""x"":""42"",""y"":""180"",""class"":""M2.0V"",""planets"":""5"",""name"":""Lalande 21185""},{""x"":""50"",""y"":""60"",""class"":""K2V"",""planets"":""10"",""name"":""Epsilon Eridani""},{""x"":""170"",""y"":""166"",""class"":""M4.5V"",""planets"":""8"",""name"":""Kapteyn's star""},{""x"":""70"",""y"":""190"",""class"":""M0.0V"",""planets"":""1"",""name"":""Lacaille 8760""}]}";

            JObject rss = JObject.Parse(s);

            var ab = rss["stars"].Children();

            var g = this.CreateGraphics();

            var names = new List<string>();

            foreach (var c in rss["stars"])
            {

                var x = c["x"].Value<int>() * 2;
                var y = c["y"].Value<int>() * 2;
                var p = new Pen(Color.Black);
                g.DrawRectangle(p, new Rectangle(x, y, 10, 10));
                string n = c["name"].Value<string>();
                g.DrawString(n, DefaultFont, p.Brush, new PointF(x + 10, y + 10));
                names.Add(n);
            }
            comboBox1.DataSource = names;

            g.Dispose();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var g = this.CreateGraphics();

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var rss = ApiWrapper.GetData("ship&arg=show");

            var x = rss["unix"].Value<int>()*2;
            var y = rss["uniy"].Value<int>()*2;

            var g = this.CreateGraphics();

            var p = new Pen(Color.Red);
            g.DrawArc(p, new Rectangle(x, y, 10, 10), 0f, 360);

            g.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var t = comboBox1.SelectedValue.ToString();
            var enc = HttpUtility.UrlPathEncode(t);

            var s = "ship&arg=setunidest&arg2=" +enc;
            var r = ApiWrapper.GetData(s);
        }


    }


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
