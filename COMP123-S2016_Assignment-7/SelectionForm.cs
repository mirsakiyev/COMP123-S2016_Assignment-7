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
        decimal[] cost = new decimal[]
        { 0.99m, 1.99m, 2.99m, 4.99m };

        string[] categories = new string[]
            {"Comedy", "Drama", "Action", "Sci-Fi", "Horror", "Thriller", "Family", "New Release"};
         

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

                if (value == "Season of the Witch")
                {
                    CategoryTextBox.Text = categories[3];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.seasonofthewitch);                   
                }

                if (value == "The Green Hornet")
                {
                    CategoryTextBox.Text = categories[2];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thegreenhornet);
                }

                if (value == "The Dilemma")
                {
                    CategoryTextBox.Text = categories[0];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thedilemma);
                }

                if (value == "Death Race 2")
                {
                    CategoryTextBox.Text = categories[2];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.deathrace2);
                }

                if (value == "Company Men")
                {
                    CategoryTextBox.Text = categories[1];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.companymen);
                }

                if (value == "No Strings Attached")
                {
                    CategoryTextBox.Text = categories[0];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.nostringsattached);
                }

                if (value == "The Way Back")
                {
                    CategoryTextBox.Text = categories[1];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thewayback);
                }

                if (value == "The Mechanic")
                {
                    CategoryTextBox.Text = categories[2];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.themechanic);
                }

                if (value == "The Rite")
                {
                    CategoryTextBox.Text = categories[4];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.therite);
                }

                if (value == "Sanctum")
                {
                    CategoryTextBox.Text = categories[2];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.sanctum);
                }

                if (value == "The Other Woman")
                {
                    CategoryTextBox.Text = categories[2];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.theotherwoman);
                }

                if (value == "The Roommate")
                {
                    CategoryTextBox.Text = categories[5];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.theroommate);
                }

                if (value == "Waiting for Forever")
                {
                    CategoryTextBox.Text = categories[1];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.waitingforever);
                }

                if (value == "Cedar Rapids")
                {
                    CategoryTextBox.Text = categories[0];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.cedarrapids);
                }

                if (value == "Gnomeo and Juliet")
                {
                    CategoryTextBox.Text = categories[6];
                    CostTextBox.Text = "$" + cost[0].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.gnomeoandjuliet);
                }

                if (value == "Just Go With It")
                {
                    CategoryTextBox.Text = categories[0];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.justgowithit);
                }

                if (value == "The Eagle")
                {
                    CategoryTextBox.Text = categories[2];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.theeagle);
                }

                if (value == "I am Number Four")
                {
                    CategoryTextBox.Text = categories[3];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.iamnumberfour);
                }

                if (value == "Footloose")
                {
                    CategoryTextBox.Text = categories[7];
                    CostTextBox.Text = "$" + cost[3].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.footloose);
                }
                if (value == "Real Steel")
                {
                    CategoryTextBox.Text = categories[7];
                    CostTextBox.Text = "$" + cost[3].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.realsteel);
                }
            }
        }
    }
}
