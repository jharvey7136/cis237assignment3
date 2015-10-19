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
        public string costString;
        public decimal materialCost = 0;
        public decimal modelCost = 0;
        public decimal colorCost = 0;
        public decimal baseCost;
        public decimal totalCost;

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

            if (material == "Iron")
                materialCost = 150;
            if (material == "Steel")
                materialCost = 200;

            if (model == "Protocol")
                modelCost = 1000;
            if (model == "Utility")
                modelCost = 750;
            if (model == "Janitor")
                modelCost = 500;
            if (model == "Astromech")
                modelCost = 250;

            if (color == "White")
                colorCost = 75;
            if (color == "Black")
                colorCost = 100;
        }

        public virtual void CalculateBaseCost()
        {
            baseCost = materialCost + modelCost + colorCost;
        }

        public virtual void CalculateTotalCost()
        {
            totalCost += baseCost;
        }

        public override string ToString()
        {
            return this.Material + " " + this.Model + " " + this.Color;
        }
        


    }
}
