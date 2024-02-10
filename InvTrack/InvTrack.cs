//Inventory Track (InvTrack)
//CSE 310 Class
//29 January 2024
//Christopher Slack

//This program is a basic Inventory Tracking system. With it you
//are able to Enter new products,change product details, and
//lookup(search) for product details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel; //for file read write

namespace InvTrack
{
    //Main Program
    class InvTrack
    {
        static List<Item> itemList = new List<Item>();
        static Item item = new Item();

        static void Main(string[] args)                                                             //Welcome Menu
        {
            //Welcoming the user to the Software
            Console.WriteLine("////////////////////////////////////////////////////////////////////////\n" +
                "//////////////////////////Welcome to InvTrack///////////////////////////\n" +
                "///////////////////////////////////////////////////////////////////////"!);
            
            //Actions Menu Sytem for selecting what to do
            bool close = true;
            while (close)
            {
                Console.WriteLine("\nWhat would you like to do?\n\n" +
                "1) Add item\n" +
                "2) Search item\n" +
                "3) Change item\n" +
                "4) Close\n");
                Console.Write("Please select the action you wish to preform:");

                int option = int.Parse(s:Console.ReadLine());

                if (option == 1)
                {
                    AddItem(); //Links to Program below
                }
                else if (option == 2)
                {
                    SearchProducts(); //Links to Program below
                }
                else if (option == 3)
                {
                    ChangeItem(); //Links to Program below
                }
                else if (option == 4)
                {
                    Console.WriteLine("Closing InvTrack");
                    close = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Please select a numbered option from the list above (1-4):");
                }
            }
        }

        //Adds an Item to the catelog of Parts                                                      Option 1
        public static void AddItem()
        {
            //Generagtes New Product Number, starting at 100k
            Item item = new Item();
            Console.WriteLine("Product Number:{0}", item.ProductNumber = itemList.Count + 1);
            
            //Gets New Product Name
            Console.Write("Product Name: ");
            item.ProductName = Console.ReadLine();

            //Gets New Product Manufacture Name
            Console.Write("Product Manufacturer Name: ");
            item.ManufactureName = Console.ReadLine();

            //Gets Purchase Cost
            Console.Write("Product Purchase Cost: $");
            item.cost = int.Parse(Console.ReadLine());

            //Gets Sale Price
            Console.Write("Product Sale Price: $");
            item.SalePrice = int.Parse(Console.ReadLine());

            // Need this to count the number of this product
            Console.Write("Amount of Product: ");
            item.NumberOfUnits = item.NumberOfUnits = int.Parse(Console.ReadLine());
            itemList.Add(item);
        }

        //Enables User  to search for a Product to find its details                                 Option 2
        public static void SearchProducts()
        {
            Item item = new Item();
            
            //Gets Product Number to look for
            Console.Write("Product Number to Search for: ");
            int NumberFind = int.Parse(Console.ReadLine());

            if (itemList.Exists(x => x.ProductNumber == NumberFind))
            {
                foreach (Item searchId in itemList)
                {
                    if (searchId.ProductNumber == NumberFind)
                    {
                        //Displays searched product details
                        Console.WriteLine("Product Number: {0}\n" +
                        "Product Name: {1}\n" +
                        "Manufacturer Name: {2}\n" +
                        "Product Cost: ${3}\n" +
                        "Product Sale Price: ${4}\n" +
                        "Amount of this Product: {5}", searchId.ProductNumber, searchId.ProductName, searchId.ManufactureName, searchId.cost, searchId.SalePrice, searchId.NumberOfUnits);
                    }
                }
            }
            else
            {
                Console.WriteLine("Error, Product Number NOT Found", NumberFind);
            }
        }

        //Enables changing of Product details                                                       Option 3
        public static void ChangeItem()
        {
            Item item = new Item();

            //Gets Product number to search for
            Console.Write("Product Number to Search for: ");
            int NumberFind = int.Parse(Console.ReadLine());

            if (itemList.Exists(x => x.ProductNumber == NumberFind))
            {
                foreach (Item searchId in itemList)
                {
                    if (searchId.ProductNumber == NumberFind)
                    {
                        Console.WriteLine("Product Number: {0}", searchId.ProductNumber);

                        //Gets New Product Name
                        Console.Write("Product Name: ");
                        searchId.ProductName = Console.ReadLine();

                        //Gets New Product Manufacture Name
                        Console.Write("Product Manufacturer Name: ");
                        searchId.ManufactureName = Console.ReadLine();

                        //Gets Purchase Cost
                        Console.Write("Product Purchase Cost: $");
                        searchId.cost = int.Parse(Console.ReadLine());

                        //Gets Sale Price
                        Console.Write("Product Sale Price: $");
                        searchId.SalePrice = int.Parse(Console.ReadLine());

                        // Need this to count the number of this product
                        Console.Write("Amount of Product: ");
                        searchId.NumberOfUnits = item.NumberOfUnits = int.Parse(Console.ReadLine());
                    }
                }
            }
            else
            {
                Console.WriteLine("Error, Product Number NOT Found", NumberFind);
            }
        }
    }
}