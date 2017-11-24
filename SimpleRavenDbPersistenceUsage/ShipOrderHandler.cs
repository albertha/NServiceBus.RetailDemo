using System;
using System.Threading.Tasks;
using Messages.Commands;
using Messages.Events;
using NServiceBus;

namespace SimpleRavenDbPersistenceUsage
{
    public class ShipOrderHandler : IHandleMessages<ShipOrder>
    {
        public Task Handle(ShipOrder message, IMessageHandlerContext context)
        {
            var session = context.SynchronizedStorageSession.RavenSession();
            var orderShipped = new OrderShipped
            {
                Id = message.OrderId,
                ShippingDate = DateTime.UtcNow,
            };
            return session.StoreAsync(orderShipped);
        }
    }
}