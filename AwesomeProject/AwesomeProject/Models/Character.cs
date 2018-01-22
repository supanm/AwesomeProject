using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeProject.Models
{
    // Class for type Character. Inherits the following properties from Being: 
    //   - Stats (type Attributes)
    //   - Position (type Coordinates)

    public class Character : Being
    {
        // Character's personal name.
        public string Name { get; private set; }

        // Dictionary of inventory slots, one for each enumerated location. 
        public Dictionary<Locations, Item> Inventory { get; private set; }

  
        // Default constructor.
        public Character() : base()
        {
            // Create the inventory dictionary.
            Inventory = new Dictionary<Locations, Item>();
        }


        // Adds specified item to specified slot, updates the characters stats 
        // for any buffs, and returns any old item from that slot that's being 
        // dropped.  (Assumes, but does not verify, that item fits in slot.)
        public Item GetItem(Item item, Locations slot)
        {
            // Does this slot currently hold an existing item? If so, drop it.
            Item oldItem = DropItem(slot);

            // Add the existing item to the slot.
            Inventory[slot] = item;

            // Add any buff to the character's stats.
            switch(item.BuffType)
            {
                case Item.Buff.Attack:
                    this.Stats.Attack += item.BuffValue;
                    break;

                case Item.Buff.Defense:
                    this.Stats.Defense += item.BuffValue;
                    break;

                default:
                    break;
            }

            // Return any dropped item.
            return oldItem;
        }


        // Removes any item from the specified slot, updates the character's 
        // stats for any removed buffs, and returns the dropped item.
        public Item DropItem(Locations slot)
        {
            // Get the existing item (if any) that's being dropped from slot.
            Item oldItem = null;
            if (Inventory.TryGetValue(slot, out oldItem))
            {
                // Drop the item from the inventory.
                Inventory[slot] = null;

                // Update the character's stats based on any removed buffs.
                switch (oldItem.BuffType)
                {
                    case Item.Buff.Attack:
                        this.Stats.Attack -= oldItem.BuffValue;
                        break;

                    case Item.Buff.Defense:
                        this.Stats.Defense -= oldItem.BuffValue;
                        break;

                    default:
                        break;
                }
            }

            // Return any dropped item.
            return oldItem;
        }


        // Add experience to the character and level up if appropriate.
        public void AddExperience(int xp)
        {
            // Get the current amount of experience.
            int oldXp = this.Stats.XP;

            // Increment the amount of experience by the specified amount.
            this.Stats.XP += xp;

            // Level up character if appropriate based on old/new experience.
            throw new NotImplementedException();
        }


        // Compares current XP to last XP and levels up if appropriate.
        public void LevelUp(int oldXP)
        {
            // Check if oldXP corresponds to a lower level than current XP.

            // If so, update the level and increment the relevant attributes.
            throw new NotImplementedException();
        }

    }
}