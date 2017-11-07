using System.Threading.Tasks;
using Messages.Events;
using NServiceBus;
using NServiceBus.Logging;

namespace Shipping
{
    public class OrderBilledHandler : IHandleMessages<OrderBilled>
    {
        private static ILog _log = LogManager.GetLogger<OrderBilledHandler>();

        public Task Handle(OrderBilled message, IMessageHandlerContext context)
        {
            _log.Info($"Received OrderBilled, OrderId = {message.OrderId} - Shall we ship?");

            // do some stuff
            return Task.CompletedTask;
        }
    }
}