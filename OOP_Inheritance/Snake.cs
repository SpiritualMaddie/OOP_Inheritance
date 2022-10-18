using System;
using System.Collections.Generic;
using System.Text;

namespace Labb6_Inheritance
{
    class Snake : Animal
    {
        string species = "snake";                                                                   // Snake class field
        public Snake(string aName, string aGender, int aAge, bool aSick, bool aFertile)             // Snake constructor 
            : base(aName, aGender, aAge, aSick, aFertile)                                           // calling Animal class constructor
        {
        }
        public void Venom()
        {
            Console.WriteLine("There's lots of venomous snakes so be careful.");
            Console.WriteLine("And remember if you bite it and you die it's poison, \nbut if it bites you and you die, that's venom");
        }
        public override void MakeSound()                                                            // Method for sound snakes make
        {
            Console.WriteLine("Sssssssssss SSSSsssss");
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
