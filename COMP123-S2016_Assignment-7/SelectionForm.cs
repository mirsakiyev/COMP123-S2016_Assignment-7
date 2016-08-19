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
        public double[] cost = new double[]
        { 0.99, 1.99, 2.99, 4.99 };

        public string[] categories = new string[]
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
            try
            {
                TitleTextBox.Text = string.Empty;

                foreach (string value in MovieListBox.SelectedItems)
                {
                    TitleTextBox.Text = value.ToString();

                    Variables variables = Program.variables;

                    if (value == "Season of the Witch")
                    {
                        CategoryTextBox.Text = categories[3];
                        CostTextBox.Text = "$" + cost[2].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.seasonofthewitch);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[3];
                        variables.userSelectionCost = cost[2].ToString();

                    }

                    if (value == "The Green Hornet")
                    {
                        CategoryTextBox.Text = categories[2];
                        CostTextBox.Text = "$" + cost[2].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.thegreenhornet);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[2];
                        variables.userSelectionCost = cost[2].ToString();


                    }

                    if (value == "The Dilemma")
                    {
                        CategoryTextBox.Text = categories[0];
                        CostTextBox.Text = "$" + cost[1].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.thedilemma);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[0];
                        variables.userSelectionCost = cost[1].ToString();
                    }

                    if (value == "Death Race 2")
                    {
                        CategoryTextBox.Text = categories[2];
                        CostTextBox.Text = "$" + cost[2].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.deathrace2);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[2];
                        variables.userSelectionCost = cost[2].ToString();
                    }

                    if (value == "Company Men")
                    {
                        CategoryTextBox.Text = categories[1];
                        CostTextBox.Text = "$" + cost[1].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.companymen);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[1];
                        variables.userSelectionCost = cost[1].ToString();
                    }

                    if (value == "No Strings Attached")
                    {
                        CategoryTextBox.Text = categories[0];
                        CostTextBox.Text = "$" + cost[1].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.nostringsattached);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[0];
                        variables.userSelectionCost = cost[1].ToString();
                    }

                    if (value == "The Way Back")
                    {
                        CategoryTextBox.Text = categories[1];
                        CostTextBox.Text = "$" + cost[1].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.thewayback);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[1]; ;
                        variables.userSelectionCost = cost[1].ToString();
                    }

                    if (value == "The Mechanic")
                    {
                        CategoryTextBox.Text = categories[2];
                        CostTextBox.Text = "$" + cost[2].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.themechanic);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[2];
                        variables.userSelectionCost = cost[2].ToString();
                    }

                    if (value == "The Rite")
                    {
                        CategoryTextBox.Text = categories[4];
                        CostTextBox.Text = "$" + cost[2].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.therite);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[4];
                        variables.userSelectionCost = cost[2].ToString();
                    }

                    if (value == "Sanctum")
                    {
                        CategoryTextBox.Text = categories[2];
                        CostTextBox.Text = "$" + cost[2].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.sanctum);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[2];
                        variables.userSelectionCost = cost[2].ToString();
                    }

                    if (value == "The Other Woman")
                    {
                        CategoryTextBox.Text = categories[2];
                        CostTextBox.Text = "$" + cost[2].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.theotherwoman);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[2];
                        variables.userSelectionCost = cost[2].ToString();
                    }

                    if (value == "The Roommate")
                    {
                        CategoryTextBox.Text = categories[5];
                        CostTextBox.Text = "$" + cost[1].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.theroommate);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[5];
                        variables.userSelectionCost = cost[1].ToString();
                    }

                    if (value == "Waiting for Forever")
                    {
                        CategoryTextBox.Text = categories[1];
                        CostTextBox.Text = "$" + cost[1].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.waitingforever);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[1];
                        variables.userSelectionCost = cost[1].ToString();
                    }

                    if (value == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = categories[0];
                        CostTextBox.Text = "$" + cost[1].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.cedarrapids);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[0];
                        variables.userSelectionCost = cost[1].ToString();
                    }

                    if (value == "Gnomeo and Juliet")
                    {
                        CategoryTextBox.Text = categories[6];
                        CostTextBox.Text = "$" + cost[0].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.gnomeoandjuliet);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[6];
                        variables.userSelectionCost = cost[0].ToString();
                    }

                    if (value == "Just Go With It")
                    {
                        CategoryTextBox.Text = categories[0];
                        CostTextBox.Text = "$" + cost[1].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.justgowithit);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[0];
                        variables.userSelectionCost = cost[1].ToString();
                    }

                    if (value == "The Eagle")
                    {
                        CategoryTextBox.Text = categories[2];
                        CostTextBox.Text = "$" + cost[2].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.theeagle);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[2];
                        variables.userSelectionCost = cost[2].ToString();
                    }

                    if (value == "I am Number Four")
                    {
                        CategoryTextBox.Text = categories[3];
                        CostTextBox.Text = "$" + cost[2].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.iamnumberfour);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[3];
                        variables.userSelectionCost = cost[2].ToString();
                    }

                    if (value == "Footloose")
                    {
                        CategoryTextBox.Text = categories[7];
                        CostTextBox.Text = "$" + cost[3].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.footloose);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[7];
                        variables.userSelectionCost = cost[3].ToString();
                    }

                    if (value == "Real Steel")
                    {
                        CategoryTextBox.Text = categories[7];
                        CostTextBox.Text = "$" + cost[3].ToString();
                        MoviePictureBox.Image = new Bitmap(Properties.Resources.realsteel);
                        variables.userSelectionTitle = value;
                        variables.userSelectionCategory = categories[7];
                        variables.userSelectionCost = cost[3].ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1 - Hide the parent form
                this.Hide();

                // Step - 2 Instantiate an object for the form type
                // you are going to next
                OrderForm orderForm = new OrderForm();

                // Step - 3 Create a property in the next form that 
                // we will use to piont to this form
                // e.g. public AbilityGeneratorForm previousForm;

                // Step 4 - Point this form to the parent form 
                // property in the next form
                orderForm.previousForm = this;

                // Step 5 - Show the next form
                orderForm.Show();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
