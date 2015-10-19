using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {

        public string material;
        public string model;
        public string color;
        //public decimal baseCost;

        public decimal totalCost;
        //public int materialCost;
        //public int modelCost;
        //public int colorCost;

        public virtual decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public Droid(string Material, string Model, string Color)
        {
            this.material = Material;
            this.model = Model;
            this.color = Color;
        }

        public override string ToString()
        {
            return this.Material + " " + this.Model + " " + this.Color;
        }

        public abstract void CalculateTotalCost();

        


    }
}
