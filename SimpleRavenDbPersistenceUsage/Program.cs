using System;
using System.Threading.Tasks;
using NServiceBus;
using Raven.Client.Document;

namespace SimpleRavenDbPersistenceUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            Main().GetAwaiter().GetResult();
        }

        static async Task Main()
        {
            Console.Title = "Samples.RavenDB.Server";

            var endpointConfiguration = new EndpointConfiguration("Samples.RavenDB.Server");
            using (var documentStore = new DocumentStore
            {
                Url = "http://rdb-dev.umusic.com",
                DefaultDatabase = "RavenSampleData"
            })
            {
                documentStore.Initialize();

                endpointConfiguration.UseTransport<LearningTransport>();
                var persistence = endpointConfiguration.UsePersistence<RavenDBPersistence>();
                // Only required to simplify the sample setup
                persistence.DoNotSetupDatabasePermissions();
                persistence.SetDefaultDocumentStore(documentStore);

                var endpointInstance = await Endpoint.Start(endpointConfiguration).ConfigureAwait(false);

                Console.WriteLine("Press Ento to exit");
                Console.ReadLine();

                await endpointInstance.Stop().ConfigureAwait(false);
            }
        }
    }
}
