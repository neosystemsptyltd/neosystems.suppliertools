using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSystems.SupplierTools.Tests
{
    public struct Price
    {
        public int minqty;
        public int maxqty;
        public double price;

        public Price(int _min, int _max, double _price)
        {
            minqty = _min;
            maxqty = _max;
            price = _price;
        }
    }


}
