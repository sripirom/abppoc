using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Bathawk.Configuration;
using Bathawk.Web;

namespace Bathawk.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BathawkDbContextFactory : IDesignTimeDbContextFactory<BathawkDbContext>
    {
        public BathawkDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BathawkDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BathawkDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BathawkConsts.ConnectionStringName));

            return new BathawkDbContext(builder.Options);
        }
    }
}
