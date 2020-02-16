using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BlazorProject.Backend.Configuration;
using BlazorProject.Backend.Web;

namespace BlazorProject.Backend.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BackendDbContextFactory : IDesignTimeDbContextFactory<BackendDbContext>
    {
        public BackendDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BackendDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BackendDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BackendConsts.ConnectionStringName));

            return new BackendDbContext(builder.Options);
        }
    }
}
