using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Assignment1
{
    public class TwitterEvent : Event
    {



        public TwitterEvent(XElement eventT)
        {

            var id = int.Parse(eventT.Element("eventid").Value);
            var name = eventT.Element("Name").Value;
            var text = eventT.Element("Data").Value;
            var latitude = double.Parse(eventT.Element("Location").Element("lat").Value);
            var longitude = double.Parse(eventT.Element("Location").Element("long").Value);
            var dateTime = DateTime.Parse(eventT.Element("Start-time").Value);

            creationDate = dateTime;
            ID = id;
            this.name = name;
            type = "tweet";
            this.text = text;
            this.latitude = latitude;
            this.longitude = longitude;

        }

        public override void ShowEvent()
        {
            Form3 eventForm = new Form3();
            var numid = (Label)eventForm.Controls.Find("metroLabel2", false).FirstOrDefault();
            numid.Text = ID.ToString();

            var id = (Label)eventForm.Controls.Find("IdLabel", false).FirstOrDefault();
            id.Text = name;

            var lat = (Label)eventForm.Controls.Find("LatitudeLabel", false).FirstOrDefault();
            lat.Text = latitude.ToString();

            var lon = (Label)eventForm.Controls.Find("LongitudeLabel", false).FirstOrDefault();
            lon.Text = longitude.ToString();

            var text = (Label)eventForm.Controls.Find("InfoLabel", false).FirstOrDefault();
            text.Text = this.text;

            var date = (Label)eventForm.Controls.Find("Date", false).FirstOrDefault();
            date.Text = creationDate.ToString();

            eventForm.Text = "Tweet";

            eventForm.ShowDialog();
        }


    }
}
