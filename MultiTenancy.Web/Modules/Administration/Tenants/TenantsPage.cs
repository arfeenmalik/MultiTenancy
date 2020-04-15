
namespace MultiTenancy.Administration.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.TenantsRow))]
    public class TenantsController : Controller
    {
        [Route("Administration/Tenants")]
        public ActionResult Index()
        {
            return View("~/Modules/Administration/Tenants/TenantsIndex.cshtml");
        }
    }
}