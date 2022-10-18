using System;
using System.Collections.Generic;
using System.Text;

namespace Labb6_Inheritance
{
    class Labrador : Dog
    {
        string toy = "squeaky";                                                                     // Labrador class field
        public Labrador(string aName, string aGender, int aAge, bool aSick, bool aFertile)          // Labrador constructor 
            : base(aName, aGender, aAge, aSick, aFertile)                                           // calling Animal class constructor
        {
        }
        public void Training()                                                                      // Training method
        {
            Console.WriteLine("Labradors have special skills in certain kinds of training");
        }
        public override void PrintInfo()                                                            // Method for printing out animal info
        {
            string bSick = sick ? "sick" : "healthy";                                               // Sets what sick false/true should print out 
            string bFertile = fertile ? "fertile" : "not fertile";                                  // Sets what fertile false/true should print out
            Console.WriteLine("{0} is a {1} year old {2} labrador that is {3} and {4}",             // Prints out all info about the animal
                name, age, gender, bSick, bFertile);
            Console.WriteLine("{0} loves to play with {1} toys.", name, toy);                       // Prints out all info about the animal
        }
    }
}
