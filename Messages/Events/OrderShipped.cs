using System;

namespace Messages.Events
{
    public class OrderShipped
    {
        public Guid Id { get; set; }
        public DateTime ShippingDate { get; set; }
    }
}