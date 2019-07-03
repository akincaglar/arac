using Abp.Domain.Entities.Auditing;
using CAGLAR.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAGLAR.Sales
{
    public class Customer : FullAuditedEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
