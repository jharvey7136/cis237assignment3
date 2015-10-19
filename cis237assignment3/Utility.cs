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




        public Utility(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm)
            : base(Material, Model, Color)
        {
            this.toolBox = ToolBox;
            if (toolBox)
                toolBoxYesNo = "ToolBox = Yes";
            if (!toolBox)
                toolBoxYesNo = "ToolBox = No";
                
            this.computerConnection = ComputerConnection;
            if (computerConnection)
                computerConnectionYesNo = "Computer Connection = Yes";
            if (!computerConnection)
                computerConnectionYesNo = "Computer Connection = No";

            this.arm = Arm;
            if (arm)
                armYesNo = "Arm = Yes";
            if (!arm)
                armYesNo = "Arm = No";
        }

        public override string ToString()
        {
            return this.Material + " - " + this.Model + " - " + this.Color + " - " + toolBoxYesNo + " - " + computerConnectionYesNo + " - " + armYesNo;
        }

        public override void CalculateTotalCost()
        {
            
        }




    }
}
