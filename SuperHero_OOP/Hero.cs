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


        
        
    }
}