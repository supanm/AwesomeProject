using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeProject.Models
{
    // Struct that represents an immutable pair of x/y coordinates.
    public struct Coordinates
    {
        public int XPos { get; }
        public int YPos { get; }

        // Constructor for an immutable pair of x/y coordinates.
        public Coordinates(int x, int y)
        {
            this.XPos = x;
            this.YPos = y;
        }

        // Returns the Manhattan distance between this and another corodinate.
        public int DistanceTo(Coordinates other)
        {
            return Math.Abs(XPos - other.XPos) + Math.Abs(YPos - other.YPos);
        }
    }

}
