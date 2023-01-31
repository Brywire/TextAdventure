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

        // Put function
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
        public string Show()
        {
            string str = "";
            if (!IsEmpty())
            {
                foreach (string itemName in items.Keys)
                {
                    Item item = items[itemName];
                    str += " - " + itemName + ": " + item.Description + " (" + item.Weight + "kg)\n";
                }
            }
            return str;
        }

        //IsEmpty function for Show
        public bool IsEmpty()
        {
            return items.Count == 0;
        }

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

        // Get function
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
