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
        public int baseCost;
        const int costPerlanguage = 10;
        public string costString;

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



        public override void CalculateBaseCost(int Options)
        {
            baseCost = (numberLanguages * 10) + Options;
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

        public override string ReturnTotalString()
        {
            return base.ReturnTotalString();
        }


    }
}
