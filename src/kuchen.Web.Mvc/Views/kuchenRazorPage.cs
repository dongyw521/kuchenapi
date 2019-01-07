using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace kuchen.Web.Views
{
    public abstract class kuchenRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected kuchenRazorPage()
        {
            LocalizationSourceName = kuchenConsts.LocalizationSourceName;
        }
    }
}
