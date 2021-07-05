using System.Collections.Generic;

namespace Medical.Shopping.Domain
{
    public interface IClient
    {
        public void AddItemToBasket(IItem item);
        public IBasket GetBasket();
        public IDictionary<IItem, IShippingOption> ChooseShippingOptions(IEnumerable<IItem> items);
    }
    public interface IBasket
    {
        public void AddItem(IItem item);
    }
}
