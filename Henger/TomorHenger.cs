using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    internal class TomorHenger : Henger
    {
        double fajsuly;

        public TomorHenger(double sugar, int magassag, double fajsuly) :  base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }

        public TomorHenger(double sugar, int magassag) :  base(sugar, magassag)
        {
            fajsuly = 7.87;
        }

        public double Fajsuly { get => fajsuly; set => fajsuly = value; }

        public override string ToString()
        {
            return base.ToString() + $" Fajsúly : {fajsuly}";
        }
    }
}
