using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPromedio1
{
    internal class Option
    {

        public string text;
        public int healthChange;
        public Situation nextSituation;

        public Option(string text, int healthChange, Situation next)
        {
            this.text = text;
            this.healthChange = healthChange;
            nextSituation = next;
        }






    }
}
