using System.Threading.Tasks;
using Messages.Events;
using NServiceBus;
using NServiceBus.Logging;

namespace Billing
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        private static ILog _log = LogManager.GetLogger<OrderPlacedHandler>();

        public async Task Handle(OrderPlaced message, IMessageHandlerContext context)
        {
            _log.Info($"Received OrderPlaced, OrderId = {message.OrderId} - Charging credit card...");

            // do some stuff
            await context.Publish(new OrderBilled
            {
                OrderId = message.OrderId
            });
        }
    }
}