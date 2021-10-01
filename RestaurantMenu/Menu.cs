using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Menu
    {

        private bool NewItem { get; set; }
        private List<MenuItems> MenuItems { get; set; }

        private DateTime Date1 = new DateTime();

        public Menu(bool newItem, List<MenuItems> menuItems, DateTime date1)
        {
            NewItem = newItem;
            MenuItems = menuItems;
            Date1 = date1;
        }
    }
}
