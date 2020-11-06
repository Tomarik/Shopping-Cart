using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Cart
{
    interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
