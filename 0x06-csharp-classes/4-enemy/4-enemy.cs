
using System;

namespace Enemies
{
    ///<summary>Represents Zombie class</summary>
    public class Zombie
    {
        ///<summary>Sets health value</summary>
        private int health;
        private string name = "(No name)";
        ///<summary>Sets heal to zero</summary>
        public Zombie()
        {
            health = 0;
        }
        ///<summary>Sets health above zero</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }
        ///<summary>Gets and sets name</summary>
        public string Name
        {
            get => name;
            set => name = value;
        }
        ///<summary>Returns value of health</summary>
        public int GetHealth()
        {
            return this.health;
        }
    }
}
