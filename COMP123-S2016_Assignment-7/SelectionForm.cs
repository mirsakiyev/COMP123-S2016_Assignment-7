using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace COMP123_S2016_Assignment_7
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new SplashyScreen());
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = string.Empty;

            foreach (string value in MovieListBox.SelectedItems)
            {
                TitleTextBox.Text = value.ToString();
                if (value == "The Dilemma")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thedilemma);
                }
            }
        }
    }
}
