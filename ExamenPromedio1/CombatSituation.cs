using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPromedio1
{
    internal class CombatSituation : Situation
    {

        public int damage;

        public CombatSituation(string description, int damage) : base(description)
        {
            this.damage = damage;
        }

        public override void ExecuteOption(Player player)
        {
            Console.WriteLine(description);
            player.health = player.health - damage;
            Console.WriteLine("Perdiste " + damage + " de vida ");
        }
        


    }
}
