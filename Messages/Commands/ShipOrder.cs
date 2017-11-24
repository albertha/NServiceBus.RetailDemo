using System;
using NServiceBus;

namespace Messages.Commands
{
    public class ShipOrder : ICommand
    {
        public Guid OrderId { get; set; }
    }
}