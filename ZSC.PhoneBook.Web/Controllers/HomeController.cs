using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ZSC.PhoneBook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}