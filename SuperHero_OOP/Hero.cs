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

        //constructors
        public Hero()
        {
            
        }

        public Hero(string name,int speed)
        {
            this.name = name;
            this.speed = speed;
        }
        
        public Hero( int powerLevel, bool isDead)
        {
            this.powerLevel = powerLevel;
            this.isDead = isDead;
        }

        //methods
        public void Death()
        {
            if (isDead)
            {
                isDead = false;
            }
            Console.WriteLine(this.name + isDead +"is gone" );
        }
        
        
    }
}