using FitnessCenter.Shared;

namespace FitnessCenter.PL.Web.ViewModels
{
    public class SubscriptionsViewModel
    {
        public int SubscriptionId { get; set; }

        public string NameService{ get; set; }

        public string Description { get; set; }

        public bool IsChecked { get; set; }

        public static SubscriptionsViewModel ToModel(
            Subscription subscription,
            bool isChecked)
        {
            var model = new SubscriptionsViewModel
            {
                SubscriptionId = subscription.SubscriptionId,
                NameService = subscription.NameService,
                Description = subscription.Description,
                IsChecked = isChecked
            };

            return model;
        }
    }
}