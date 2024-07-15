// Written by Jay Gunderson
// 07/14/2024
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labeling_Inventory__Polymorphism__Page_209_
{
    public class InventoryItem
    {
        // Class variables
        private double weight = Double.MaxValue;
        private double volume = Double.MaxValue;


        // Getters and Setters

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public double Volume
        {
            get { return this.volume; }
            set { this.volume = value; }
        }


        // Constructors
        public InventoryItem(double _weight, double _volume)
        {
            this.Weight = _weight;
            this.Volume = _volume;
        }

        public InventoryItem(): this(Double.MaxValue, Double.MaxValue)
        {
            // Empty Constructor
        }


        // ToString()
        public override string ToString()
        {
            string message = "";
            message += "Weight: " + this.Weight + "\n";
            message += "Volume: " + this.Volume + "\n";
            return message;
        }
    }
}
