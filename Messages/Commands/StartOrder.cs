using System;
using NServiceBus;

namespace Messages.Commands
{
    public class StartOrder : ICommand
    {
        public Guid OrderId { get; set; }
    }
}
