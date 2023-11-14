using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    internal class Cso : Henger
    {
        double falVastagsag;

        public Cso(double sugar, int magassag) : base(sugar, magassag)
        {
            falVastagsag = 1;
        }

        public Cso(double sugar, int magassag, double falVastagsag) :  base(sugar, magassag)
        {
            this.falVastagsag= falVastagsag;
        }

        public double FalVastagsag { get => falVastagsag;}

        public override double Terfogat()
        {
            return (Math.PI * (Math.Pow(Sugar, 2) * Magassag) - (Math.PI * Math.Pow((Sugar - FalVastagsag), 2) * Magassag));

        }

        public override string ToString()
        {
            return base.ToString() + $" Falvastagsága : {falVastagsag}";
        }
    }
}
