using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Bathawk.EntityFrameworkCore
{
    public static class BathawkDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BathawkDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BathawkDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
