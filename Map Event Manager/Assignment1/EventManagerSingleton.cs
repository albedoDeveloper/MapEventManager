using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;
namespace Assignment1
{
    public sealed class EventManagerSingleton
    {
        private static readonly EventManagerSingleton instance = new EventManagerSingleton();

        public Dictionary<int, Event> EventContainer { get; set; }
        public GMap.NET.WindowsForms.GMapControl map { set; get; }
       
        private GMap.NET.WindowsForms.GMapOverlay markers;

        private GMap.NET.WindowsForms.GMapMarker currentMarker;

        private GMap.NET.WindowsForms.GMapOverlay routes;

        public double distance { set; get; }

        private int currentEditID;

        private EventManagerSingleton()
        {
            EventContainer = new Dictionary<int, Event>();
            markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            routes = new GMap.NET.WindowsForms.GMapOverlay("routes");
        }


        public static EventManagerSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        ///  start an event based upon the corrseponding marker ID
        /// </summary>
        /// <param name="item"></param>
        public void StartEvent(GMap.NET.WindowsForms.GMapMarker item)
        {
            currentMarker = item;
            if (EventContainer.ContainsKey(item.GetHashCode()))
            {
                EventContainer[item.GetHashCode()].ShowEvent();
            }
        }

        /// <summary>
        /// Start an event based upon the user created name of that event
        /// </summary>
        /// <param name="name"></param>
        public void StartEventName(String name)
        {
            foreach (KeyValuePair<int, Event> entry in EventContainer)
            {
                if (entry.Value.name == name)
                {
                    map.Position = new GMap.NET.PointLatLng(entry.Value.latitude, entry.Value.longitude);
                    entry.Value.ShowEvent();
                }

            }
        }

        /// <summary>
        /// Find the closest event based on the map pointers current location.
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        public GMap.NET.PointLatLng ClosestEvent(bool move)
        {
            GMap.NET.PointLatLng temp = new GMap.NET.PointLatLng(0, 0); 

            var startpoint = new System.Device.Location.GeoCoordinate(map.Position.Lat, map.Position.Lng);
            double distance = 1000000;
            KeyValuePair<int, Event> intitate = EventContainer.First();

            foreach (KeyValuePair<int, Event> entry in EventContainer)
            {
                var endpoint = new System.Device.Location.GeoCoordinate(entry.Value.latitude, entry.Value.longitude);
                    
                if (startpoint.GetDistanceTo(endpoint) < distance)
                {
                    distance = startpoint.GetDistanceTo(endpoint);
                    intitate = entry;
                }

            }
            
            this.distance = distance;
            temp = new GMap.NET.PointLatLng(intitate.Value.latitude, intitate.Value.longitude);
            if (move)
            {
                map.Position = temp;
                intitate.Value.ShowEvent();
            }


            return temp;
        }

        /// <summary>
        /// Calls the Edit function in the Event based upon the submitted ID
        /// </summary>
        /// <param name="ID"></param>
        public void EditEvent(int ID)
        {
            foreach (KeyValuePair<int, Event> entry in EventContainer)
            {
                if (entry.Value.ID == ID)
                {
                    currentEditID = entry.Key;
                    entry.Value.EditEvent();
                }

            }
        }

        /// <summary>
        /// Edits an event based on its ID
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        public void EditEventConfirmation(string name, string text)
        {
            Event value;
            EventContainer.TryGetValue(currentEditID, out value);
            value.EditEventConfirm(name,text);
        }
        
        /// <summary>
        /// Calls the delete event of the event based on its ID
        /// </summary>
        /// <param name="ID"></param>
        public void DeleteEvent(int ID)
        {
            foreach (KeyValuePair<int, Event> entry in EventContainer)
            {
                if (entry.Value.ID == ID)
                {
                    entry.Value.DeleteEvent();
                }

            }
            
            EventContainer.Remove(currentMarker.GetHashCode());
            map.Overlays[0].Markers.Remove(currentMarker);
        }
        
        /// <summary>
        /// Create a route between all events, in chronological order from when each one was made.
        /// </summary>
        public void RouteAllEvent()
        {
            routes.Routes.Clear();
           if(map.Overlays.Count > 1)
                map.Overlays[1].Routes.Clear();
            
            KeyValuePair<int, Event> intitate = EventContainer.First();
            int i = 0;
           
            foreach (KeyValuePair<int, Event> entry in EventContainer)
            {
                if (i != 0)
                {
                    List<GMap.NET.PointLatLng> te = new List<GMap.NET.PointLatLng>();

                     te.Add(new GMap.NET.PointLatLng(intitate.Value.latitude, intitate.Value.longitude));
                     te.Add(new GMap.NET.PointLatLng(entry.Value.latitude, entry.Value.longitude));

                    var r = new GMap.NET.WindowsForms.GMapRoute(te, "route" + i);
                    map.UpdateRouteLocalPosition(r);
                    routes.Routes.Add(r);
                    intitate = entry;
                }
                
                i++;
               
            }
           
            map.Overlays.Add(routes);
            map.Refresh();
        }

        /// <summary>
        /// Create a route to the nearest event, as well calculate the exact distance to it in KM
        /// </summary>
        public void RouteToNearest()
        {
            routes.Routes.Clear();
            if (map.Overlays.Count > 1)
                map.Overlays[1].Routes.Clear();

            List<GMap.NET.PointLatLng> te = new List<GMap.NET.PointLatLng>
            {
                ClosestEvent(false),
                map.Position
            };
            var r = new GMap.NET.WindowsForms.GMapRoute(te, "route");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);
            map.UpdateRouteLocalPosition(r);
            map.Refresh();
        }

        /// <summary>
        /// Add an event to the XML file, and the calls the ability to add it to the map and dictionary.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AddEvent(string name, string type, string info)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            var soapFromFile = XDocument.Load(path + "\\SoapFile.xml");

            var allEvents = soapFromFile.Root.Descendants("Event");

            int i = 0;
            foreach (var element in allEvents)
            {
                var j = int.Parse(element.Element("eventid").Value);
                if (j > i)
                    i = j;
            }

            i++;

            //Using XML.Linq to create a new event
            System.Xml.Linq.XElement tempElement = new XElement("Event", new XElement("eventid", i++),
                                                    new XElement("Name", name),
                                                    new XElement("Type", type),
                                                    new XElement("Data", info),
                                                    new XElement("Location", new XElement("lat", map.Position.Lat),
                                                                            new XElement("long", map.Position.Lng)),
                                                    new XElement("Start-time", DateTime.Now.ToString()));

            soapFromFile.Root.Add(tempElement);

            soapFromFile.Save(path + "\\SoapFile.xml");

            DetermineEventType(tempElement);
            return i;
        }

        /// <summary>
        /// Load an XML file and populate each element into the event dictionary
        /// </summary>
        public void LoadXMLFile()
        {
            map.Overlays.Add(markers);
            string path = AppDomain.CurrentDomain.BaseDirectory;
            var soapFromFile = XDocument.Load(path + "\\SoapFile.xml");

            var allEvents = soapFromFile.Root.Descendants("Event");

            foreach (var eventType in allEvents)
            {
                DetermineEventType(eventType);
            }
        }

        /// <summary>
        /// Determine what type of event (such as tweet) the element is, then create that event object
        /// </summary>
        /// <param name="eventType"></param>
        private void DetermineEventType(XElement eventType)
        {
            if (eventType.Element("Type").Value.Equals("facebook status"))
            {
                FacebookEvent tEvent = new FacebookEvent(eventType);
                AddMarker(GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin, tEvent);

            }

            else if (eventType.Element("Type").Value.Equals("tweet"))
            {
                TwitterEvent tEvent = new TwitterEvent(eventType);
                AddMarker(GMap.NET.WindowsForms.Markers.GMarkerGoogleType.yellow_pushpin, tEvent);

            }

            else if (eventType.Element("Type").Value.Equals("image"))
            {
                ImageEvent tEvent = new ImageEvent(eventType);
                AddMarker(GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_pushpin, tEvent);
            }

            else if (eventType.Element("Type").Value.Equals("video"))
            {
                VideoEvent tEvent = new VideoEvent(eventType);
                AddMarker(GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green_pushpin, tEvent);
            }

            else if (eventType.Element("Type").Value.Equals("gpx"))
            {
                GPXEvent tEvent = new GPXEvent(eventType);
                AddMarker(GMap.NET.WindowsForms.Markers.GMarkerGoogleType.purple_pushpin, tEvent);
            }
        }

        /// <summary>
        /// Add a marker based upon the created event
        /// </summary>
        /// <param name="pinType"></param>
        /// <param name="tEvent"></param>
        private void AddMarker(GMap.NET.WindowsForms.Markers.GMarkerGoogleType pinType, Event tEvent)
        {
            GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(tEvent.latitude, tEvent.longitude), pinType);

            //markers.Markers.Add(marker);
            map.Overlays[0].Markers.Add(marker);
            EventContainer.Add(marker.GetHashCode(), tEvent);
        }
    }
}

