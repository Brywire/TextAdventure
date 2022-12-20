//Made by Albert Buitenhuis

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DictionaryVoornaam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Documentation: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0

            Dictionary<string, Item> itemDictionary = new Dictionary<string, Item>();

            itemDictionary.Add("hammer", new Item("A heavy hammer"));
            itemDictionary.Add("axe", new Item("A sharp axe"));
            itemDictionary.Add("potion", new Item("A bottle labeled 'drink me'"));
            itemDictionary.Add("medkit", new Item("A medkit"));

            // Voeg een Item toe (Add) met de Key "pill" en description "A bitter pill to swallow"
            itemDictionary.Add("pill", new Item("A bitter pill to swallow"));

            // Verwijder (Remove) de entry "medkit" uit de dictionary
            itemDictionary.Remove("medkit");

            // Bewijs met behulp van code dat er een entry is met de Key "potion". Laat de description zien van dat Item.

            if (itemDictionary.ContainsKey("potion"))
            {
                Console.WriteLine("Potion description: " + itemDictionary["potion"].Description);
            }
            // Is er een Item "nailgun"? Zo ja, wat is de description? Zo nee, zeg beleefd dat je het Item niet kunt vinden.
            Console.WriteLine("\nDo you have a nailgun?");
            if (itemDictionary.ContainsKey("nailgun"))
            {
                Console.WriteLine(itemDictionary["nailgun"].Description);
            }
            else
            {
                Console.WriteLine("You don't have this item");
            }

            // Laat zien hoeveel Items de itemDictionary bevat (gebruik Count)
            Console.WriteLine("\nCurrent amount of items: ");
            Console.WriteLine(itemDictionary.Count + "\n");

            // Console.WriteLine alle items. Laat zowel de Key zien, als de description van elk Item (Value).
            foreach (KeyValuePair<string, Item> Item in itemDictionary)
            {
                Console.WriteLine("Key = {0}, Description: {1}", Item.Key, Item.Value.Description);
            }

            // Maak de volledige Dictionary leeg (Clear)
            itemDictionary.Clear();
            Console.WriteLine("\nItems Cleared");

            // Laat nogmaals zien hoeveel Items de itemDictionary bevat (gebruik Count)
            Console.WriteLine("\nCurrent amount of items: ");
            Console.WriteLine(itemDictionary.Count);

        }
    }
}
