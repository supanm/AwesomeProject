using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeProject.Models
{
    // Class to represent the contents of each character's inventory slots.
    public class Inventory
    {
        public Item Head        { get; set; }
        public Item Body        { get; set; }
        public Item Feet        { get; set; }
        public Item LeftHand    { get; set; }
        public Item RightHand   { get; set; }
        public Item LeftFinger  { get; set; }
        public Item RightFinger { get; set; }
    }
}
