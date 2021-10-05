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
    public partial class Form6 : MetroFramework.Forms.MetroForm
    {

        private Calender calender = new Calender();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            calender.GetAllEventsAtDate(ref listView1, monthCalendar1.SelectionStart);
        }

        private void sfCalendar1_Click(object sender, EventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            calender.GoToEvent(listView1.SelectedItems[0].Text);
            Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            calender.GetAllEventsAtDate(ref listView1, monthCalendar1.SelectionStart);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            calender.GetAllEventsAtDate(ref listView1, monthCalendar1.SelectionStart);
        }

        private void monthCalendar1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
