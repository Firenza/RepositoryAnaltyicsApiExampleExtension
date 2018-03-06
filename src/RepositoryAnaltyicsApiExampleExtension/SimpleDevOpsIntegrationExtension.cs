using System;
using System.Composition;
using System.Threading.Tasks;
using RepositoryAnalyticsApi.Extensibility;
using RepositoryAnalyticsApi.ServiceModel;

namespace RepositoryAnaltyicsApiExampleExtension
{
    [Export(typeof(IDeriveRepositoryDevOpsIntegrations))]
    public class SimpleDevOpsIntegrationExtension : IDeriveRepositoryDevOpsIntegrations
    {
        public Task<RepositoryDevOpsIntegrations> DeriveIntegrationsAsync(string repositoryName)
        {
            Console.WriteLine("Hey I'm a simple DevOps integraiton extension!");

            return Task.FromResult<RepositoryDevOpsIntegrations>(null);
        }
    }
}
