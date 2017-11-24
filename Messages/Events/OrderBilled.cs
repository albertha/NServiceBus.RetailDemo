using System;
using NServiceBus;

namespace Messages.Events
{
    public class OrderBilled : IEvent
    {
        public Guid OrderId { get; set; }
    }
}