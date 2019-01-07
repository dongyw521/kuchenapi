using Abp.AspNetCore.Mvc.ViewComponents;

namespace kuchen.Web.Views
{
    public abstract class kuchenViewComponent : AbpViewComponent
    {
        protected kuchenViewComponent()
        {
            LocalizationSourceName = kuchenConsts.LocalizationSourceName;
        }
    }
}
