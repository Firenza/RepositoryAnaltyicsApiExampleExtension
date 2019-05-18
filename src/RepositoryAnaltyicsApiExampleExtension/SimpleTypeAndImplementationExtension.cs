using RepositoryAnalyticsApi.Extensibility;
using RepositoryAnalyticsApi.ServiceModel;
using System;
using System.Collections.Generic;
using System.Composition;
using System.Threading.Tasks;

namespace RepositoryAnaltyicsApiExampleExtension
{
    [Export(typeof(IDeriveRepositoryTypeAndImplementations))]
    public class SimpleTypeAndImplementationExtension : IDeriveRepositoryTypeAndImplementations, IRequireDependenciesAccess, IRequireFilesAccess, IRequireTopicsAccess
    {
        public IEnumerable<RepositoryDependency> Dependencies { get; set; }
        public IEnumerable<string> TopicNames { get; set; }
        public IEnumerable<RepositoryFile> Files { get; set; }

        public Task<RepositoryTypeAndImplementations> DeriveImplementationAsync(string repositoryName)
        {
            Console.WriteLine("Hey I'm a simple Type and Implementation extension!");

            return Task.FromResult<RepositoryTypeAndImplementations>(null);
        }
    }
}
