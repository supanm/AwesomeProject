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

        // Default constructor.
        public Character() : base()
        {
            Items = new Inventory();
        }

        // Add experience to the character and level up if appropriate.
        public void AddExperience(int xp)
        {
            // Get the current amount of experience.
            int oldXp = this.XP;

            // Increment the amount of experience by the specified amount.
            this.XP += xp;

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