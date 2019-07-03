using Abp.Application.Services;
using CAGLAR.Customers.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAGLAR.Customers
{
    public interface ICustomerAppService : IAsyncCrudAppService<CustomerDto>
    {
    }
}
