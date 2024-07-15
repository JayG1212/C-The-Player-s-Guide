// Written by Jay Gunderson
// 07/14/2024
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labeling_Inventory__Polymorphism__Page_209_
{
    public class Pack
    {
        // Class variables
        List<InventoryItem> listOfItems = new List<InventoryItem>();
        private int itemLimit = -1;
        private double weightLimit = Double.MinValue;
        private double volumeLimit = Double.MinValue;
        private double currentWeight = 0;
        private double currentVolume = 0;
        private int currentItems = 0;
        // Getters and Setters
        public int ItemLimit
        {
            get { return this.ItemLimit; }
            private set { this.itemLimit = value; }
        }

        public double WeightLimit
        {
            get { return this.WeightLimit; }
            private set { this.weightLimit = value; }
        }

        public double VolumeLimit
        {
            get { return this.VolumeLimit; }
            private set { this.volumeLimit = value; }
        }

        // Constructors
        public Pack(int _itemLimit, double _weightLimit, double _volumeLimit)
        {
            ItemLimit = _itemLimit;
            WeightLimit = _weightLimit;
            VolumeLimit = _volumeLimit;
        }

        public Pack() : this(-1, Double.MinValue, Double.MinValue)
        {

        }

        public void AddItem(InventoryItem anItem)
        {
            if (currentItems + 1 <= itemLimit)
            {
                if (currentWeight + anItem.Weight <= weightLimit)
                {
                    if (currentVolume + anItem.Volume <= volumeLimit)
                    {
                        // Adds Item and updates total values

                        listOfItems.Add(anItem);
                        currentItems++;
                        currentWeight += anItem.Weight;
                        currentVolume += anItem.Volume;

                    }

                    else
                    {
                        throw new InvalidOperationException("Cannot add Item: Exceeds volume Limit");
                    }
                }
                else
                {
                    throw new InvalidOperationException("Cannot add Item: Exceeds Weight Limit");
                }
            }
            else
            {
                throw new InvalidOperationException("Cannot add Item: Exceeds Item limit");
            }
        }
       
        public override string ToString()
        {
            string message = "";
            message += "Contents in Pack: ";
            foreach(var i in listOfItems)
            {
                message += i.ToString() + ", ";
            }
            return message;
        }
    }
}
