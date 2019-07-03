using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using CAGLAR.Authorization.Roles;
using CAGLAR.Authorization.Users;
using CAGLAR.MultiTenancy;
using CAGLAR.Sales;
using CAGLAR.Stock;

namespace CAGLAR.EntityFramework
{
    public class CAGLARDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Stocks> Stocks { get; set; }



        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public CAGLARDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in CAGLARDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of CAGLARDbContext since ABP automatically handles it.
         */
        public CAGLARDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public CAGLARDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public CAGLARDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
