using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPromedio1
{
    internal class FinalSituation : Situation
    {
        public string endingType;

        public FinalSituation(string description, string endingType) : base(description)
        {
            this.endingType = endingType;
        }



    }
}
