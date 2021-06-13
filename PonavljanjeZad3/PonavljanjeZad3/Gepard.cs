using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeZad3
{
    class Gepardm : Cat
    {
        public override void Opasnost(bool opasna)
        {
            opasna = true;
            Console.WriteLine("Opasnost ove macke je = " + opasna);
        }
    }
}
