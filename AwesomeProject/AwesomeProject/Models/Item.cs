using System;

namespace AwesomeProject.Models
{
    // Class to represent each item.
    public class Item
    {
        // Enumeration to track each type of buff.
        public enum Buff { Attack, Defense, Damage };

        // This item' name (e.g., "Ring of Blocking").
        public string Name { get; set; }

        // This item's body location (e.g., "Finger").
        Locations Location { get; set; }

        // This item's buff (e.g., "Defense +5").
        public Buff BuffType  { get; set; }
        public int  BuffValue { get; set; }        
    }
}