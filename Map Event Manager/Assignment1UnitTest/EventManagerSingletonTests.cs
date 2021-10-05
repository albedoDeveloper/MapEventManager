using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System.Xml.Linq;

namespace Assignment1.Tests
{

    [TestClass()]
    public class EventManagerSingletonTests
    {
        [TestMethod()]
        public void AddEventTest()
        {

            System.Xml.Linq.XElement tempElement = new XElement("Event", new XElement("eventid", 10),
                                                    new XElement("Name", "test"),
                                                    new XElement("Type", "tweet"),
                                                    new XElement("Data", "testing"),
                                                    new XElement("Location", new XElement("lat", 0),
                                                                            new XElement("long", 0)),
                                                    new XElement("Start-time", DateTime.Now.ToString()));

            TwitterEvent tEvent = new TwitterEvent(tempElement);

            if (!tEvent.name.Equals("test"))
                Assert.Fail();
        }

        [TestMethod()]
        public void DeleteEventTest()
        {
            System.Xml.Linq.XElement tempElement = new XElement("Event", new XElement("eventid", 10),
                                                  new XElement("Name", "test"),
                                                  new XElement("Type", "tweet"),
                                                  new XElement("Data", "testing"),
                                                  new XElement("Location", new XElement("lat", 0),
                                                                          new XElement("long", 0)),
                                                  new XElement("Start-time", DateTime.Now.ToString()));

            TwitterEvent tEvent = new TwitterEvent(tempElement);

            tEvent.DeleteEvent();


        }

        [TestMethod()]
        public void EditEventTest()
        {
            System.Xml.Linq.XElement tempElement = new XElement("Event", new XElement("eventid", 10),
                                                  new XElement("Name", "test"),
                                                  new XElement("Type", "tweet"),
                                                  new XElement("Data", "testing"),
                                                  new XElement("Location", new XElement("lat", 0),
                                                                          new XElement("long", 0)),
                                                  new XElement("Start-time", DateTime.Now.ToString()));

            TwitterEvent tEvent = new TwitterEvent(tempElement);
            
            tEvent.EditEvent();
        }

        [TestMethod()]
        public void GetBusStopArrayTest()
        {
            BusStopFinder bs = new BusStopFinder();
            bs.CreateBusStopArray();

            if (!bs.allstops[0].stop_name.Equals("\"Albany Hwy After Armadale Rd\""))
                Assert.Fail();
        }


        [TestMethod()]
        public void FindClosestBus()
        {
            GMap.NET.WindowsForms.GMapControl map = new GMap.NET.WindowsForms.GMapControl();
            var temp = new GMap.NET.PointLatLng(0, 0);
            BusStopFinder bs = new BusStopFinder();
            bs.CreateBusStopArray();
            bs.FindClosestBus(ref map);
        }



    }
}

