using System.Collections.Generic;

namespace Medical.Shopping.Domain
{
    public interface IShop
    {
        public IOrder CreateOrder(IBasket order);
        public IDictionary<IItem, ISet<IShippingOption>> GetShippingOptions(IOrder order);
        public void ConfirmOrderByAge(IOrder order);
        public void ConfirmOrder(IOrder order);
        public void MarkPaid(IOrder order);
        public void CancelOrder(IOrder order);
    }
}
