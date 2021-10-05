using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Assignment1
{
    class ImageEvent: Event
    {


        public ImageEvent(XElement eventT)
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
            type = "image";
            this.text = filePath;
            this.latitude = latitude;
            this.longitude = longitude;
        }


        public override void ShowEvent()
        {
            Form4 eventForm = new Form4();

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
            var image = (PictureBox)eventForm.Controls.Find("PictureBox1", false).FirstOrDefault();

            try
            {
                image.Load(text);
                image.Refresh();
            }

            catch
            {
                Console.WriteLine("No image Loaded");
            }
            
            eventForm.Text = "Image";

            eventForm.ShowDialog();
        }



    }
}
