using System;
using System.Collections.Generic;
using System.Text;

namespace Labb6_Inheritance
{
    class Bird : Animal
    {
        string species = "bird";                                                                    // Bird class field
        public Bird(string aName, string aGender, int aAge, bool aSick, bool aFertile)              // Bird constructor 
            : base(aName, aGender, aAge, aSick, aFertile)                                           // calling Animal class constructor
        {
        }
        public void Flying()
        {
            Console.WriteLine("Not all birds can fly but many love to do so.");
        }
        public override void MakeSound()                                                            // Method for sound birds make
        {
            Console.WriteLine("Kraw kraw");
        }
        public override void PrintInfo()                                                            // Method for printing out animal info
        {
            string bSick = sick ? "sick" : "healthy";                                               // Sets what sick false/true should print out           
            string bFertile = fertile ? "fertile" : "not fertile";                                  // Sets what fertile false/true should print out            
            Console.WriteLine("{0} is a {1} year old {2} {3} that is {4} and {5}",                  // Prints out all info about the animal
                name, age, gender, species, bSick, bFertile);
        }
    }
}
