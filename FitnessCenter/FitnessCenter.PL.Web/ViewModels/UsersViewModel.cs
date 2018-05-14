using FitnessCenter.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCenter.PL.Web.ViewModels
{
    public class UsersViewModel
    {
        public User User { get; set; }

        public List<SubscriptionsViewModel> AllSubscriptions { get; set; }

        public static UsersViewModel CreateModel(User user, List<Subscription> subscriptions)
        {
            var model = new UsersViewModel
            {
                User = user,
                AllSubscriptions = new List<SubscriptionsViewModel>()
            };
            foreach (var item in subscriptions)
            {
                var isChecked = user == null ? false : user.Subscriptions.Contains(item);
                var subscriptionModel = SubscriptionsViewModel.ToModel(item, isChecked);
                model.AllSubscriptions.Add(subscriptionModel);
            }

            return model;
        }
    }
}