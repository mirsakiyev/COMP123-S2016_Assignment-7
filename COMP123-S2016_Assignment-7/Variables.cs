using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Assignment_7
{
    public class Variables
    {
        public decimal[] cost = new decimal[]
        { 0.99m, 1.99m, 2.99m, 4.99m };

        public string[] categories = new string[]
        {"Comedy", "Drama", "Action", "Sci-Fi", "Horror", "Thriller", "Family", "New Release"};

        public string userSelectionTitle { get; set; }

        public string userSelectionCategory { get; set; }

        public string userSelectionCost { get; set; }
    }
}
