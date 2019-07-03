using Abp.AutoMapper;
using CAGLAR.Sessions.Dto;

namespace CAGLAR.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}