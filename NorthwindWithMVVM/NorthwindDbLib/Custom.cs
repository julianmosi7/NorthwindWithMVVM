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

    partial class Order_Detail
    {
        public override string ToString()
        {
            return $"Order {OrderID}: {Quantity} x {Product.ProductName}";
        }
    }

    partial class Product
    {
        public override string ToString()
        {
            return $"{Supplier.ContactName}: {UnitPrice}€ ({ProductName})";
        }
    }   
   
}
