using System.Web.Mvc;

namespace StudyingApplication.Controllers
{
  public class HomeController : Controller
  {
    //
    // GET: /Home/

    public ActionResult Index()
    {
      var model = new TestTagBuilder("div");

      return View(model);
    }
  }
}
