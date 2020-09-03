using System;
using System.Runtime.ConstrainedExecution;

namespace SuperHero_OOP
{
    public class Hero
    {
        //fields
        private string name;
        private int powerLevel;
        private int speed;
        private bool isDead = true;
        private bool maxPower = false;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int PowerLevel
        {
            get { return powerLevel; }
            set { powerLevel = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool IsDead
        {
            get { return isDead; }
            set { isDead = value; }
        }

        public bool MaxPower
        {
            get { return maxPower; }
            set { maxPower = value; }
        }

        //constructors
        public Hero()
        {
            
        }

        public Hero(string name,int speed)
        {
            this.name = name;
            this.speed = speed;
        }
        
        public Hero( string name, int powerLevel, bool isDead)
        {
            this.name = name;
            this.powerLevel = powerLevel;
            this.isDead = isDead;
        }

        //methods
        
        //Death Method will print to the console the name of the hero and a string
        public void Death()
        {
            if (isDead)
            {
                Console.WriteLine(this.name + " is gone" );
                isDead = false;
            }
            
        }

        //Max Level Method will check to see if the Hero meets the conditions
        //then return the Hero current power level
        public int MaxLevel()
        {
            if (PowerLevel <= 9)
            {
                MaxPower = true;
                PowerLevel = 10;
            }

            return this.PowerLevel;
        }
        
    }
}