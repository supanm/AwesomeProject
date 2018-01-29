using System;

namespace AwesomeProject
{
    //Undefined enum
    public enum Enum0 { undefined };

    //Item class declaration
    public class Item
    {
        //Id of the item
        public string Id { get; set; }
        //Name of the item
        public string Text { get; set; }
        //Description of the item
        public string Description { get; set; }
        //Enum for the different attributes that an item would modify
        public enum Attribute { Attack, Defense, Health, Damage, Speed };
        //Attribute that the item modifies for the being
        public Attribute AttributeType { get; set; }
        //Value modifier of the Attribute
        public int Value { get; set; }
        //Which body part holds the item
        //Enum for all the types of body parts that an item could be placed upon
        public enum BodyPart { Head, Body, Feet, MainHand, OffHand, MainFinger, OffFinger, Neck };
        public BodyPart BodyPartType { get; set; }
        //The range of the item
        public int Range { get; set; }
        //The image assigned to the item
        public string Image { get; set; }
    }

}
