using NServiceBus;

namespace Messages.Commands
{
    public class CompleteOrder : ICommand
    {
        public string OrderId { get; set; }
    }
}
