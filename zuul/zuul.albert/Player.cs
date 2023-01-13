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

        }
}
