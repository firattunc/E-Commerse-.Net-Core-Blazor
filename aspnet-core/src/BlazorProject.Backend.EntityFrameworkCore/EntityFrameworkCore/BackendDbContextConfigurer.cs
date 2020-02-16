using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Backend.EntityFrameworkCore
{
    public static class BackendDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BackendDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BackendDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
