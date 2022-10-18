using System;
using System.Collections.Generic;
using System.Text;

namespace Labb6_Inheritance
{
    class PitBull : Dog
    {
        string playsWith = "big sticks";                                                            // Pit bull class field
        public PitBull(string aName, string aGender, int aAge, bool aSick, bool aFertile)           // Pit bull constructor 
            : base(aName, aGender, aAge, aSick, aFertile)                                           // calling Animal class constructor               
        {
        }
        public void Love()                                                                          // Love method
        {
            Console.WriteLine("Pit bulls love to snuggle, goof around and hugs!");
        }
        public override void PrintInfo()                                                            // Method for printing out animal info
        {
            string bSick = sick ? "sick" : "healthy";                                               // Sets what sick false/true should print out        
            string bFertile = fertile ? "fertile" : "not fertile";                                  // Sets what fertile false/true should print out
            Console.WriteLine("{0} is a {1} year old {2} pit bull that is {3} and {4}",             // Prints out all info about the animal
                name, age, gender, bSick, bFertile);
            Console.WriteLine("{0} loves to play with {1}", name, playsWith);                       // Prints out all info about the animal
        }
    }
}
