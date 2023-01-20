using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Zuul
{
    public class Inventory
    {
        private int maxWeight;
        private Dictionary<string, Item> items;
        public Inventory(int m)
        {
            this.maxWeight = m;
            this.items = new Dictionary<string, Item>();
        }
        public bool Put(string itemName, Item item)
        {
            if (TotalWeight() + item.Weight > maxWeight)
            {
                return false;
            }
            items.Add(itemName, item);
            return true;
        }

        //Show function
        // - Checken of je inventory leeg is
        // - Checken welke items erin zitten 
        // - Lijst printen met /n

        //IsEmpty function for Show


        //Total Weight function
        public int TotalWeight()
        {
            int total = 0;
            foreach (string itemName in items.Keys)
            {
                total += items[itemName].Weight;
            }
            return total;
        }

        public Item Get(string itemName)
        {
            if (items.ContainsKey(itemName))
            {
                Item item = items[itemName];
                items.Remove(itemName);
                return item;
            }

            return null;
        }
    }
}
