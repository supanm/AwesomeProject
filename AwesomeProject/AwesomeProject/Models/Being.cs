using System;
using System.Collections.Generic;

namespace AwesomeProject.Models
{
    // Base class for both Characters and Monsters. Implements IComparable to
    // sort beings based on their initiative.
    public abstract class Being : IComparable<Being>
    {
        // This being's associated statistics.
        public Statistics Stats { get; set; }

        // This Being's current position.
        public Coordinates Position { get; set; } 

        // Default constructor.
        public Being()
        {
            // Nothing for now.
        }

        // Returns true if this Being is still alive.
        public bool IsAlive()
        {
            return (Stats.HealthCurr > 0);
        }

        // Implements the IComparable interface to determine the sort order
        // of Beings based on their level of initiative. This allows us to sort
        // 
        // and sort an "attack queue" by initiative. (Alternatively, this code 
        // could be implemented as an IComparer in the Controller.)
        public int CompareTo(Being other)
        {
            // If one character is dead, sort based on "is alive."
            if (IsAlive() != other.IsAlive())
            {
                return IsAlive().CompareTo(other.IsAlive());
            }

            // Else, sort based on greater speed.
            if (Stats.Speed != other.Stats.Speed)
            {
                return Stats.Speed.CompareTo(other.Stats.Speed);
            }

            // Else, sort based on higher level.
            if (Stats.Level != other.Stats.Level)
            {
                return Stats.Level.CompareTo(other.Stats.Level);
            }

            // Else, sort based on higher XP.
            if (Stats.XP != other.Stats.XP)
            {
                return Stats.XP.CompareTo(other.Stats.XP);
            }

            // Else, check if one is Character type and other is Monster type.
            if (GetType() != other.GetType())
            {
                // Sort based on Characters over Monsters.
                return (GetType() == typeof(Character)) ? 1 : -1;
            }
            
            // Else, sort based on alpha of Being type (i.e., the name of each class).
            if (GetType() == typeof(Character) && other.GetType() == typeof(Character))
            {
                return Stats.ClassName.CompareTo(other.Stats.ClassName);
            }

            // TODO: Else, sort based on numeric order. 
            throw new NotImplementedException();
        }
        
    }

}
