using System.Threading.Tasks;
using Messages.Events;
using NServiceBus;
using NServiceBus.Logging;

namespace Shipping
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        private static ILog _log = LogManager.GetLogger<OrderPlacedHandler>();

        public Task Handle(OrderPlaced message, IMessageHandlerContext context)
        {
            _log.Info($"Received OrderPlaced, OrderId = {message.OrderId} - Shall we ship...");

            // do some stuff
            return Task.CompletedTask;
        }
    }
}