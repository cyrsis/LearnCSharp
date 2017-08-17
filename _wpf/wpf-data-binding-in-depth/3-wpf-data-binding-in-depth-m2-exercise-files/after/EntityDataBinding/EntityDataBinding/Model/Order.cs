using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDataBinding
{
    public class Order : INotifyPropertyChanged, IEditableObject
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private decimal _ItemsTotal;
        private int _OrderStatusId;
        private DateTime _OrderDate;
        private Guid _CustomerId;
        private long _Id;
        private Order _TempValues;

        public long Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }

        public Guid CustomerId
        {
            get
            {
                return _CustomerId;
            }
            set
            {
                _CustomerId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CustomerId"));
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                _OrderDate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("OrderDate"));
            }
        }

        public int OrderStatusId
        {
            get
            {
                return _OrderStatusId;
            }
            set
            {
                _OrderStatusId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("OrderStatusId"));
            }
        }

        public decimal ItemsTotal
        {
            get
            {
                return _ItemsTotal;
            }
            set
            {
                _ItemsTotal = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ItemsTotal"));
            }
        }

        public void BeginEdit()
        {
            _TempValues = new Order()
            {
                Id = Id,
                CustomerId = CustomerId,
                OrderDate = OrderDate,
                OrderStatusId = OrderStatusId,
                ItemsTotal = ItemsTotal
            };
        }

        public void CancelEdit()
        {
            Id = _TempValues.Id;
            CustomerId = _TempValues.CustomerId;
            OrderDate = _TempValues.OrderDate;
            OrderStatusId = _TempValues.OrderStatusId;
            ItemsTotal = _TempValues.ItemsTotal;
        }

        public void EndEdit()
        {
            _TempValues = null;
        }
    }
}
