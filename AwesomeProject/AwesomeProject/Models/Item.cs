using System;

namespace AwesomeProject.Models
{
    // Class to represent each item.
    public class Item
    {
        // Enumeration to track each type of buff.
        public enum Buff { Health, Attack, Defense, Speed };

        // This item's name, location and buff.
        public string    Name      { get; set; }
        public Locations Location  { get; set; }
        public Buff      BuffType  { get; set; }
        public int       BuffValue { get; set; }
    }
}