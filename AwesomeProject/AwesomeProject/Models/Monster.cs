using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeProject.Models
{
    // Class for type Monster (subclass of Being).
    public class Monster : Being
    {
        // A list of each item held by this monster.
        public List<Item> Items { get; set; }

        // The unique item drop for this monster (if any).
        public Item UniqueDrop { get; set; }

        // Default constructor.
        public Monster() : base()
        {
            Items = new List<Item>();
        }
    }
}
