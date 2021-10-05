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
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LongitudeLabel_Click(object sender, EventArgs e)
        {

        }

        private void LatitudeLabel_Click(object sender, EventArgs e)
        {

        }

        private void IdLabel_Click(object sender, EventArgs e)
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
