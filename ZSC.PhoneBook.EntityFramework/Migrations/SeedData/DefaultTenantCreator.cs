using System.Linq;
using ZSC.PhoneBook.EntityFramework;
using ZSC.PhoneBook.MultiTenancy;

namespace ZSC.PhoneBook.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly PhoneBookDbContext _context;

        public DefaultTenantCreator(PhoneBookDbContext context)
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
