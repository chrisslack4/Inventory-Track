//Inventory Track -- Item Class
//CSE 310 Class
//29 January 2024
//Christopher Slack

//This is just a creation of a class to define an item as
//having a Name, Number, Manufacturer Name, Cost to buy,
//Sale Price, and the Number of Units on hand.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvTrack
{
    //Creating Item class with various aspects
    internal class Item
    {
        public string ProductName;
        public string ManufactureName;
        public int ProductNumber;
        public int cost;
        public int SalePrice;
        public int NumberOfUnits;
    }
}
