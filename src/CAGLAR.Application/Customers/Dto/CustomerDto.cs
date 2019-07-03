using Abp.AutoMapper;
using CAGLAR.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAGLAR.Customers.Dto
{
    [AutoMapFrom(typeof(Customer))]
    public class CustomerDto : Abp.Application.Services.Dto.FullAuditedEntityDto
    {
        public String Name { get; set; }
    }
}
