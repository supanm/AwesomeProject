using System;
using System.Collections.Generic;

namespace AwesomeProject.Models
{
    public class Being : IComparable<Being>
    {

        // Internal class to represent each Being's set of stats. 
        public class Attributes
        {
            public int    Attack     { get; set; }
            public string Class      { get; set; }
            public int    Defense    { get; set; }
            public int    HealthCurr { get; set; }
            public int    HealthMax  { get; set; }
            public int    Level      { get; set; }
            public int    Speed      { get; set; }
            public int    XP         { get; set; }
        }

        // This Being's current instance of stats.
        public Attributes Stats { get; private set; }

        // This Being's current position.
        public Coordinates Position { get; private set; } 


        // Default constructor.
        public Being()
        {
            // Instantiate this being's set of stats.
            Stats = new Attributes();
        }


        // Moves this Being to the specified coordinate pair.
        public void MoveTo(Coordinates position)
        {
            this.Position = position;
        }


        // Attacks another Being and returns amount of damage done (if any).
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
        public bool IsAlive()
        {
            return (Stats.HealthCurr > 0);
        }


        // Implements the IComparable interface to determine the sort order
        // of Beings based on their level of initiative. This way, we can build
        // an "attack queue" and sort it based on descending initiative.
        public int CompareTo(Being other)
        {
            // If one character is dead, sort based on "is alive."
            if (this.IsAlive() != other.IsAlive())
            {
                return this.IsAlive().CompareTo(other.IsAlive());
            }

            // Else, sort based on greater speed.
            if (this.Stats.Speed != other.Stats.Speed)
            {
                return this.Stats.Speed.CompareTo(other.Stats.Speed);
            }

            // Else, sort based on higher level.
            if (this.Stats.Level != other.Stats.Level)
            {
                return this.Stats.Level.CompareTo(other.Stats.Level);
            }

            // Else, sort based on higher XP.
            if (this.Stats.XP != other.Stats.XP)
            {
                return this.Stats.XP.CompareTo(other.Stats.XP);
            }

            // Else, sort based on characters over monsters.
            if (this.GetType() != other.GetType())
            {
                return (this.GetType() == typeof(Character)) ? 1 : -1;
            }
            
            // Else, sort based on alpha of Being type (i.e., the name of each class).
            if (this.GetType() == typeof(Character) && other.GetType() == typeof(Character))
            {
                return this.Stats.Class.CompareTo(other.Stats.Class);
            }

            // TODO: Else, sort based on numeric order. 
            throw new NotImplementedException();
        }
        
    }

}
