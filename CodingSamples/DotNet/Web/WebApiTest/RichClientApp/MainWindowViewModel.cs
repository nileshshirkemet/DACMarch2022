using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace RichClientApp
{
    public class MainWindowViewModel : ObservableObject
    {
        private OrdersClientModel model = new OrdersClientModel();

        public string? _statusMessage;
        public string? StatusMessage
        {
            get => _statusMessage;
            set => SetProperty(ref _statusMessage, value);
        }

        public List<OrderResource>? _orders;
        public List<OrderResource>? Orders
        {
            get => _orders;
            set => SetProperty(ref _orders, value);
        }

        public OrderResource _currentOrder = new();
        public OrderResource CurrentOrder
        {
            get => _currentOrder;
            set => SetProperty(ref _currentOrder, value);
        }

        private async void ExecuteLoadInvoice()
        {
            try
            {
                Orders = await model.GetOrdersAsync(_currentOrder.CustomerId);
                StatusMessage = null;
            }
            catch
            {
                Orders = null;
                StatusMessage = "No orders for this customer!";
            }
        }
        public RelayCommand LoadInvoice => new RelayCommand(ExecuteLoadInvoice);

        private async Task ExecuteSubmitOrder()
        {
            int orderNo = await model.PostOrderAsync(_currentOrder);
            if (orderNo != 0)
                StatusMessage = $"New order number is {orderNo}";
            else
                StatusMessage = "Order Failed!";
        }
        public AsyncRelayCommand SubmitOrder => new AsyncRelayCommand(ExecuteSubmitOrder);
    }
}
