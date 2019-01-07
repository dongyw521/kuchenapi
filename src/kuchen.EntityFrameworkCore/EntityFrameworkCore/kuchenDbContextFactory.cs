using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using kuchen.Configuration;
using kuchen.Web;

namespace kuchen.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class kuchenDbContextFactory : IDesignTimeDbContextFactory<kuchenDbContext>
    {
        public kuchenDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<kuchenDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            kuchenDbContextConfigurer.Configure(builder, configuration.GetConnectionString(kuchenConsts.ConnectionStringName));

            return new kuchenDbContext(builder.Options);
        }
    }
}
