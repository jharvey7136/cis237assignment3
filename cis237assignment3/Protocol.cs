using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        public int numberLanguages;
        const int costPerlanguage = 5;

        public int NumberLanguages
        {
            get { return numberLanguages; }
            set { numberLanguages = value; }
        }


        public Protocol(string Material, string Model, string Color, int NumberLanguages)
            : base(Material, Model, Color)
        {
            this.numberLanguages = NumberLanguages;
        }

        public override string ToString()
        {
            return this.Material + " - " + this.Model + " - " + this.Color + " - " + numberLanguages + " language(s)";
        }

        public override void CalculateTotalCost()
        {
            TotalCost = numberLanguages * costPerlanguage;
        }


    }
}
