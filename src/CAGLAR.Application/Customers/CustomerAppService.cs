using Abp.Application.Services;
using Abp.Domain.Repositories;
using CAGLAR.Customers.Dto;
using CAGLAR.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAGLAR.Customers
{
    public class CustomerAppService : AsyncCrudAppService<Customer, CustomerDto>, ICustomerAppService
    {
        public CustomerAppService(IRepository<Customer, int> repository) : base(repository)
        {

        }
    }
}
