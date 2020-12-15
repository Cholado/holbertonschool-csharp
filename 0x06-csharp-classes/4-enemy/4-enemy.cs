using System;

namespace Enemies
{
    ///<summary>Represents an Zombie.</summary>
    public class Zombie
    {
        //<summary>Health field of a zombie.</summary>
        private int health;
        //<summary>Name field of a zombie</summary>
        private string name = "(No name)";
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
        ///<summary>Method to return current health of a zombie</summary>
        public int GetHealth()
        {
            return (health);
        }
        ///<summary>Gets or sets the name.</summary>
        public string Name
        {
            get {return (name);}
            set {name = value;}
        }
    }
}
