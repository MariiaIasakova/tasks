using FitnessCenter.BL.Logic;
using FitnessCenter.PL.Web.ViewModels;
using FitnessCenter.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessCenter.PL.Web.Controllers
{
    public class UserController : Controller
    {
        private ILogic logic;
        public UserController()
        {
            logic = new Logic();
        }

        public ActionResult Index()
        {
            var users = logic.GetUsersViewModel();
            return View();
        }

        public ActionResult Create()
        {
            var model = UsersViewModel.CreateModel(null, logic.GetSubscription());
            return View("UserPage", model);
        }

        public ActionResult Add(UserAndSubscriptionViewModel model)
        {
            if (model.User.UserId > 0)
            {
                logic.UpdateUser(model.User);
            }
            else
            {
                logic.AddUser(model.User);
            }
            return RedirectToAction("Index");
        }


    }
}