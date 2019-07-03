using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAGLAR.Stock
{
    public class Stocks : FullAuditedEntity
    {
        public string Name { get; set; }
    }
}
