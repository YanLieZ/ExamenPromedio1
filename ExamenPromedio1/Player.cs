using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPromedio1
{
    internal class Player
    {

        public string name;
        public int health;

        public Player (string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        public virtual void ShowPlayerInfo()
        {
            Console.WriteLine("Name: " + name + "|| Health: " + health);
        }




    }
}
