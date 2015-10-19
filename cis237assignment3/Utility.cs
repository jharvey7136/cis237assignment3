using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {
        public bool toolBox;
        public bool computerConnection;
        public bool arm;
        public string toolBoxYesNo;
        public string computerConnectionYesNo;
        public string armYesNo;
        public string costString;
        public int baseCost;
        public int toolCost = 0;
        public int compCost = 0;
        public int armCost = 0;




        public Utility(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm)
            : base(Material, Model, Color)
        {
            this.toolBox = ToolBox;
            if (toolBox)
            {
                toolBoxYesNo = "ToolBox = Yes";
                toolCost = 10;
            }
            if (!toolBox)
                toolBoxYesNo = "ToolBox = No";
                
            this.computerConnection = ComputerConnection;
            if (computerConnection)
            {
                computerConnectionYesNo = "Computer Connection = Yes";
                compCost = 20;
            }
            if (!computerConnection)            
                computerConnectionYesNo = "Computer Connection = No";

            this.arm = Arm;
            if (arm)
            {
                armYesNo = "Arm = Yes";
                armCost = 30;
            }
            if (!arm)
                armYesNo = "Arm = No";
        }



        public override void CalculateBaseCost(int Options)
        {
            baseCost = toolCost + compCost + armCost + Options;
            costString = baseCost.ToString();
        }

        public override void CalculateTotalCost()
        {
            base.totalCost += baseCost;
        }

        public override string ToString()
        {
            return this.Material + " - " + this.Model + " - " + this.Color + " - " + toolBoxYesNo + " - " + computerConnectionYesNo + " - " + armYesNo + " for $" + costString;
        }


    }
}
