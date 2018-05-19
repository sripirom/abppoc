using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Bathawk.Authorization.Roles;
using Bathawk.Authorization.Users;
using Bathawk.MultiTenancy;

namespace Bathawk.EntityFrameworkCore
{
    public class BathawkDbContext : AbpZeroDbContext<Tenant, Role, User, BathawkDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BathawkDbContext(DbContextOptions<BathawkDbContext> options)
            : base(options)
        {
        }
    }
}
