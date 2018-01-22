using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeProject.Models
{
    // Struct to represent the x and y coordinates of a given Being.
    public struct Coordinates
    {
        public int XPos { get; private set; }
        public int YPos { get; private set; }

        // Updates the x and y coordinates simultaneously.
        public void MoveTo(int x, int y)
        {
            XPos = x;
            YPos = y;
        }

        // Returns the Manhattan distance between two corodinates.
        public int DistanceTo(Coordinates other)
        {
            return Math.Abs(XPos - other.XPos) + Math.Abs(YPos - other.YPos);
        }
    }

}
