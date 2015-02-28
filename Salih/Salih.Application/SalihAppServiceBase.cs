using Abp.Application.Services;

namespace Salih
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SalihAppServiceBase : ApplicationService
    {
        protected SalihAppServiceBase()
        {
            LocalizationSourceName = SalihConsts.LocalizationSourceName;
        }
    }
}