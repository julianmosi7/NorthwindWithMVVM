using MVVM.Tools;
using NorthwindDbLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderViewModelLib
{
    public class OrderViewModel : ObservableObject
    {
        public OrderViewModel() { }

        private NorthwindContext db;
        
        public OrderViewModel(NorthwindContext db)
        {
            this.db = db;
            Orders = db.Orders.AsObservableCollection();
            SelectedOrder = Orders.First().ShipName;
        }

        public ObservableCollection<Order> Orders { get; private set; }

        private string selectedOrder;

        public string SelectedOrder
        {
            get => selectedOrder;
            set
            {
                selectedOrder = value;
                OrderDetails = Orders
                    .First(x => x.ShipName == selectedOrder)
                    .OrderDetails
                RaisePropertyChangedEvent(nameof(SelectedOrder));
            }
        }

        private ObservableCollection<Order_Detail> orderDetails;

        public ObservableCollection<Order_Detail> OrderDetails
        {
            get => orderDetails;
            set
            {
                orderDetails = value;
                RaisePropertyChangedEvent(nameof(OrderDetails));
            }
        }

    }
}
