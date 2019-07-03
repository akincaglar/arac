using System.Linq;
using CAGLAR.EntityFramework;
using CAGLAR.MultiTenancy;

namespace CAGLAR.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly CAGLARDbContext _context;

        public DefaultTenantCreator(CAGLARDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
