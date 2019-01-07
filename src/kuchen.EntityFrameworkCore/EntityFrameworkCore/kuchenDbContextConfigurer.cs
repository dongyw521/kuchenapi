using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace kuchen.EntityFrameworkCore
{
    public static class kuchenDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<kuchenDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<kuchenDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
