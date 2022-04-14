using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static List<File> selectedItems = new List<File>();


        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

            //exit  - entry and exit should be the same point 
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the catalog!");
            Console.WriteLine("Press 1 to shop by category");
            Console.WriteLine("Press 2 to Submit order");
            Console.WriteLine("Press 3 to Cancel order");
            Console.WriteLine("Press 4 to Exit the catalog");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    bool ShowCategoriesMenu = true;
                    while (ShowCategoriesMenu)
                    {
                        ShowCategoriesMenu = ShowCategories();
                    }
                    //add a loop here as main menu loop
                    //ShowCategories();
                    return true;
                case "2":
                    SubmitOrder();
                    return false;
                case "3":
                    CancelOrder();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }

        public static bool ShowCategories()
        {
            Console.Clear();
            Console.WriteLine("Categories: \r\n1. Music \r\n2. Films \r\n3. Apps\r\n4. Return to Main menu\r\n");
            Console.WriteLine("Select a category (enter its number):");
            var catalogItem = new CatalogItems();

            bool showCategories = false;
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    catalogItem.ShowMusicFiles();
                    SelectItem(catalogItem.musicArray);
                    showCategories = true;
                        break;
                case "2":
                    Console.Clear();
                    catalogItem.ShowFilms();
                    SelectItem(catalogItem.filmArray);
                    break;
                case "3":
                    Console.Clear();
                    catalogItem.ShowApps();
                    SelectItem(catalogItem.appsArray);
                    break;
                case "4":
                    Console.Clear();

                    //
                    MainMenu();
                    break;
            }

            // TODO: return bool
            //return Console.ReadLine();
            return showCategories;
        }

        public static void SelectItem(File[] array)
        {
            Console.WriteLine("Enter the item number to add it to cart of press anything else to return to the previous menu");
            var userchoice = Convert.ToInt32(Console.ReadLine());
            if (userchoice > array.Length)
                return;
            selectedItems.Add(array[userchoice - 1]);
            Console.WriteLine("The item successfully added to your cart! Press Enter to go back to categories.");
            Console.ReadKey();
            //ShowCategories();

        }

        public static void SubmitOrder()
        {
            Console.Clear();
            if (selectedItems.Count > 0)
            {
                Console.WriteLine("Your cart:");
                foreach (var item in selectedItems)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Press any button to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }


            else
            {
                Console.WriteLine("There are no items in the cart");
                Console.WriteLine("Press any button to exit the catalog");
                Console.ReadKey();
            }
        }

        public static void CancelOrder()
        {
            Console.Clear();
            selectedItems.Clear();
            Console.WriteLine($"Empty cart. {selectedItems.Count()} items in the cart");
            Console.WriteLine("Press any button to exit the catalog");
            Console.ReadKey();
        }
    }
}
