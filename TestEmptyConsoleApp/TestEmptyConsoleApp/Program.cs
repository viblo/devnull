using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEmptyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = @"{""stars"":[{""x"":""100"",""y"":""100"",""class"":""M4.5V"",""planets"":""8"",""name"":""Ross 614""},{""x"":""80"",""y"":""30"",""class"":""M3.0V"",""planets"":""5"",""name"":""Wolf 1061""},{""x"":""10"",""y"":""160"",""class"":""DZ7"",""planets"":""8"",""name"":""Van Maanen's star""},{""x"":""140"",""y"":""170"",""class"":""M3.0V"",""planets"":""12"",""name"":""Gliese 1""},{""x"":""142"",""y"":""77"",""class"":""M4.5V"",""planets"":""6"",""name"":""TZ Arietis""},{""x"":""80"",""y"":""120"",""class"":""M3.0V"",""planets"":""3"",""name"":""Gliese 687""},{""x"":""180"",""y"":""28"",""class"":""M4.5V"",""planets"":""4"",""name"":""Gliese 876""},{""x"":""42"",""y"":""180"",""class"":""M2.0V"",""planets"":""5"",""name"":""Lalande 21185""},{""x"":""50"",""y"":""60"",""class"":""K2V"",""planets"":""10"",""name"":""Epsilon Eridani""},{""x"":""170"",""y"":""166"",""class"":""M4.5V"",""planets"":""8"",""name"":""Kapteyn's star""},{""x"":""70"",""y"":""190"",""class"":""M0.0V"",""planets"":""1"",""name"":""Lacaille 8760""}]}";
            var jsreader = new JsonTextReader(new StringReader(text));
            var json = (JObject)new JsonSerializer().Deserialize(jsreader);
            var stars = from p in json["stars"]
                 select new
                 {
                     Class = (string)p["class"],
                     Planets = (int)p["planets"],
                     X = (int)p["x"],
                     Y = (int)p["y"],
                 };
        }
    }
}
