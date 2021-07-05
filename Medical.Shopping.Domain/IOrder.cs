using System.Collections.Generic;

namespace Medical.Shopping.Domain
{
    public interface IOrder
    {
        public IEnumerable<IItem> Items { get; }
        public void Confirm();
        public void ConfirmByAge();
    }

    public interface IReceiveOrderResult
    {

    }
}
