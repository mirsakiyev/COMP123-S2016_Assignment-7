using System;
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
    public partial class OrderForm : Form
    {
        public SelectionForm previousForm;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

            Variables variables = Program.variables;
            TitleTextBox.Text = variables.userSelectionTitle;
            CategoryTextBox.Text = variables.userSelectionCategory;
            CostTextBox.Text = "$"+variables.userSelectionCost;

            if (TitleTextBox.Text == "Season of the Witch")
            {                
                MoviePictureBox.Image = new Bitmap(Properties.Resources.seasonofthewitch);                
            }

            if (TitleTextBox.Text == "The Green Hornet")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.thegreenhornet);
            }

            if (TitleTextBox.Text == "The Dilemma")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.thedilemma);
            }
            if (TitleTextBox.Text == "Death Race 2")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.deathrace2);
            }
            if (TitleTextBox.Text == "Company Men")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.companymen);
            }
            if (TitleTextBox.Text == "No Strings Attached")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.nostringsattached);
            }
            if (TitleTextBox.Text == "The Way Back")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.thewayback);
            }
            if (TitleTextBox.Text == "The Mechanic")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.themechanic);
            }
            if (TitleTextBox.Text == "The Rite")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.therite);
            }
            if (TitleTextBox.Text == "Sanctum")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.sanctum);
            }
            if (TitleTextBox.Text == "The Other Woman")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.theotherwoman);
            }
            if (TitleTextBox.Text == "The Roommate")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.theroommate);
            }
            if (TitleTextBox.Text == "Waiting for Forever")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.waitingforever);
            }
            if (TitleTextBox.Text == "Cedar Rapids")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.cedarrapids);
            }
            if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.gnomeoandjuliet);
            }
            if (TitleTextBox.Text == "Just Go With It")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.justgowithit);
            }
            if (TitleTextBox.Text == "The Eagle")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.theeagle);
            }
            if (TitleTextBox.Text == "I am Number Four")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.iamnumberfour);
            }
            if (TitleTextBox.Text == "Footloose")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.footloose);
            }
            if (TitleTextBox.Text == "Real Steel")
            {
                MoviePictureBox.Image = new Bitmap(Properties.Resources.realsteel);
            }

            double subTotal=0;           
            double tax =13.00;
            double grandTotal = 0;


            try
            {
                double userCost = Convert.ToDouble(variables.userSelectionCost);
                tax = (userCost / 100) * tax;
                grandTotal = userCost + tax;
                variables.userFinalCost = grandTotal;
            }
            catch (Exception)
            {

                throw;
            }

            variables.userFinalCost = grandTotal;

            variables.userSubTotalCost = Convert.ToDouble(variables.userSelectionCost);

            SubTotalTextBox.Text = "$"+variables.userSelectionCost;
            TaxTextBox.Text = "$"+tax.ToString();
            GrandTotalTextBox.Text = "$" + grandTotal.ToString();


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - Instantiate an object of the About Box form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - Use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {           
            // Step 1 - Show the parent form
            this.previousForm.Show();

            // Step 2 - Close this form
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderDvdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Variables variables = Program.variables;
         
            if (OrderDvdCheckBox.Checked == true)
                {
                OrderDvdTextBox.Enabled = true;
                OrderDvdLabel.Enabled = true;
                OrderDvdTextBox.Text = "$10.00";

                variables.userSubTotalCost = variables.userSubTotalCost + 10.00;
               

                variables.userFinalCost =variables.userFinalCost+10.00;
                variables.userTax = (variables.userFinalCost / 100) * 13.00;


                GrandTotalTextBox.Clear();
                SubTotalTextBox.Clear();
                TaxTextBox.Clear();

             
                GrandTotalTextBox.Text ="$"+ variables.userFinalCost.ToString();
                SubTotalTextBox.Text = "$" + variables.userSubTotalCost.ToString();
                TaxTextBox.Text = "$" + variables.userTax.ToString();


            }
            if (OrderDvdCheckBox.Checked == false)
            {
                OrderDvdTextBox.Enabled = false;
                OrderDvdLabel.Enabled = false;
                variables.userSubTotalCost = variables.userSubTotalCost - 10.00;
                variables.userFinalCost = variables.userFinalCost - 10.00;
                OrderDvdTextBox.Text = "";
                
                variables.userFinalCost = variables.userFinalCost;
                variables.userTax = (variables.userFinalCost / 100) * 13.00;

                GrandTotalTextBox.Clear();
                SubTotalTextBox.Clear();
                TaxTextBox.Clear();

                SubTotalTextBox.Text = "$" + variables.userSubTotalCost.ToString();
                GrandTotalTextBox.Text = "$" + variables.userFinalCost.ToString();
                TaxTextBox.Text = "$" + variables.userTax.ToString();
            }
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1 - Hide the parent form
                this.Hide();

                // Step - 2 Instantiate an object for the form type
                // you are going to next
                StreamForm streamForm = new StreamForm();

                // Step - 3 Create a property in the next form that 
                // we will use to piont to this form
                // e.g. public AbilityGeneratorForm previousForm;

                // Step 4 - Point this form to the parent form 
                // property in the next form
                streamForm.previousForm = this;

                // Step 5 - Show the next form
                streamForm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
