using NServiceBus;

namespace Messages.Commands
{
    public class StartOrder : ICommand
    {
        public string OrderId { get; set; }
    }
}
