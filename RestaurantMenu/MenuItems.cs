using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class MenuItems
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public bool NewItem { get; set; }

        public MenuItems(string itemName, string description, double price, string category, bool NewItem)
        {
            ItemName = itemName;
            Description = description;
            Price = price;
            Category = category;
        }
        public bool Equals(MenuItems item)
        {
            return this.ItemName == item.ItemName;
        }

    }
}
