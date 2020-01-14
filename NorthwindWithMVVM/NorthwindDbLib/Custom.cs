using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDbLib
{
    partial class Order
    {
        public override string ToString()
        {
            return $"Order {OrderID} from {OrderDate?.ToString("yyyy-MM-dd")}";
        }
    }
}
