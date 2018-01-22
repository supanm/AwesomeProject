using System;
using System.Collections.Generic;

namespace AwesomeProject.Models
{
    public class Being : IComparable<Being>
    {

        // This Being's current set of stats.
        public Attributes Stats { get; private set; }

        // This Being's current position.
        public Coordinates Position { get; private set; } 


        // Default constructor.
        public Being()
        {
            // Instantiate this being's set of stats.
            Stats = new Attributes();
        }


        // Models an attack on another Being. Returns amount of damage done (if any).
        public int DoAttack(Being other)
        {
            // Roll dice for "hit or miss."

            // If "hit," calculate and subtract the damage from the victim's health.

            // If the victim is dead, drop the victim's items.

            // Award experience to the attacker and level up if appropriate.

            // Return the total amount of damage.

            throw new NotImplementedException();
        }

        // Returns true if this Being is still alive.
        public bool IsLiving()
        {
            return (Stats.HealthCurr > 0);
        }

        // Implements the IComparable interface to determine the sort order
        // based on each being's initiative level.
        public int CompareTo(Being other)
        {
            // If only one being is living, that one wins.

            // If either Being has greater speed, that one wins.

            // Otherwise, sort based on:
            // Level, xp, "character vs. monster," alpha, then numeric.

            throw new NotImplementedException();
        }
        
        // Attempts to move to the specified location; returns "true" on success.
        public bool MoveTo(int x, int y)
        {
            throw new NotImplementedException();
        }
    }


    // ------------------------------------------------------------------------

    // Class for type Character (derived from Being).
    public class Character : Being
    {
        // Character's personal name.
        public string Name { get; private set; }

        // Backing array of inventory slots, one for each enumerated location. 
        // E.g., Items[3] represents "item in LeftHand."
        public Item[] Inventory { get; private set; }


        // Default constructor.
        public Character() : base()
        {
            // Get the number of slots as a sanity check. (Should be seven.)
            int numLocations = Enum.GetNames(typeof(Locations)).Length;

            // Create the inventory backing array with one item per slot.
            Inventory = new Item[numLocations];
        }


        // Assigns an item to the character's specified inventory slot.
        public Item GetItem(Item item, Locations slot)
        {
            // Validate that the item can "fit" in the slot (e.g., not "sword -> feet").

            // Test whether the specified slot is currently holding an item. 
            // If so, pick the "best" item to wear and drop the other item.
            // If not, just put the item in the inventory slot.

            // Update the character's stats to add any buffs from the new item.

            // If we're dropping an item, return that item to caller, else return null.

            throw new NotImplementedException();
        }


        // Removes a character's inventory item and returns that item to the caller.
        public Item DropItem(Item item)
        {
            // Validate that the specified item is contained in the inventory.

            // Update the character's stats to remove any buff from this item.

            // Remove the specified item from the inventory and return it to caller.

            throw new NotImplementedException();
        }


        // Adds experience to the character and levels up if appropriate.
        public void AddExperience(int xp)
        {
            // Increment the amount of experience by the specified amount.

            // Level up character if appropriate.

            throw new NotImplementedException();
        }

    }


    // ------------------------------------------------------------------------

    public class Monster
    {
        // A list of each item held by this monster.
        public List<Item> Items { get; }

        // The unique item drop for this monster (if any).
        public Item UniqueDrop { get; }

        // Default constructor
        public Monster() : base()
        {
            Items = new List<Item>();
            UniqueDrop = null;
        }
    }
}
