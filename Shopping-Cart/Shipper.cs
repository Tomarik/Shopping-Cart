using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Cart
{
    class Shipper
    {
        private List<IShippable> cart = new List<IShippable>();
        public void Add(IShippable item)
        {
            cart.Add(item);
        }
        public void OutputList()
        {
            int bikes = 0;
            int crackers = 0;
            int mowers = 0;
            int gloves = 0;

            foreach (IShippable item in cart)
            {
                if (item is Bike)
                {
                    bikes++;
                }
                if (item is Crackers)
                {
                    crackers++;
                }
                if (item is Mower)
                {
                    mowers++;
                }
                if (item is Glove)
                {
                    gloves++;
                }
                
            }

          
            System.Console.WriteLine("Shipment manifest:");
            if (bikes > 1)
            {
                System.Console.WriteLine(bikes + " Bicycles");
            }
            else if (bikes == 1)
            {
                System.Console.WriteLine(bikes + " Bicycle");
            }

            if (gloves > 1)
            {
                System.Console.WriteLine(gloves + " Baseball Gloves");
            }
            else if (gloves == 1)
            {
                System.Console.WriteLine(gloves + " Baseball Glove");
            }
            
            if (mowers > 1)
            {
                System.Console.WriteLine(mowers + " Lawn Mowers");
            }
            
            else if (mowers == 1)
            {
                System.Console.WriteLine(mowers + " Lawn Mower");
            }
            if (crackers > 0)
            {
                System.Console.WriteLine(crackers + " Crackers");
            }
        }

        public decimal ShippingCost()
        {
            decimal ShippingTotal = 0;
            foreach (IShippable item in cart)
            {
                ShippingTotal += item.ShipCost;
            }
            return ShippingTotal;
        }

    }
}
