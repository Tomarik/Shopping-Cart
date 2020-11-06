using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Cart
{
    class Crackers : IShippable
    {
        private string product = "Crackers";
        private decimal shipCost = 0.57M;

        public decimal ShipCost { get { return shipCost; } }

        public string Product { get { return product; } }

    }
}
