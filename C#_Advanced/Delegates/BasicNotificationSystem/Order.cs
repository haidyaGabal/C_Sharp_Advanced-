
namespace C__Advanced.Delegates.BasicNotificationSystem
{
    public class Order
    {
        #region Fields

        private readonly Notify _orderNotifier;

        #endregion

        #region Constructor

        public Order(Notify orderNotifier)
        {
            _orderNotifier = orderNotifier
                ?? throw new ArgumentNullException(nameof(orderNotifier));
        }

        #endregion

        #region Order Operations

        public void CreateOrder()
        {
            Console.WriteLine("Order is Created!");

            _orderNotifier(
                "New Order",
                "Your order has been created successfully."
            );
        }

        #endregion
    }
}
