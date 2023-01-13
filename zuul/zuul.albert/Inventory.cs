using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
            this.items = new Dictionary<string, Item> ();
        }
        public bool Put(string itemName, Item item)
        {
            // check the Weight of the Item!
            // put Item in the items Collection
            // return true/false for success/failure
            return false;
        }
        public Item Get(string itemName)
        {
            // find Item in items Collection
            // remove Item from items Collection if found
            // return Item
            return null;
        }
    }
}
