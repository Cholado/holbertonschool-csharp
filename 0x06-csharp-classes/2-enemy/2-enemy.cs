using System;

namespace Enemies
{
    ///<summary>Represents an Zombie.</summary>
    public class Zombie
    {
        ///<summary>Health field of a zombie.</summary>
        public int health;
        ///<summary>Constructor for Zombie.</summary>
        public Zombie()
        {
            health = 0;
        }
        ///<summary>Constructor with health value input for Zombie</summary>
        public Zombie (int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
    }
}
