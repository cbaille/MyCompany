using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyCompany.Web.Views
{
    public abstract class MyCompanyViewComponent : AbpViewComponent
    {
        protected MyCompanyViewComponent()
        {
            LocalizationSourceName = MyCompanyConsts.LocalizationSourceName;
        }
    }
}
