using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPromedio1
{
    internal class TextSituation : Situation
    {

        public TextSituation(string description) : base(description) { }

        public override void ExecuteOption(Player player)
        {
            Console.WriteLine(description);
        }

 
    }
}
