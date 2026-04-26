using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPromedio1
{
    internal class Situation
    {

        public string description;
        public List<Option> options;

        public Situation(string description)
        {
            this.description = description;
            options = new List<Option>();
        }

        public virtual void ExecuteOption(Player player)
        {
            Console.WriteLine(description);
        }


    }
}
