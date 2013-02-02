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

                var x = c["x"].Value<int>();
                var y = c["y"].Value<int>();
                var p = new Pen(Color.Black);
                g.DrawRectangle(p, new Rectangle(x, y, 10, 10));
                string n = c["name"].Value<string>();
                g.DrawString(n, DefaultFont, p.Brush, new PointF(x + 10, y + 10));
                names.Add(n);
            }
            comboBox1.DataSource = names;

            g.Dispose();

        }


    }
}
