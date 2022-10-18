// Madde Lundström NET22 
using System;

namespace Labb6_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Bert", "male", 5, true, false);                                     // Dog object created
            dog1.PrintInfo();                                                                       // Calls method in Dog class
            dog1.MakeSound();
            Console.WriteLine();                                                                    // Creates space and cleaner look

            PitBull pitBull1 = new PitBull("Zia", "female", 6, false, true);                        // Pit bull object created
            pitBull1.PrintInfo();
            pitBull1.Love();
            Console.WriteLine();

            Snake snake1 = new Snake("Sir Väs", "male", 8, false, true);                            // Snake object created
            snake1.PrintInfo();
            snake1.Venom();
            snake1.MakeSound();
            Console.WriteLine();

            Labrador labb1 = new Labrador("Sandra", "female", 12, true, false);                     // Labrador object created
            labb1.PrintInfo();
            labb1.Digging();
            Console.WriteLine();

            Bird bird1 = new Bird("Pip", "female", 1, false, true);                                 // First bird object created
            Bird bird2 = new Bird("Puff", "male", 2, false, true);                                  // Second bird object created
            bird1.PrintInfo();
            bird1.Sleep(5);
            bird2.PrintInfo();
            bird2.MakeSound();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
