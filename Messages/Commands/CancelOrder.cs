using NServiceBus;

namespace Messages.Commands
{
    public class CancelOrder : ICommand
    {
        public string OrderId { get; set; }
    }
}
