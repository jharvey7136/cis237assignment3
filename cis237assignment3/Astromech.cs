using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        public bool fireExtinguisher;
        public int numberShips;
        public int shipsCost;
        public int fireCost;
        public string fireExtinguisherYesNo;

        public Astromech(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips)
            : base(Material, Model, Color, ToolBox, ComputerConnection, Arm)
        {
            this.fireExtinguisher = FireExtinguisher;
            if (fireExtinguisher)
            {
                fireExtinguisherYesNo = "Fire Extinguisher = Yes";
                fireCost = 100;
            }
            if (!fireExtinguisher)
                fireExtinguisherYesNo = "Fire Extinguisher = No";

            this.numberShips = NumberShips;
            shipsCost = numberShips * 200;
        }

        public override void CalculateBaseCost()
        {
            baseCost = modelCost + materialCost + colorCost + toolCost + compCost + armCost + fireCost + shipsCost;
            costString = baseCost.ToString();
        }

        public override void CalculateTotalCost()
        {
            base.totalCost += baseCost;
        }

        public override string ToString()
        {
            return this.Material + " - " + this.Model + " - " + this.Color + " - " + toolBoxYesNo + " - " + computerConnectionYesNo + " - " + armYesNo + " - " +
                fireExtinguisherYesNo + " - with " + numberShips.ToString() + " ship(s)" + " for $" + costString;
        }


    }
}
