using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BlazorProject.Backend.Authorization.Roles;
using BlazorProject.Backend.Authorization.Users;
using BlazorProject.Backend.MultiTenancy;
using BlazorProject.Backend.Entities;

namespace BlazorProject.Backend.EntityFrameworkCore
{
    public class BackendDbContext : AbpZeroDbContext<Tenant, Role, User, BackendDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Colour> Colours { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<UserAddress> UserAddresses { get; set; }
        public BackendDbContext(DbContextOptions<BackendDbContext> options)
            : base(options)
        {
        }
    }
}
