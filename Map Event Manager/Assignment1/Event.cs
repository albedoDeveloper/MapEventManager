using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment1
{
    public abstract class Event
    {
        public int ID { get; set; }

        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string type { get; set; }
        public string text { get; set; }
        public DateTime creationDate { get; set; }

        public abstract void ShowEvent();
        
        /// <summary>
        ///  Create the edit form to change the values of the event
        /// </summary>
        public void EditEvent()
        {
            Form8 editForm = new Form8();
            editForm.Text = "Edit Form";
            
            var editButton = (Button)editForm.Controls.Find("metroButton1", false).FirstOrDefault();
            editButton.Text = "Edit";

            var name = (MetroFramework.Controls.MetroTextBox)editForm.Controls.Find("metroTextBox1", false).FirstOrDefault();
            name.Text = this.name;

            var textbox = (RichTextBox)editForm.Controls.Find("richTextBox1", false).FirstOrDefault();
            textbox.Text = text;

            var selectionbox =(MetroFramework.Controls.MetroComboBox)editForm.Controls.Find("metroComboBox1", false).FirstOrDefault();
            selectionbox.Items.Clear();
            selectionbox.Items.Add(type);
            editForm.ShowDialog();


        }

        /// <summary>
        /// Edit an events value, such as its name and information based upon the edit form
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        public void EditEventConfirm(string name, string text)
        {
            this.name = name;

            this.text = text;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            
            var soapFromFile = XDocument.Load(path + "\\SoapFile.xml");

            var node = from n in soapFromFile.Root.Descendants("Event")
                       where n.Element("eventid").Value == ID.ToString()
                       select n;
           
            node.Descendants("Name").FirstOrDefault().Value = name;
            node.Descendants("Data").FirstOrDefault().Value = text;

            soapFromFile.Save(path + "\\SoapFile.xml");

        }


        /// <summary>
        /// Delete the event from the XML, dictionary and map
        /// </summary>
            public void DeleteEvent()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            var soapFromFile = XDocument.Load(path + "\\SoapFile.xml");

            var node = from n in soapFromFile.Root.Descendants("Event")
                       where n.Element("eventid").Value == ID.ToString()
                       select n;

            node.Remove();

            soapFromFile.Save(path + "\\SoapFile.xml");

        }


    }
}
