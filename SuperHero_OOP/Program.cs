using System;

namespace SuperHero_OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ////SuperHero OOP
            Hero firstHero = new Hero();
            firstHero.Name = "Vegeta";
            firstHero.Speed = 6;
            
            Hero secondHero = new Hero("Goku", 5);
            Console.WriteLine(firstHero.Name);
            Console.WriteLine(secondHero.Name);

            secondHero.Death();
        }
    }
}