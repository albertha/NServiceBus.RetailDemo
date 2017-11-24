using System;
using NServiceBus;

namespace Messages.Commands
{
    public class CompleteOrder : ICommand
    {
        public Guid OrderId { get; set; }
        public string OrderDescription { get; set; }
    }
}
