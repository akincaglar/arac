using CAGLAR.EntityFramework;
using EntityFramework.DynamicFilters;

namespace CAGLAR.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly CAGLARDbContext _context;

        public InitialHostDbBuilder(CAGLARDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
