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
    public partial class Form8 : MetroFramework.Forms.MetroForm
    {
        private string listSelect;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = 0;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), @"Assignment1");

            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.Text = openFileDialog1.FileName;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSelect = metroComboBox1.SelectedItem.ToString();
            if (listSelect.Equals("image"))
            {
                label2.Text = "Filepath";
                openFileDialog1.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif; *.tif";
            }
            else if (listSelect.Equals("video"))
            {
                label2.Text = "Filepath";
                openFileDialog1.Filter = "Videos Files | *.avi; *.mp4;";
            }
            else
            {
                label2.Text = "Text";
                openFileDialog1.Filter = "";
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            EventManagerSingleton.Instance.EditEventConfirmation(metroTextBox1.Text, richTextBox1.Text);
            this.Close();
            Application.OpenForms[3].Close();
        }
    }
}
