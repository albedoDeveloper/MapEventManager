using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    class Calender
    {
        /// <summary>
        /// Display all the events on the corresponding selected date in the event
        /// </summary>
        /// <param name="list"></param>
        /// <param name="date"></param>
        public void GetAllEventsAtDate(ref ListView list, DateTime date)
        {
            list.Items.Clear();
            foreach (KeyValuePair<int, Event> entry in EventManagerSingleton.Instance.EventContainer)
            {
                if (date.Date.Equals(entry.Value.creationDate.Date))
                    list.Items.Add(entry.Value.name);
            }
        }

        /// <summary>
        /// Go to the selected event from  list the  calender returned
        /// </summary>
        /// <param name="selected"></param>
        public void GoToEvent(string selected)
        {
            foreach (KeyValuePair<int, Event> entry in EventManagerSingleton.Instance.EventContainer)
            {
                if(selected.Equals(entry.Value.name))
                {
                    EventManagerSingleton.Instance.StartEventName(selected);

                }
            }

        }

    
    }
}
