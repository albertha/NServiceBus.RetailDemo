using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Messages.Commands;
using NServiceBus;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            Main().GetAwaiter().GetResult();
        }

        static async Task Main()
        {
            Console.Title = "Sales";

            var endpointConfiguration = new EndpointConfiguration("Sales");

            var transport = endpointConfiguration.UseTransport<LearningTransport>();

            var routing = transport.Routing();
            routing.RouteToEndpoint(typeof(StartOrder), "Shipping");

            var endpointInstance = await Endpoint.Start(endpointConfiguration).ConfigureAwait(false);

            Console.WriteLine("Press Ento to exit");
            Console.ReadLine();

            await endpointInstance.Stop().ConfigureAwait(false);

        }
    }
}
