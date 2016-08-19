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

                Variables variables = new Variables();
                
                if (value == "Season of the Witch")
                {
                    CategoryTextBox.Text = variables.categories[3];
                    CostTextBox.Text = "$" + variables.cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.seasonofthewitch);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory= variables.categories[3];
                    variables.userSelectionCost= variables.cost[2].ToString();

                }

                if (value == "The Green Hornet")
                {
                    CategoryTextBox.Text = variables.categories[2];
                    CostTextBox.Text = "$" + variables.cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thegreenhornet);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[2];
                    variables.userSelectionCost = variables.cost[2].ToString();


                }

                if (value == "The Dilemma")
                {
                    CategoryTextBox.Text = variables.categories[0];
                    CostTextBox.Text = "$" + variables.cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thedilemma);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[0];
                    variables.userSelectionCost = variables.cost[1].ToString();
                }

                if (value == "Death Race 2")
                {
                    CategoryTextBox.Text = variables.categories[2];
                    CostTextBox.Text = "$" + variables.cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.deathrace2);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[2];
                    variables.userSelectionCost = variables.cost[2].ToString();
                }

                if (value == "Company Men")
                {
                    CategoryTextBox.Text = variables.categories[1];
                    CostTextBox.Text = "$" + variables.cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.companymen);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[1];
                    variables.userSelectionCost = variables.cost[1].ToString();
                }

                if (value == "No Strings Attached")
                {
                    CategoryTextBox.Text = variables.categories[0];
                    CostTextBox.Text = "$" + variables.cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.nostringsattached);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[0];
                    variables.userSelectionCost = variables.cost[1].ToString();
                }

                if (value == "The Way Back")
                {
                    CategoryTextBox.Text = variables.categories[1];
                    CostTextBox.Text = "$" + variables.cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thewayback);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[1]; ;
                    variables.userSelectionCost = variables.cost[1].ToString();
                }

                if (value == "The Mechanic")
                {
                    CategoryTextBox.Text = variables.categories[2];
                    CostTextBox.Text = "$" + variables.cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.themechanic);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[2];
                    variables.userSelectionCost = variables.cost[2].ToString();
                }

                if (value == "The Rite")
                {
                    CategoryTextBox.Text = variables.categories[4];
                    CostTextBox.Text = "$" + variables.cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.therite);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[4];
                    variables.userSelectionCost = variables.cost[2].ToString();
                }

                if (value == "Sanctum")
                {
                    CategoryTextBox.Text = variables.categories[2];
                    CostTextBox.Text = "$" + variables.cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.sanctum);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[2];
                    variables.userSelectionCost = variables.cost[2].ToString();
                }

                if (value == "The Other Woman")
                {
                    CategoryTextBox.Text = variables.categories[2];
                    CostTextBox.Text = "$" + variables.cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.theotherwoman);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[2];
                    variables.userSelectionCost = variables.cost[2].ToString();
                }

                if (value == "The Roommate")
                {
                    CategoryTextBox.Text = variables.categories[5];
                    CostTextBox.Text = "$" + variables.cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.theroommate);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[5];
                    variables.userSelectionCost = variables.cost[1].ToString();
                }

                if (value == "Waiting for Forever")
                {
                    CategoryTextBox.Text = variables.categories[1];
                    CostTextBox.Text = "$" + variables.cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.waitingforever);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[1];
                    variables.userSelectionCost = variables.cost[1].ToString();
                }

                if (value == "Cedar Rapids")
                {
                    CategoryTextBox.Text = variables.categories[0];
                    CostTextBox.Text = "$" + variables.cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.cedarrapids);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[0];
                    variables.userSelectionCost = variables.cost[1].ToString();
                }

                if (value == "Gnomeo and Juliet")
                {
                    CategoryTextBox.Text = variables.categories[6];
                    CostTextBox.Text = "$" + variables.cost[0].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.gnomeoandjuliet);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[6];
                    variables.userSelectionCost = variables.cost[0].ToString();
                }

                if (value == "Just Go With It")
                {
                    CategoryTextBox.Text = variables.categories[0];
                    CostTextBox.Text = "$" + variables.cost[1].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.justgowithit);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[0];
                    variables.userSelectionCost = variables.cost[1].ToString();
                }

                if (value == "The Eagle")
                {
                    CategoryTextBox.Text = variables.categories[2];
                    CostTextBox.Text = "$" + variables.cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.theeagle);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[2];
                    variables.userSelectionCost = variables.cost[2].ToString();
                }

                if (value == "I am Number Four")
                {
                    CategoryTextBox.Text = variables.categories[3];
                    CostTextBox.Text = "$" + variables.cost[2].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.iamnumberfour);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[3];
                    variables.userSelectionCost = variables.cost[2].ToString();
                }

                if (value == "Footloose")
                {
                    CategoryTextBox.Text = variables.categories[7];
                    CostTextBox.Text = "$" + variables.cost[3].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.footloose);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[7];
                    variables.userSelectionCost = variables.cost[3].ToString();
                }

                if (value == "Real Steel")
                {
                    CategoryTextBox.Text = variables.categories[7];
                    CostTextBox.Text = "$" + variables.cost[3].ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.realsteel);
                    variables.userSelectionTitle = value;
                    variables.userSelectionCategory = variables.categories[7];
                    variables.userSelectionCost = variables.cost[3].ToString();
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
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
            //orderForm.previousForm = this;

            // Step 5 - Show the next form
            orderForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
