using System;

namespace SuperHero_OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ////Intializing Objects and setting a few properties
            Hero firstHero = new Hero();
            firstHero.Name = "Vegeta";
            firstHero.Speed = 6;
            firstHero.PowerLevel = 2;
            
            Hero secondHero = new Hero("Goku", 5);
            
            ////Printing the Object unique Name properties to the console
            Console.WriteLine(firstHero.Name);
            Console.WriteLine(secondHero.Name);

            secondHero.Death();
            firstHero.MaxLevel();
            Console.WriteLine(firstHero.Name + " has a power level of " + firstHero.PowerLevel );
        }
    }
}