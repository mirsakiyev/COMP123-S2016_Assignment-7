﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Assignment_7
{
    public partial class SplashyScreen : Form
    {
        public SplashyScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value==100)
            {
                timer.Stop();
            }
        }
    }
}
