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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
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
