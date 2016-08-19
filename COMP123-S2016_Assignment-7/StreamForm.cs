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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }
        public OrderForm previousForm;

        private void StreamForm_Load(object sender, EventArgs e)
        {
            Variables variables = Program.variables;
            FinalLabel.Text = "Thank you for choosing Movie Bonanaza\nYour Credit card will be charged  $"
                +variables.userFinalCost+"\n"+"'"+variables.userSelectionTitle+ "'" + " will begin shortly";           
        }
    }
}
