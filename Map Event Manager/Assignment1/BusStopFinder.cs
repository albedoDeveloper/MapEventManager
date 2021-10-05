using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using System.Windows.Forms;

namespace Assignment1
{

    public class BusStopFinder
    {

        [DelimitedRecord(",")]
        [IgnoreFirst(1)]
        public class BusStopInfo
        {
            public string location_type;
            public string parent_station;
            public string stop_id;
            public string stop_code;
            public string stop_name;
            public string stop_desc;
            public double stop_lat;
            public double stop_lon;
            public string zone_id;
            public string supported_modes;

        }

        public List<BusStopInfo> allstops;
        /// <summary>
        /// Parse the bus stop information into an array of bustops.
        /// </summary>
        public void CreateBusStopArray()
        {
            var engine = new FileHelperEngine<BusStopInfo>();

            allstops = new List<BusStopInfo>(engine.ReadFile(AppDomain.CurrentDomain.BaseDirectory + "\\stops.txt"));
        }
        /// <summary>
        /// Find the closest bus to the map markers current location
        /// </summary>
        /// <param name="map"></param>
        public void FindClosestBus(ref GMap.NET.WindowsForms.GMapControl map)
        {
            GMap.NET.PointLatLng temp = new GMap.NET.PointLatLng(0, 0);
            var startpoint = new System.Device.Location.GeoCoordinate(map.Position.Lat, map.Position.Lng);
            BusStopInfo intitate = new BusStopInfo();

            double distance = 1000000;

            foreach (BusStopInfo entry in allstops)
            {
                var endpoint = new System.Device.Location.GeoCoordinate(entry.stop_lat, entry.stop_lon);

                if (startpoint.GetDistanceTo(endpoint) < distance)
                {
                    distance = startpoint.GetDistanceTo(endpoint);
                    intitate = entry;
                }

            }

            temp = new GMap.NET.PointLatLng(intitate.stop_lat, intitate.stop_lon);
            map.Position = temp;

           var busStopForm = new Form7();
           var stop = (Label)busStopForm.Controls.Find("metroLabel1", false).FirstOrDefault();
            stop.Text = intitate.stop_name;
            busStopForm.ShowDialog();

        }
    }

}