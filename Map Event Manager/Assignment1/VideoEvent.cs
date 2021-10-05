using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Assignment1
{
    class VideoEvent:Event
    {

        public VideoEvent(XElement eventT)
        {

            var id = int.Parse(eventT.Element("eventid").Value);
            var name = eventT.Element("Name").Value;
            var filePath = eventT.Element("Data").Value;
            var latitude = double.Parse(eventT.Element("Location").Element("lat").Value);
            var longitude = double.Parse(eventT.Element("Location").Element("long").Value);
            var dateTime = DateTime.Parse(eventT.Element("Start-time").Value);

            creationDate = dateTime;

            ID = id;
            this.name = name;
            type = "video";
            this.text = filePath;
            this.text = filePath;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public override void ShowEvent()
        {
            Form5 eventForm = new Form5();

            eventForm.Text = "Video Event";
            var numid = (Label)eventForm.Controls.Find("metroLabel2", false).FirstOrDefault();
            numid.Text = ID.ToString();

            var id = (Label)eventForm.Controls.Find("IdLabel", false).FirstOrDefault();
            id.Text = name;

            var lat = (Label)eventForm.Controls.Find("LatitudeLabel", false).FirstOrDefault();
            lat.Text = latitude.ToString();

            var lon = (Label)eventForm.Controls.Find("LongitudeLabel", false).FirstOrDefault();
            lon.Text = longitude.ToString();

            var date = (Label)eventForm.Controls.Find("Date", false).FirstOrDefault();
            date.Text = creationDate.ToString();

            var mediaPlayer = (AxWMPLib.AxWindowsMediaPlayer)eventForm.Controls.Find("axWindowsMediaPlayer1", false).FirstOrDefault();
            mediaPlayer.URL = text;
            mediaPlayer.Ctlcontrols.play();
                
            eventForm.ShowDialog();
        }



    }
}
