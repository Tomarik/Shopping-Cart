using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Cart
{
    class Mower: IShippable
    {
        private string product = "Lawn Mower";
        private decimal shipCost = 24.00M;

        public decimal ShipCost { get { return shipCost; } }

        public string Product { get { return product; } }

    }
}
