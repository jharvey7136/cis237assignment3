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
        public string fireExtinguisherYesNo;

        public Astromech(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips)
            : base(Material, Model, Color, ToolBox, ComputerConnection, Arm)
        {
            this.fireExtinguisher = FireExtinguisher;
            if (fireExtinguisher)
                fireExtinguisherYesNo = "Fire Extinguisher = Yes";
            if (!fireExtinguisher)
                fireExtinguisherYesNo = "Fire Extinguisher = No";

            this.numberShips = NumberShips;
        }



        public override string ToString()
        {
            return this.Material + " - " + this.Model + " - " + this.Color + " - " + toolBoxYesNo + " - " + computerConnectionYesNo + " - " + armYesNo + " - " +
                fireExtinguisherYesNo + " - with " + numberShips.ToString() + " ship(s)";
        }

        public override void CalculateTotalCost()
        {

        }



    }
}
