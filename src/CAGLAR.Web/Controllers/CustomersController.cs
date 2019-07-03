using Abp.Application.Services.Dto;
using Abp.Web.Mvc.Authorization;
using Abp.Web.Mvc.Views;
using CAGLAR.Authorization;
using CAGLAR.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CAGLAR.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class CustomersController : CAGLARControllerBase
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomersController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _customerAppService.GetAll(new PagedAndSortedResultRequestDto { MaxResultCount = int.MaxValue }); //Paging not implemented yet1
            return View(output);
        }

        public async Task<ActionResult> EditCustomerModal(int customerId)
        {
            var customerDto = await _customerAppService.Get(new EntityDto(customerId));
            return View("_EditTenantsModal", customerDto);
        }
    }
}