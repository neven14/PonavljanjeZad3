using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeZad3
{
    class Cat
    {
		public bool opasna { get; set; }
		public virtual void Opasnost(bool opasna)
		{
			opasna = false;
			Console.WriteLine("Opasnost ove macke je = " + opasna);
		}
	}
}
