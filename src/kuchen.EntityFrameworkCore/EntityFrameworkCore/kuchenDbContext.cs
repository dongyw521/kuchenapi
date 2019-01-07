using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using kuchen.Authorization.Roles;
using kuchen.Authorization.Users;
using kuchen.MultiTenancy;

namespace kuchen.EntityFrameworkCore
{
    public class kuchenDbContext : AbpZeroDbContext<Tenant, Role, User, kuchenDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public kuchenDbContext(DbContextOptions<kuchenDbContext> options)
            : base(options)
        {
        }
    }
}
