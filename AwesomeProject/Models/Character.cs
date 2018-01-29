using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeProject.Models
{
    // Class for type Character (subclass of Being).
    public class Character : Being
    {
        // Character's personal name.
        public string Name { get; set; }

        // Character's inventory slots;
        public Inventory Items { get; set; }

        //Stats of each monster
        public Statistics CharacterStats { get; set; }

        // Default constructor.
        public Character() : base()
        {
            //Instantiate the character's name
            Name = new Character().Name;
            //Instantiate the items in the inventory
            Items = new Inventory();

        }

        // Add experience to the character and level up if appropriate.
        public void AddExperience(int xp)
        {
            // Get the current amount of experience.
            int oldXp = this.Stats.XP;

            // Increment the amount of experience by the specified amount.
            this.Stats.XP += xp;

            // Level up character if appropriate based on old/new experience.
            LevelUp(oldXp);
        }

        // Compares current XP to last XP and levels up if appropriate.
        public void LevelUp(int oldXp)
        {
            // Check if oldXP corresponds to a lower level than current XP.

            // If so, update the level and increment the relevant attributes.
            throw new NotImplementedException();
        }

    }
}