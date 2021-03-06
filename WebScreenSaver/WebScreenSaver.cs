﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScreenSaver
{
    public partial class WebScreenSaver : Form
    {
        public WebScreenSaver(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        private void WebScreenSaver_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            TopMost = true;
        }

        private void WebScreenSaver_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void WebScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private Point mouseLocation;

        private void WebScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 5)
                    Application.Exit();
            }

            // Update current mouse location
            mouseLocation = e.Location;

        }
    }
}
