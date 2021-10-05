using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        BusStopFinder busFinder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            busFinder = new BusStopFinder();
            busFinder.CreateBusStopArray();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.DragButton = MouseButtons.Left;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(-31.9523, 115.8613);
            EventManagerSingleton.Instance.map = gMapControl1;
            EventManagerSingleton.Instance.LoadXMLFile();
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {

        }


        private void gMapControl1_OnMarkerEnter(GMap.NET.WindowsForms.GMapMarker item)
        {
            
        }

        private void gMapControl1_OnMarkerLeave(GMap.NET.WindowsForms.GMapMarker item)
        {
        
        }

        private void gMapControl1_OnMapDoubleClick(GMap.NET.PointLatLng pointClick, MouseEventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gMapControl1_OnMapClick(GMap.NET.PointLatLng pointClick, MouseEventArgs e)
        {

        }

        private void gMapControl1_OnMarkerClick(GMap.NET.WindowsForms.GMapMarker item, MouseEventArgs e)
        {
            EventManagerSingleton.Instance.StartEvent(item);
        }

        private void FindLocationButton_Click(object sender, EventArgs e)
        {
            gMapControl1.Position = new GMap.NET.PointLatLng(double.Parse(LatTextbox.Text), double.Parse(LongTextbox.Text));

        }

        private void EventFinderButton_Click(object sender, EventArgs e)
        {
            EventManagerSingleton.Instance.StartEventName(metroTextBox1.Text);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            EventManagerSingleton.Instance.ClosestEvent(true);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            EventManagerSingleton.Instance.RouteAllEvent();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            EventManagerSingleton.Instance.RouteToNearest();
            metroLabel8.Text = (Math.Round(EventManagerSingleton.Instance.distance,2)/1000).ToString() + "km";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            busFinder.FindClosestBus(ref gMapControl1);
        }
    }
}
