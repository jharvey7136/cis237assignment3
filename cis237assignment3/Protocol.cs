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
        const int costPerlanguage = 10;


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

        public override void CalculateBaseCost()
        {
            baseCost = modelCost + materialCost + colorCost + (numberLanguages * 10);
            costString = baseCost.ToString();
        }

        public override void CalculateTotalCost()
        {
            base.totalCost += baseCost;
            
        }

        public override string ToString()
        {
            return this.Material + " - " + this.Model + " - " + this.Color + " - " + numberLanguages + " language(s) for $" + costString;
        }
    }
}
