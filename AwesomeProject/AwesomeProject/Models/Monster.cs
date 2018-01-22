using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeProject.Models
{

    // Class for type Monster. Inherits the following properties from Being:
    //   - Stats (type Attributes)
    //   - Position (type Coordinates)
    public class Monster : Being
    {
        // A list of each item held by this monster.
        public List<Item> Items { get; }

        // The unique item drop for this monster (if any).
        public Item UniqueDrop { get; }

        // Default constructor.
        public Monster() : base()
        {
            Items = new List<Item>();
            UniqueDrop = null;
        }
    }
}
