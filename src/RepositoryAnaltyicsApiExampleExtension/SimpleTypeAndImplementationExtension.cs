using RepositoryAnalyticsApi.Extensibility;
using RepositoryAnalyticsApi.ServiceModel;
using System;
using System.Collections.Generic;
using System.Composition;
using System.Threading.Tasks;

namespace RepositoryAnaltyicsApiExampleExtension
{
    [Export(typeof(IDeriveRepositoryTypeAndImplementations))]
    public class SimpleTypeAndImplementationExtension : IDeriveRepositoryTypeAndImplementations
    {
        public Task<RepositoryTypeAndImplementations> DeriveImplementationAsync(IEnumerable<RepositoryDependency> dependencies, Func<Task<List<RepositoryFile>>> readFilesAsync, IEnumerable<string> topics, string name, Func<string, Task<string>> readFileContentAsync)
        {
            Console.WriteLine("Hey I'm a simple Type and Implementation extension!");

            return Task.FromResult<RepositoryTypeAndImplementations>(null);
        }
    }
}
