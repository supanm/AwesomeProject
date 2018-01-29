using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeProject.Models
{
    // Class for type Monster (subclass of Being).
    public class Monster : Being
    {
        //Name of the monster
        public string Name { get; set; }

        // A list of each item held by this monster.
        public List<Item> Items { get; set; }

        //Stats of each monster
        public Statistics MonsterStats { get; set; }

        // The unique item drop for this monster (if any).
        public Item UniqueDrop { get; set; }

        //ExpToGive is the starting value of experience a monster may give based upon it's current level
        public int ExpToGive { get; set; }

        // Default constructor for the monster
        public Monster() : base()
        {
            //Instantiate the monster's name
            Name = new Monster().Name;
            //Items the monster has in its inventory
            Items = new List<Item>();
        }
        //Method to determine how much experience 
        public int CalcExpToGive()
        {
            //INCOMPLETE CALCULATION; this will assign the value to ExpToGive
            ExpToGive = MonsterStats.XP;
            //Return the max value of experience the monster may give
            return ExpToGive;
        }

    }
}
