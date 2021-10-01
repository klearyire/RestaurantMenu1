using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class MenuItems
    {
        private string ItemName { get; set; }
        private string Description { get; set; }
        private double Price { get; set; }
        private string Category { get; set; }

        public MenuItems(string itemName, string description, double price, string category)
        {
            ItemName = itemName;
            Description = description;
            Price = price;
            Category = category;
        }
    }
}
