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


            LoadInfo();

            LoadUni();
            LoadSystem();

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

           
        }

        void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

     

        private void LoadUni()
        {
            //var x = [{"x":100, "z":200}, ]
            var s = @"{""stars"":[{""x"":""100"",""y"":""100"",""class"":""M4.5V"",""planets"":""8"",""name"":""Ross 614""},{""x"":""80"",""y"":""30"",""class"":""M3.0V"",""planets"":""5"",""name"":""Wolf 1061""},{""x"":""10"",""y"":""160"",""class"":""DZ7"",""planets"":""8"",""name"":""Van Maanen's star""},{""x"":""140"",""y"":""170"",""class"":""M3.0V"",""planets"":""12"",""name"":""Gliese 1""},{""x"":""142"",""y"":""77"",""class"":""M4.5V"",""planets"":""6"",""name"":""TZ Arietis""},{""x"":""80"",""y"":""120"",""class"":""M3.0V"",""planets"":""3"",""name"":""Gliese 687""},{""x"":""180"",""y"":""28"",""class"":""M4.5V"",""planets"":""4"",""name"":""Gliese 876""},{""x"":""42"",""y"":""180"",""class"":""M2.0V"",""planets"":""5"",""name"":""Lalande 21185""},{""x"":""50"",""y"":""60"",""class"":""K2V"",""planets"":""10"",""name"":""Epsilon Eridani""},{""x"":""170"",""y"":""166"",""class"":""M4.5V"",""planets"":""8"",""name"":""Kapteyn's star""},{""x"":""70"",""y"":""190"",""class"":""M0.0V"",""planets"":""1"",""name"":""Lacaille 8760""}]}";

            Universe = JObject.Parse(s);
            var names = new List<string>();

            foreach (var c in Universe["stars"])
            {
                string n = c["name"].Value<string>();
                names.Add(n);
            }
            comboBox1.DataSource = names;

        }

        int hasDrawn = 0;

        JObject ShipData = null;

        private void UpdateShip()
        {
            var rss = ApiWrapper.ApiWrapper.GetData("ship&arg=show");
            if (rss == null)
                return;

            ShipData = rss;
            var x = rss["unix"].Value<int>() * 1.5f;
            var y = rss["uniy"].Value<int>() * 1.5f;

            var g = pbxUni.CreateGraphics();

            var p = new Pen(Color.Red);
            g.DrawArc(p, x, y, 10, 10, 0f, 360);

            g.Dispose();

            var g2 = pbxSystem.CreateGraphics();

            var sx = rss["systemx"].Value<int>() * 1.5f;
            var sy = rss["systemy"].Value<int>() * 1.5f;

            var p2 = new Pen(Color.Red);
            g2.DrawArc(p2, sx, sy, 10, 10, 0f, 360);

            g2.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                var r = ApiWrapper.ApiWrapper.GetData("shortrange")["system"]["name"].Value<string>();

                if (r.ToString() != currentSystem)
                {
                    LoadSystem();
                    currentSystem = r.ToString();
                }



            }
            catch { }
            UpdateShip();
        }

        Dictionary<string, JObject> PlanetInfo = new Dictionary<string, JObject>();

        string currentSystem = "";

        List<string> currentPlanetNames = new List<string>();
        string currentPlanetTarget = "";
        Dictionary<string, Dictionary<string, JObject>> PlanetInfoAdv = new Dictionary<string, Dictionary<string, JObject>>();


        private void LoadSystem()
        {
            currentPlanetNames = new List<string>();
            ShortRange = ApiWrapper.ApiWrapper.GetData("shortrange");
            var r = ShortRange;
            try
            {
                currentSystem = r["system"]["name"].Value<string>();
                foreach (var c in r["system"]["planetarray"])
                {
                    string n = c["planet_no"].Value<string>();
                    currentPlanetNames.Add(n);
                    PlanetInfo[n] = (JObject)c;
                }
                var l = new List<string>(currentPlanetNames);
                l.Add("edge");
                comboBox2.DataSource = l;
            }
            catch { }
        }

        private void BuildPlanetGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var kvp in PlanetInfoAdv)
            {
                foreach (var kvp2 in kvp.Value)
                {
                    var planetData = kvp2.Value["object_data"];

                    var anomalies = planetData["anomalies"] == null ? "" : planetData["anomalies"].ToString();

                    string[] data = new string[] {
                        planetData["planet_no"].Value<string>(),
                        kvp.Key,
                        planetData["core_radius"].Value<string>(),
                        planetData["surf_grav"].Value<string>().Trim(),
                        anomalies,
                        planetData["type"].Value<string>() };
                    dataGridView1.Rows.Add(data);


                }
            }

        }

        private void GotoPlanet(string planetName)
        {
            if (planetName == currentPlanetTarget)
                return;

            var enc = HttpUtility.UrlPathEncode(planetName);

            var s = "ship&arg=setsystemdest&arg2=" + enc;
            var r = ApiWrapper.ApiWrapper.GetData(s);
            if (r["systemdest"] != null)
            {
                currentPlanetTarget = planetName;
                txtLog.AppendText("Traveling to " + planetName + "\n");
            }
        }


        private void ScanPlanet()
        {
            var planetInfo = ApiWrapper.ApiWrapper.GetData("object");

            try
            {

                if (!PlanetInfoAdv.ContainsKey(currentSystem))
                {
                    PlanetInfoAdv[currentSystem] = new Dictionary<string, JObject>();
                }
                var planetName = planetInfo["object_data"]["planet_no"].Value<string>();

                if (PlanetInfoAdv[currentSystem].ContainsKey(planetName))
                    return;
                PlanetInfoAdv[currentSystem][planetName] = planetInfo;
                txtLog.AppendText(planetInfo.ToString());

                ApiWrapper.SimpleDatabase.AddToDatabase(new KeyValuePair<string, object>("PlanetInfoAdv", PlanetInfoAdv));
                cbxPlanetInfo.DataSource = PlanetInfoAdv[currentSystem].Keys.ToList();
            }
            catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ScanPlanet();
        }

        private void LoadInfo()
        {
            try
            {
                var o = ApiWrapper.SimpleDatabase.GetFromDatabase("PlanetInfoAdv");
                var jo = o as JObject;
                var r = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, JObject>>>(jo.ToString());
                PlanetInfoAdv = r;
                cbxPlanetInfo.DataSource = PlanetInfoAdv.Keys.ToList();
            }
            catch
            {
            }
        }

        private void tmrAutoPilot_Tick(object sender, EventArgs e)
        {
            if (!chkAutoPilot.Checked)
                return;

            // get list of all planets in system not scanned

            var shipx = ShipData["systemx"].Value<int>();
            var shipy = ShipData["systemy"].Value<int>();

            var l = currentPlanetNames.Where(n => !PlanetInfoAdv.ContainsKey(currentSystem) ||
                !PlanetInfoAdv[currentSystem].ContainsKey(n));

            l = l.OrderBy(n =>
                {
                    var dx = PlanetInfo[n]["x"].Value<int>() - shipx;
                    var dy = PlanetInfo[n]["y"].Value<int>() - shipy;
                    return Math.Pow(Math.Abs(dx) + Math.Abs(dy), 2);
                });

            if (!l.Any())
            {
                txtLog.AppendText("Scanning of system done!");
                chkAutoPilot.Checked = false;
                GotoPlanet("edge");
                return;
            }

            // set destination to closest planet
            GotoPlanet(l.First());

            // if on plannet set to scanned
            ScanPlanet();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            BuildPlanetGrid();
        }

        private void btnFtl_Click(object sender, EventArgs e)
        {
            GotoPlanet("edge");
            var t = comboBox1.SelectedValue.ToString();
            var enc = HttpUtility.UrlPathEncode(t);

            var s = "ship&arg=setunidest&arg2=" + enc;
            var r = ApiWrapper.ApiWrapper.GetData(s);
        }

        private void btnStarInfo_Click(object sender, EventArgs e)
        {
            var selectedPlanet = comboBox2.SelectedValue.ToString();

            try
            {
                txtLog.AppendText(PlanetInfo[selectedPlanet].ToString());
            }
            catch { }
        }

        private void cbxPlanetInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var planet_no = cbxPlanetInfo.SelectedValue.ToString();
                txtPlanetInfo.Clear();

                if (PlanetInfoAdv[currentSystem].ContainsKey(planet_no))
                {
                    txtPlanetInfo.Text = PlanetInfoAdv[currentSystem][planet_no].ToString();
                }
            }
            catch
            {

            }
        }

        private void btnSystemTravel_Click(object sender, EventArgs e)
        {
            var t = comboBox2.SelectedValue.ToString();
            GotoPlanet(t);
        }

        private void btnRefreshDrone_Click(object sender, EventArgs e)
        {
            if (ShipData == null)
                return;

            dataGridView2.Rows.Clear();

            foreach (var drone in ShipData["drones"])
            {

                string[] s = new string[]{
                    drone["droneid"].ToString(),
                    drone["name"].ToString(),
                    drone["map"].ToString()
                };
                dataGridView2.Rows.Add(s);
            }

            AllDroneScan(true);


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeployDrone_Click(object sender, EventArgs e)
        {
            try
            {
                string droneId = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                var anomaly = cbxAnomalies.SelectedValue.ToString();

                var d = new Dictionary<string, string>();
                d["arg"] = "enteranomaly";
                d["arg2"] = anomaly;
                d["arg3"] = droneId;

                var r = ApiWrapper.ApiWrapper.GetData("ship", d);


                //"ship&arg=enteranomaly&arg2=" + anomaly + "&arg3=" + droneId);
                txtLog.AppendText("Drone deployed: " + r.ToString());

                dataGridView2.SelectedRows[0].Cells[2].Value = anomaly;
                AllDroneScan();

                //var r = ApiWrapper.ApiWrapper.GetData("drone&arg=" + droneId + "&arg2=scan");
            }
            catch { }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadSystem();
                cbxAnomalies.DataSource = null;
                if (ShipData["currentplanet"] == null)
                    return;


                var anoms = PlanetInfoAdv[currentSystem][ShipData["currentplanet"].ToString()]["object_data"]["anomalies"];

                if (anoms == null)
                    return;
                var l = new List<string>();
                foreach (var an in anoms)
                {
                    l.Add(an.ToString());
                }
                cbxAnomalies.DataSource = l;
            }
            catch { }
        }

        private void btnPlanetInfo_Click(object sender, EventArgs e)
        {
            ScanPlanet();
        }

        private JObject Universe = null;

        private void pbxUni_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            foreach (var c in Universe["stars"])
            {

                var x = c["x"].Value<int>() * 1.5f;
                var y = c["y"].Value<int>() * 1.5f;
                var p = new Pen(Color.Black);
                e.Graphics.DrawRectangle(p, x, y, 10, 10);
                string n = c["name"].Value<string>();
                e.Graphics.DrawString(n, DefaultFont, p.Brush, new PointF(x + 10, y + 10));
            }
        }

        Dictionary<string, PointF> DronePosition = new Dictionary<string, PointF>();

        struct ColorData
        {
            public Brush Brush;
            public string Name;
            public ColorData(Brush brush, string name)
            {
                Brush = brush;
                Name = name;
            }
        }

        private Dictionary<int, ColorData> ColorMapping = new Dictionary<int, ColorData>()
        {
            
            { 0x00000000, new ColorData(Brushes.DarkGray, "Blocked") },
            { 0x00000001, new ColorData(Brushes.Gray, "Blocked") },
            { 0x00000010, new ColorData(Brushes.LightGray, "Blocked") },


            { 0x00010000, new ColorData(Brushes.LightBlue, "Door") },
            { 0x00020000, new ColorData(Brushes.Blue, "Door") },
            { 0x00040000, new ColorData(Brushes.Maroon, "Door") },
            { 0x00080000, new ColorData(Brushes.DarkBlue, "Door") },
            { 0x00100000, new ColorData(Brushes.CornflowerBlue, "Door") },
            { 0x00200000, new ColorData(Brushes.CadetBlue, "Door") },
            { 0x00800000, new ColorData(Brushes.LightYellow, "Opening up") },
            { 0x00400000, new ColorData(Brushes.Yellow, "Opening down") },
            { 0x0000FFC0, new ColorData(Brushes.Pink, "Room id") },

        };


       
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.Clear(Color.White);

                List<int> colorValues = new List<int>();

                var anomaly = cbxAnomalies.SelectedItem;
                if (anomaly == null)
                    return;
                if (!ScanData.ContainsKey(anomaly.ToString()))
                    return;

                foreach (var kvp in ScanData[anomaly.ToString()])
                {
                    Brush brush = Brushes.Green;
                    if (ColorMapping.ContainsKey(kvp.Value))
                        brush = ColorMapping[kvp.Value].Brush;

                    //    if (brush == Brushes.Green)
                    //      txtLog.AppendText("Just treated " + kvp.Value.ToString("X") + " as green.");

                    e.Graphics.FillRectangle(brush, kvp.Key.X * zoom, kvp.Key.Y * zoom, zoom, zoom);

                }

                foreach (var point in LandingZones)
                    e.Graphics.FillRectangle(Brushes.Green, point.X * zoom, point.Y * zoom, zoom, zoom);

                foreach (var kvp in DronePosition)
                {

                    if (dataGridView2.SelectedRows.Count > 0 && dataGridView2.SelectedRows[0].Cells[0].Value != null && dataGridView2.SelectedRows[0].Cells[0].Value.ToString() == kvp.Key)
                        e.Graphics.FillRectangle(Brushes.Red, kvp.Value.X * zoom, kvp.Value.Y * zoom, zoom, zoom);
                    else
                        e.Graphics.DrawRectangle(Pens.Red, kvp.Value.X * zoom, kvp.Value.Y * zoom, zoom, zoom);

                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText("Exception painting: " + ex);
                    
            }
            

        }

        JObject ShortRange = null;

        private void pbxSystem_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);
            g.DrawRectangle(new Pen(Color.Yellow), new Rectangle(150, 150, 10, 10));

            var r = ShortRange;
            try
            {
                currentSystem = r["system"]["name"].Value<string>();
                foreach (var c in r["system"]["planetarray"])
                {
                    var x = c["x"].Value<int>() * 1.5f;
                    var y = c["y"].Value<int>() * 1.5f;
                    var p = new Pen(Color.Black);
                    g.DrawRectangle(p, x, y, 10, 10);
                    string n = c["planet_no"].Value<string>();
                    g.DrawString(n, DefaultFont, p.Brush, new PointF(x + 10, y + 10));

                }
            }
            catch { }
        }
        
        Dictionary<string, Dictionary<PointF, int>> ScanData = new Dictionary<string, Dictionary<PointF, int>>();
        List<PointF> LandingZones = new List<PointF>();


        private float zoom = 7f;
        private void tmrDrone_Tick(object sender, EventArgs e)
        {
            if (!chkScanner.Checked)
                return;
      //      AllDroneScan();
        }

        private void AllDroneScan(bool first = false)
        {
            if (cbxAnomalies.SelectedItem == null)
                return;
            var anomaly = cbxAnomalies.SelectedItem.ToString();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[2].Value == null)
                    continue;

                

                if (row.Cells[2].Value.ToString() == anomaly)
                {
                    var droneId = row.Cells[0].Value.ToString();
                    var data = DroneScan(droneId, first);
                    
                    row.Cells[4].Value = DronePosition[droneId].ToString();
                    row.Cells[5].Value = data.ToString();

                    row.Cells[3].Value = data["items"];

                    if (row.Selected)
                    {
                        buildEntityGrid(data["entities"]);
                        buildItemGrid(data["items"]);
                    }

                }
            }
        }

        private void buildEntityGrid(JObject data)
        {
            gwEntities.Rows.Clear();
            foreach (var row in data)
                gwEntities.Rows.Add(new object[] { row.Value["name"], row["x"], row["y"], row["thingid"] });
        }
        private void buildItemGrid(JObject data)
        {

        }

        private JObject DroneScan(string droneId, bool first = false)
        {
            try
            {
                             
                if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "")
                    return null;

                var anomaly = cbxAnomalies.SelectedValue.ToString();

                var d = new Dictionary<string, string>();
                d["arg"] = droneId;
                d["arg2"] = "scan";

                var r = ApiWrapper.ApiWrapper.GetData("drone", d);
                if (r == null)
                    return null;

                var droneX = r["x"].Value<int>() ;
                var droneY = r["y"].Value<int>() ;


                var bX = r["bx"].Value<int>() ;
                var bY = r["by"].Value<int>() ;

                var area = r["area"];

                for (int x = 0; x < area[0].Count(); x++)
                    for (int y = 0; y < area.Count(); y++)
                    {
                        var value = area[y][x].Value<int>();
                        PointF point = new PointF(bX + x , bY + y );
                        if (!ScanData.ContainsKey(dataGridView2.SelectedRows[0].Cells[2].Value.ToString()))
                        {                            
                            ScanData[dataGridView2.SelectedRows[0].Cells[2].Value.ToString()] = new Dictionary<PointF, int>();
                        }
                        ScanData[dataGridView2.SelectedRows[0].Cells[2].Value.ToString()][point] = value;
                    }


                DronePosition[droneId] =  new PointF(droneX, droneY);


                //dataGridView2.SelectedRows[0].Cells[3].Value = r["inventory"];

                if (first)
                {
                    cmbInventory.Items.Clear();
                    var inv = r["inventory"];
                    foreach (var item in inv)
                    {
                        cmbInventory.Items.Add(new InventoryItem(item["name"].ToString(), item["_id"].ToString()));                            
                    }
                }

                pictureBox1.Refresh();

                return r;
            }
            catch { }
            return null;
        }

        private class InventoryItem {
            public string Name;
            public string Id;
            public InventoryItem(string name, string id) {
                Name = name;
                Id = id;
            }

            public override string ToString()
{
 	return Name;
}
        }

        private void btnRecallDrone_Click(object sender, EventArgs e)
        {
            try
            {
                string droneId = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                var d = new Dictionary<string, string>();
                d["arg"] = droneId;
                d["arg2"] = "exit";

                var r = ApiWrapper.ApiWrapper.GetData("drone", d);
                txtLog.AppendText("Drone recalled: " + r.ToString());
                DronePosition.Remove(droneId);
                dataGridView2.SelectedRows[0].Cells[2].Value = "";
            //    AllDroneScan();
                pictureBox1.Refresh();  

            }
            catch { }
        }



        private void btnDroneUp_Click(object sender, EventArgs e)
        {
            moveDrone("up");
        }

        private void moveDrone(string direction)
        {
            try
            {
                string droneId = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                var anomaly = cbxAnomalies.SelectedValue.ToString();

                var d = new Dictionary<string, string>();
                d["arg"] = droneId;
                d["arg2"] = direction;

                var r = ApiWrapper.ApiWrapper.GetData("drone", d);
                txtLog.AppendText("MoveDrone: " + r.ToString());
                DroneScan(droneId);

            }
            catch (Exception ex) { txtLog.AppendText("Error:" + ex); }
        }

        private void btnDroneDown_Click(object sender, EventArgs e)
        {

            moveDrone("down");
        }

        private void btnDroneLeft_Click(object sender, EventArgs e)
        {

            moveDrone("left");
        }

        private void btnDroneRight_Click(object sender, EventArgs e)
        {

            moveDrone("right");
        }

        private void btnDroneGet_Click(object sender, EventArgs e)
        {
            try
            {
                string droneId = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                var anomaly = cbxAnomalies.SelectedValue.ToString();

                var d = new Dictionary<string, string>();
                d["arg"] = droneId;
                d["arg2"] = "get";
                

                var r = ApiWrapper.ApiWrapper.GetData("drone", d);
                txtLog.AppendText("Pickup: " + r.ToString());
                DroneScan(droneId, true);

            }
            catch (Exception ex) { txtLog.AppendText("Error:" + ex); }
        }

        private void btnDroneDrop_Click(object sender, EventArgs e)
        {
            try
            {
                string droneId = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                var anomaly = cbxAnomalies.SelectedValue.ToString();
                var item = ((InventoryItem)cmbInventory.SelectedItem);
                var d = new Dictionary<string, string>();
                d["arg"] = droneId;
                d["arg2"] = "drop";
                d["arg3"] = item.Id;


                var r = ApiWrapper.ApiWrapper.GetData("drone", d);
                txtLog.AppendText("Pickup: " + r.ToString());

                cmbInventory.Items.Remove(item);


            }
            catch (Exception ex) { txtLog.AppendText("Error:" + ex); }
        }




    }


}
