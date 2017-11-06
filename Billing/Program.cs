using System;
using System.Threading.Tasks;
using NServiceBus;

namespace Billing
{
    class Program
    {
        static void Main(string[] args)
        {
            Main().GetAwaiter().GetResult();
        }

        static async Task Main()
        {
            Console.Title = "Billing";

            var endpointConfiguration = new EndpointConfiguration("Billing");

            var transport = endpointConfiguration.UseTransport<LearningTransport>();

            var endpointInstance = await Endpoint.Start(endpointConfiguration).ConfigureAwait(false);

            Console.WriteLine("Press Ento to exit");
            Console.ReadLine();

            await endpointInstance.Stop().ConfigureAwait(false);

        }
    }
}
