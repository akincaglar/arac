using Abp.Web.Mvc.Views;

namespace CAGLAR.Web.Views
{
    public abstract class CAGLARWebViewPageBase : CAGLARWebViewPageBase<dynamic>
    {

    }

    public abstract class CAGLARWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CAGLARWebViewPageBase()
        {
            LocalizationSourceName = CAGLARConsts.LocalizationSourceName;
        }
    }
}