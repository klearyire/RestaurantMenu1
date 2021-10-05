using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Menu
    {
        
       
        public List<MenuItems> currentMenu { get; set; }

        private DateTime LastUpdated { get; }

        public Menu(bool newItem, List<MenuItems> menuItems)
        {
            menuItems = menuItems;
        }

        private void AddItem(MenuItems newItem)
        {
            newItem.NewItem = true;
            currentMenu.Add(newItem);
           
        }
        private void printItem()
        {
            Console.WriteLine("What item would you like to view?");
            int index = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{currentMenu[index].Price}: {currentMenu[index].ItemName}");
            Console.WriteLine($"{currentMenu[index].Description}");

        }
        private void removeItem()
        {
            printMenu();
            Console.WriteLine("What Item would you like to remove?");
            int index = Int32.Parse(Console.ReadLine());

            currentMenu.Remove(currentMenu[index]);

        }
        private void printMenu()
        {
            int index = 0;
            foreach( MenuItems item in currentMenu)
            {
                Console.WriteLine($"{index}: {item.ItemName}");
                index++;
            }
        }
        
    }
}
