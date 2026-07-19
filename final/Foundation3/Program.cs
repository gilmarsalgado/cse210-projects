using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        
        Lecture lecture= new Lecture("Object Oriented Programming","Inheritance","1/1/2023","9:00am",new Address("123 Elm St","New Your City","NY","USA"),"Bob the builder",100);
        lecture.GetStandardDetails();
        lecture.GetFullDetails();
        lecture.GetShortDescription();

        Reception reception= new Reception("Graduation","MSD 321 Graduation Party","6/1/2023","7:00pm",new Address("123 Elm St","New Your City","NY","USA"),"grad@msd321.com");
        reception.GetStandardDetails();
        reception.GetFullDetails();
        reception.GetShortDescription();

        Outdoor outdoor= new Outdoor("Bridge Tour","Tour the London Bridge","10/13/2023","11:30am",new Address("246 Oak Circle","London","England","UK"),"Chance of rain and Wind");
        outdoor.GetStandardDetails();
        outdoor.GetFullDetails();
        outdoor.GetShortDescription();
    }
}