using Abp.Web.Mvc.Controllers;

namespace Salih.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class SalihControllerBase : AbpController
    {
        protected SalihControllerBase()
        {
            LocalizationSourceName = SalihConsts.LocalizationSourceName;
        }
    }
}