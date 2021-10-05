namespace Assignment1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.LatTextbox = new MetroFramework.Controls.MetroTextBox();
            this.LatLabel = new MetroFramework.Controls.MetroLabel();
            this.LongLabel = new MetroFramework.Controls.MetroLabel();
            this.LongTextbox = new MetroFramework.Controls.MetroTextBox();
            this.FindLocationButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.EventFinderButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(23, 63);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(754, 466);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 12D;
            this.gMapControl1.OnMapClick += new GMap.NET.WindowsForms.MapClick(this.gMapControl1_OnMapClick);
            this.gMapControl1.OnMapDoubleClick += new GMap.NET.WindowsForms.MapDoubleClick(this.gMapControl1_OnMapDoubleClick);
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMapControl1.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.gMapControl1_OnMarkerEnter);
            this.gMapControl1.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.gMapControl1_OnMarkerLeave);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // LatTextbox
            // 
            this.LatTextbox.Location = new System.Drawing.Point(856, 102);
            this.LatTextbox.Name = "LatTextbox";
            this.LatTextbox.Size = new System.Drawing.Size(132, 23);
            this.LatTextbox.TabIndex = 1;
            this.LatTextbox.Text = "0";
            // 
            // LatLabel
            // 
            this.LatLabel.AutoSize = true;
            this.LatLabel.Location = new System.Drawing.Point(783, 101);
            this.LatLabel.Name = "LatLabel";
            this.LatLabel.Size = new System.Drawing.Size(55, 19);
            this.LatLabel.TabIndex = 2;
            this.LatLabel.Text = "Latitude";
            // 
            // LongLabel
            // 
            this.LongLabel.AutoSize = true;
            this.LongLabel.Location = new System.Drawing.Point(783, 130);
            this.LongLabel.Name = "LongLabel";
            this.LongLabel.Size = new System.Drawing.Size(67, 19);
            this.LongLabel.TabIndex = 4;
            this.LongLabel.Text = "Longitude";
            // 
            // LongTextbox
            // 
            this.LongTextbox.Location = new System.Drawing.Point(856, 130);
            this.LongTextbox.Name = "LongTextbox";
            this.LongTextbox.Size = new System.Drawing.Size(132, 23);
            this.LongTextbox.TabIndex = 3;
            this.LongTextbox.Text = "0";
            // 
            // FindLocationButton
            // 
            this.FindLocationButton.Location = new System.Drawing.Point(883, 159);
            this.FindLocationButton.Name = "FindLocationButton";
            this.FindLocationButton.Size = new System.Drawing.Size(75, 23);
            this.FindLocationButton.TabIndex = 5;
            this.FindLocationButton.Text = "Find";
            this.FindLocationButton.Click += new System.EventHandler(this.FindLocationButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(868, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Location Finder";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(877, 217);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Event Finder";
            // 
            // EventFinderButton
            // 
            this.EventFinderButton.Location = new System.Drawing.Point(877, 279);
            this.EventFinderButton.Name = "EventFinderButton";
            this.EventFinderButton.Size = new System.Drawing.Size(75, 23);
            this.EventFinderButton.TabIndex = 10;
            this.EventFinderButton.Text = "Find";
            this.EventFinderButton.Click += new System.EventHandler(this.EventFinderButton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(787, 250);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Name";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(850, 250);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(132, 23);
            this.metroTextBox1.TabIndex = 8;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(850, 329);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(126, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Go to Nearest Event";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(877, 351);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "Find";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(602, 541);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Calender";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(867, 499);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Route all Events";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(877, 521);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 15;
            this.metroButton3.Text = "Create";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(877, 410);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.TabIndex = 17;
            this.metroButton4.Text = "Create";
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(842, 388);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(140, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Route to nearest event";
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(380, 541);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(155, 23);
            this.metroButton5.TabIndex = 18;
            this.metroButton5.Text = "Closest Bustop (Perth only)";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(803, 450);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(218, 19);
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "Calculated distance to nearest Event";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(868, 469);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(12, 19);
            this.metroLabel8.TabIndex = 20;
            this.metroLabel8.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1027, 587);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.EventFinderButton);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.FindLocationButton);
            this.Controls.Add(this.LongLabel);
            this.Controls.Add(this.LongTextbox);
            this.Controls.Add(this.LatLabel);
            this.Controls.Add(this.LatTextbox);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form1";
            this.Text = "Map Event Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton FindLocationButton;
        private MetroFramework.Controls.MetroLabel LongLabel;
        private MetroFramework.Controls.MetroTextBox LongTextbox;
        private MetroFramework.Controls.MetroLabel LatLabel;
        private MetroFramework.Controls.MetroTextBox LatTextbox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton EventFinderButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}

