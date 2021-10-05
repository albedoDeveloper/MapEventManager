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
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            EventManagerSingleton.Instance.DeleteEvent(int.Parse(metroLabel2.Text));
            Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            EventManagerSingleton.Instance.EditEvent(int.Parse(metroLabel2.Text));
        }
    }
}
