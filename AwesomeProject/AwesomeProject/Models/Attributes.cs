using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeProject.Models
{
    // Helper class to define standard attributes for characters & monsters.
    public class Statistics
    {
        public int    Attack     { get; set; }  // Attacck modifier
        public string ClassName  { get; set; }  // Descriptive name of class
        public int    Defense    { get; set; }  // Defense modifier
        public int    HealthCurr { get; set; }  // Current health
        public int    HealthMax  { get; set; }  // Maximum amount of health
        public int    Level      { get; set; }  // Current level
        public int    Speed      { get; set; }  // Speed modifier
        public int    XP         { get; set; }  // Experience
    }
}
