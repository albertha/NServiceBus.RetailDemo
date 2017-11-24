using System;
using NServiceBus;

namespace Messages.Events
{
    public class OrderPlaced : IEvent
    {
        public Guid OrderId { get; set; }
    }
}