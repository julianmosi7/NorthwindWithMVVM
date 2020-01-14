using MVVM.Tools;
using NorthwindDbLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OrderViewModelLib
{
    public class OrderViewModel : ObservableObject
    {
        public OrderViewModel() { }

        private NorthwindContext db;
        
        public OrderViewModel(NorthwindContext db)
        {
            this.db = db;
            AllProducts = db.Products.ToList();
            MinDate = DateTime.Now.AddYears(-50);
        }

        private Order selectedOrder;

        public Order SelectedOrder
        {
            get => selectedOrder;
            set
            {
                selectedOrder = value;
                OrderDetails = db.Order_Details
                    .Where(x => x.OrderID == selectedOrder.OrderID)
                    .ToList()
                    .AsObservableCollection();
                SelectedOrderDate = selectedOrder.OrderDate;
                    
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

        private DateTime minDate;

        public DateTime MinDate
        {
            get { return minDate; }
            set 
            {
                minDate = value;
                Orders = db.Orders
                    .Where(x => x.OrderDate >= minDate)
                    .ToList();
                RaisePropertyChangedEvent(nameof(MinDate));
            }
        }

        private List<Order> orders;

        public List<Order> Orders
        {
            get { return orders; }
            set 
            {
                orders = value;
                RaisePropertyChangedEvent(nameof(Orders));
            }
        }

        private DateTime? selectedOrderDate;

        public DateTime? SelectedOrderDate
        {
            get { return selectedOrderDate; }
            set
            {
                selectedOrderDate = value;
                RaisePropertyChangedEvent(nameof(SelectedOrderDate));
            }
        }

        private List<Product> allProducts;

        public List<Product> AllProducts
        {
            get { return allProducts; }
            private set 
            {
                allProducts = value;
                RaisePropertyChangedEvent(nameof(AllProducts));
            }
        }

        private string productname;

        public string Productname
        {
            get { return productname; }
            set 
            {
                productname = value;
                selectedOrderDetail.Product.ProductName = productname;
                //db.SaveChanges();
                AllProducts = db.Products.ToList();
                RaisePropertyChangedEvent(nameof(Productname));
            }
        }

        private string suppliername;

        public string Suppliername
        {
            get { return suppliername; }
            set 
            { 
                suppliername = value;
                selectedOrderDetail.Product.Supplier.CompanyName = suppliername;
                //db.SaveChanges();
                AllProducts = db.Products.ToList();
                RaisePropertyChangedEvent(nameof(Suppliername));
            }
        }


        private Order_Detail selectedOrderDetail;

        public Order_Detail SelectedOrderDetail
        {
            get { return selectedOrderDetail; }
            set
            { 
                selectedOrderDetail = value;
                Productname = selectedOrderDetail.Product.ProductName.ToString();
                Suppliername = SelectedOrderDetail.Product.Supplier.CompanyName.ToString();
                RaisePropertyChangedEvent(nameof(SelectedOrderDetail));
            }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private Product selectedProduct;

        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set 
            { 
                selectedProduct = value;
            }
        }

        public ICommand AddCommand => new RelayCommand<string>(
            DoAddOrderDetail,
            x => selectedOrderDetail != null);
        
        private void DoAddOrderDetail(string obj)
        {
            Order_Detail newOrderDetails = new Order_Detail
            {
                ProductID = selectedProduct.ProductID,
                Product = selectedProduct,
                OrderID = selectedOrder.OrderID,
                Order = selectedOrder,
                UnitPrice = selectedProduct.UnitPrice * Quantity ?? 0,
                Quantity = (short) Quantity
            };

            db.Order_Details.Add(newOrderDetails);
            db.SaveChanges();
            SelectedOrder = selectedOrder;
        }
    }
}
