using Finbuckle.MultiTenant;
using Finbuckle.MultiTenant.Stores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class MultiTenantStoreDbContext : EFCoreStoreDbContext<ExtendedTenantInfo>
    {
        public MultiTenantStoreDbContext(DbContextOptions<MultiTenantStoreDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.1.100\\SQLEXPRESS;Database=QuickAppMT;Uid=sa;Password=dev;MultipleActiveResultSets=true", b => b.MigrationsAssembly("QuickApp"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
