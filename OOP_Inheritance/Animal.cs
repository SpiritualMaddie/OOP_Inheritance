using System;
using System.Collections.Generic;
using System.Text;

namespace Labb6_Inheritance
{
    class Animal
    {
        public string name = "No name";                                                              // Animal class fields
        public string gender = "No gender";
        public int age = 0;
        public bool sick = false;
        public bool fertile = false;
        public Animal(string aName, string aGender, int aAge, bool aSick, bool aFertile)            // Animal class constructor with arguments
        {                                                                                           // for creating new animal objects
            this.name = aName;                                                                      // Set class fields as input from constructor
            this.gender = aGender;
            this.age = aAge;
            this.sick = aSick;
            this.fertile = aFertile;
        }
        public void Sleep(int hoursSleep)                                                           // Method sleep habits
        {
            Console.WriteLine("This animal wants {0} hours of sleep", hoursSleep);
        }
        public virtual void PrintInfo()                                                             // Method for printing out animal info
        {
            string bSick = sick ? "sick" : "healthy";                                               // Sets what sick false/true should print out 
            string bFertile = fertile ? "fertile" : "not fertile";                                  // Sets what fertile false/true should print out
            Console.WriteLine("{0} is a {1} year old {2} that is {3} and {4}",                      // Prints out all info about the animal
                name, age, gender, bSick, bFertile);
        }
        public virtual void MakeSound()                                                             // Method for sounds the animals make
        {
            Console.WriteLine("This animal makes sounds");
        }
    }
}
