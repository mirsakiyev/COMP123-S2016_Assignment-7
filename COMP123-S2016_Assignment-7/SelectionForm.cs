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

                Variables variables = new Variables();

                if (value == "Season of the Witch")
                {
                    CategoryTextBox.Text = categories[3];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.seasonofthewitch);
                    variables.userSelection = value;
                                           
                }

                if (value == "The Green Hornet")
                {
                    CategoryTextBox.Text = categories[2];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thegreenhornet);
                    variables.userSelection = value;
                }

                if (value == "The Dilemma")
                {
                    CategoryTextBox.Text = categories[0];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thedilemma);
                    variables.userSelection = value;
                }

                if (value == "Death Race 2")
                {
                    CategoryTextBox.Text = categories[2];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.deathrace2);
                    variables.userSelection = value;
                }

                if (value == "Company Men")
                {
                    CategoryTextBox.Text = categories[1];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.companymen);
                    variables.userSelection = value;
                }

                if (value == "No Strings Attached")
                {
                    CategoryTextBox.Text = categories[0];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.nostringsattached);
                    variables.userSelection = value;
                }

                if (value == "The Way Back")
                {
                    CategoryTextBox.Text = categories[1];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thewayback);
                    variables.userSelection = value;
                }

                if (value == "The Mechanic")
                {
                    CategoryTextBox.Text = categories[2];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.themechanic);
                    variables.userSelection = value;
                }

                if (value == "The Rite")
                {
                    CategoryTextBox.Text = categories[4];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.therite);
                    variables.userSelection = value;
                }

                if (value == "Sanctum")
                {
                    CategoryTextBox.Text = categories[2];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.sanctum);
                    variables.userSelection = value;
                }

                if (value == "The Other Woman")
                {
                    CategoryTextBox.Text = categories[2];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.theotherwoman);
                    variables.userSelection = value;
                }

                if (value == "The Roommate")
                {
                    CategoryTextBox.Text = categories[5];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.theroommate);
                    variables.userSelection = value;
                }

                if (value == "Waiting for Forever")
                {
                    CategoryTextBox.Text = categories[1];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.waitingforever);
                    variables.userSelection = value;
                }

                if (value == "Cedar Rapids")
                {
                    CategoryTextBox.Text = categories[0];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.cedarrapids);
                    variables.userSelection = value;
                }

                if (value == "Gnomeo and Juliet")
                {
                    CategoryTextBox.Text = categories[6];
                    CostTextBox.Text = "$" + cost[0].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.gnomeoandjuliet);
                    variables.userSelection = value;
                }

                if (value == "Just Go With It")
                {
                    CategoryTextBox.Text = categories[0];
                    CostTextBox.Text = "$" + cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.justgowithit);
                    variables.userSelection = value;
                }

                if (value == "The Eagle")
                {
                    CategoryTextBox.Text = categories[2];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.theeagle);
                    variables.userSelection = value;
                }

                if (value == "I am Number Four")
                {
                    CategoryTextBox.Text = categories[3];
                    CostTextBox.Text = "$" + cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.iamnumberfour);
                    variables.userSelection = value;
                }

                if (value == "Footloose")
                {
                    CategoryTextBox.Text = categories[7];
                    CostTextBox.Text = "$" + cost[3].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.footloose);
                    variables.userSelection = value;
                }
                if (value == "Real Steel")
                {
                    CategoryTextBox.Text = categories[7];
                    CostTextBox.Text = "$" + cost[3].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.realsteel);
                    variables.userSelection = value;
                }                
            }
        }
    }
}
