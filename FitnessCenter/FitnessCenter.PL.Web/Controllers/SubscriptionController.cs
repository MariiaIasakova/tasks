using FitnessCenter.BL.Logic;
using FitnessCenter.Shared;
using System.Linq;
using System.Web.Mvc;

namespace FitnessCenter.PL.Web.Controllers
{
    public class SubscriptionController : Controller
    {
        private ILogic logic;

        public SubscriptionController()
        {
            logic = new Logic();
        }


        public ActionResult Index(int? columnIndex)
        {
            var posts = logic.GetSubscription();
            if (columnIndex.HasValue)
            {
                posts = logic.GetSubscription().OrderBy(s => s.NameService).ToList();
            }
            return View(posts);
        }

        public ActionResult Create()
        {
            return View("SubscriptionPage");
        }

        public ActionResult Add(Subscription model)
        {
            if (model.SubscriptionId > 0)
            {
                logic.UpdateSubscription(model);
            }
            else
            {
                logic.AddSubscription(model);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            return View("SubscriptionPage", logic.GetSubscription());
        }

        public ActionResult Delete()
        {
            logic.DeleteSubscription(int.Parse(Request.QueryString.GetValues("SubscriptionId")[0]));
            return RedirectToAction("Index");
        }
    }
}