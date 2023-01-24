using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Zuul;

namespace Zuul
{
    internal class Player
    {
        //Field
        private int health;

        //Property
        public Room CurrentRoom { get; set; }
        public Inventory Backpack { get; }
        public int Health
        {
            get { return health; }
        }

        //Constructor
        public Player()
        {
            CurrentRoom = null;
            health = 100;
        }

        //Methods
        public void Damage(int amount)
        {
            health = health - amount;
        }

        public void Heal(int amount)
        {
            health = health + amount;
        }

        public bool IsAlive()
        {
            return (health > 0);
        }

        // Take from chest function
        public bool TakeFromChest(string itemName)
        {
            Item item = CurrentRoom.Chest.Get(itemName);
            if (item == null) 
            {
                Console.WriteLine("There is no " + itemName + "in this room");
                return false;
            }

            if(Backpack.Put(itemName, item))
            {
                return true;
            }

            Console.WriteLine("You are unable to carry " + itemName);
            CurrentRoom.Chest.Put(itemName, item);
            return true;
        }
        
        // Drop to chest function
        public bool DropToChest(string itemName)
        {
            Item item = CurrentRoom.Chest.Get(itemName);
            if (item == null)
            {
                Console.WriteLine("You don't have " + itemName +  ".");
                return false;
            }

            Console.WriteLine("You've dropped " + itemName + ".");
            CurrentRoom.Chest.Put(itemName, item);
            return true;
        }
    }
}
