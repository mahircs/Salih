using Abp.Web.Mvc.Views;

namespace Salih.Web.Views
{
    public abstract class SalihWebViewPageBase : SalihWebViewPageBase<dynamic>
    {

    }

    public abstract class SalihWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SalihWebViewPageBase()
        {
            LocalizationSourceName = SalihConsts.LocalizationSourceName;
        }
    }
}