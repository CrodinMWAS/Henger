using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    internal class Henger
    {
        int magassag;
        double sugar;
        static int szuletesSzamlalo;


        public int Magassag { get => magassag;}
        public double Sugar { get => sugar;}
        static public int SzuletesSzamlalo { get => szuletesSzamlalo;}
        public Henger(double sugar, int magassag)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo++;
        }

        public virtual double Terfogat()
        {
            return Math.PI * (sugar * sugar) * magassag;
        }

        public override string ToString()
        {
            return $"Jellemzők >> Térfogat : {Math.Round(Terfogat(),2)}; sugar = {sugar}," +
                $" magassag = {magassag}";
        }
    }
}
