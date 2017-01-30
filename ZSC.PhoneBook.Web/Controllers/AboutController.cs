using System.Web.Mvc;

namespace ZSC.PhoneBook.Web.Controllers
{
    public class AboutController : PhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}