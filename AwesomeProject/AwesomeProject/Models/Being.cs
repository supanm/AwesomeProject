using System;
using System.Collections.Generic;

namespace AwesomeProject.Models
{
    // Base class for both Characters and Monsters. Implements IComparable to
    // sort beings based on their initiative.
    public abstract class Being : IComparable<Being>
    {
        // The default attributes shared by Monsters and Characters.
        public int    Attack     { get; set; }
        public string ClassName  { get; set; }
        public int    Defense    { get; set; }
        public int    HealthCurr { get; set; }
        public int    HealthMax  { get; set; }
        public int    Level      { get; set; }
        public int    Speed      { get; set; }
        public int    XP         { get; set; }

        // This Being's current position.
        public Coordinates Position { get; set; } 


        // Default constructor.
        public Being()
        {
            // Nothing for now.
        }


        // Moves this Being to the specified coordinate pair.
        public void MoveTo(Coordinates position)
        {
            Position = position;
        }


        // Returns true if this Being is still alive.
        public bool IsAlive()
        {
            return (HealthCurr > 0);
        }

        // Implements the IComparable interface to determine the sort order
        // of Beings based on their level of initiative. This way, we can build
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
            if (Speed != other.Speed)
            {
                return Speed.CompareTo(other.Speed);
            }

            // Else, sort based on higher level.
            if (Level != other.Level)
            {
                return Level.CompareTo(other.Level);
            }

            // Else, sort based on higher XP.
            if (XP != other.XP)
            {
                return XP.CompareTo(other.XP);
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
                return ClassName.CompareTo(other.ClassName);
            }

            // TODO: Else, sort based on numeric order. 
            throw new NotImplementedException();
        }
        
    }

}
