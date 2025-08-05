using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp
{
    internal class Order
    {
        public int   Id {  get; set; }
        public DateTime  Moment { get; set; }
        public OrderStatus Status { get; set; }
        public override string ToString()
        {
            return "Id: " + Id +
                ", Moment: " + Moment + 
                ", Status: " + Status;
        }

    }
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
  
}
