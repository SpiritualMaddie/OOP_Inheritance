using System;
using System.Collections.Generic;
using System.Text;

namespace Labb6_Inheritance
{
    class Dog : Animal
    {
        string breed = "dog";                                                                       // Dog class field
        public Dog(string aName, string aGender, int aAge, bool aSick, bool aFertile)               // Dog constructor 
            : base(aName, aGender, aAge, aSick, aFertile)                                            // calling Animal class constructor
        {
        }
        public void Digging()                                                                       // Dig method
        {
            Console.WriteLine("Dogs love to dig");
        }
        public override void MakeSound()                                                            // Method for sound dogs make
        {
            Console.WriteLine("OOOOOOOOOoooooooooh woof woof woof ");
        }
        public override void PrintInfo()                                                             // Method for printing out animal info
        {
            string bSick = sick ? "sick" : "healthy";                                               // Sets what sick false/true should print out 
            string bFertile = fertile ? "fertile" : "not fertile";                                  // Sets what fertile false/true should print out
            Console.WriteLine("{0} is a {1} year old {2} {3} that is {4} and {5}",                  // Prints out all info about the animal
                name, age, gender, breed, bSick, bFertile);
        }
    }
}
