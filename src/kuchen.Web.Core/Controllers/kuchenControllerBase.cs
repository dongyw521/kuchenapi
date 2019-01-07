using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace kuchen.Controllers
{
    public abstract class kuchenControllerBase: AbpController
    {
        protected kuchenControllerBase()
        {
            LocalizationSourceName = kuchenConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
