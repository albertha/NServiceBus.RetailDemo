using System;
using System.Threading.Tasks;
using NServiceBus;

namespace Shipping
{
    class Program
    {
        static void Main(string[] args)
        {
            Main().GetAwaiter().GetResult();
        }

        static async Task Main()
        {
            Console.Title = "Shipping";

            var endpointConfiguration = new EndpointConfiguration("Shipping");

            var transport = endpointConfiguration.UseTransport<LearningTransport>();

            var endpointInstance = await Endpoint.Start(endpointConfiguration).ConfigureAwait(false);

            Console.WriteLine("Press Ento to exit");
            Console.ReadLine();

            await endpointInstance.Stop().ConfigureAwait(false);
        }
    }
}
