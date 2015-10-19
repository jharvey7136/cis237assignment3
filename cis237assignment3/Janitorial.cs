using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitorial : Utility
    {
        public bool trashCompactor;
        public bool vacuum;
        public string trashCompactorYesNo;
        public string vacuumYesNo;


        public Janitorial(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool TrashCompactor,
            bool Vacuum)
            : base(Material, Model, Color, ToolBox, ComputerConnection, Arm)
        {
            this.trashCompactor = TrashCompactor;
            if (trashCompactor)
                trashCompactorYesNo = "Trash Compactor = Yes";
            if (!trashCompactor)
                trashCompactorYesNo = "Trash Compactor = No";

            this.vacuum = Vacuum;
            if (vacuum)
                vacuumYesNo = "Vacuum = Yes";
            if (!vacuum)
                vacuumYesNo = "Vacuum = No";

        }

        public override string ToString()
        {
            return this.Material + " - " + this.Model + " - " + this.Color + " - " + toolBoxYesNo + " - " + computerConnectionYesNo + " - " + armYesNo + " - " +
                trashCompactorYesNo + " - " + vacuumYesNo;
        }

        public override void CalculateTotalCost()
        {

        }



    }
}
