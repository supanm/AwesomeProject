using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeProject.Models
{
    // Struct-like class to represent the attributes for each Being. 
    public class Attributes
    {
        public int HealthMax  { get; set; }
        public int HealthCurr { get; set; }
        public int Attack     { get; set; }
        public int Defense    { get; set; }
        public int Speed      { get; set; }
        public int Level      { get; set; }
        public int Experience { get; set; }
        public string Class   { get; set; }
    }
}
