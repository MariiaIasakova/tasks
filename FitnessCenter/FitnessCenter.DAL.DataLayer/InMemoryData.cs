using FitnessCenter.Shared;
using System.Collections.Generic;
using System.Linq;

namespace FitnessCenter.DAL.DataLayer
{
    public class InMemoryData : IData
    {
        private List<User> users;

        private List<Subscription> subscriptions;

        public InMemoryData()
        {
            users = new List<User>();
            subscriptions = new List<Subscription>();
        }

        public void AddSubscription(Subscription subscription)
        {
            var maxId = 0;
            var ids = subscriptions.Select(u => u.SubscriptionId);
            if (ids.Count() != 0)
            {
                maxId = ids.Max();
            }

            subscription.SubscriptionId = maxId + 1;
            subscriptions.Add(subscription);
        }

        public void AddUser(User user)
        {
            var maxId = 0;
            var ids = users.Select(u => u.UserId);
            if (ids.Count() != 0)
            {
                maxId = ids.Max();
            }

            user.UserId = maxId + 1;
            users.Add(user);
        }

        public void DeleteSubscription(int subscriptionId)
        {
            var tempReward = subscriptions.Find(s => s.SubscriptionId == subscriptionId);
            foreach (var user in users)
            {
                if (user.Subscriptions != null)
                {
                    if (user.Subscriptions.Contains(tempReward))
                    {
                        user.Subscriptions.Remove(tempReward);
                    }
                }
            }
            subscriptions.Remove(tempReward);
        }

        public void DeleteUser(int userId)
        {
            var tempUser = users.Find(u => u.UserId == userId);
            users.Remove(tempUser);
        }

        public List<Subscription> GetSubscription()
        {
            return subscriptions;
        }

        public Subscription GetSubscriptionById(int subscriptionId)
        {
            return subscriptions.Find(s => s.SubscriptionId == subscriptionId);
        }

        public User GetUserById(int userId)
        {
            return users.Find(u => u.UserId == userId);
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void UpdateSubscription(Subscription subscription)
        {
            var tempReward = subscriptions.Find(r => r.NameService == subscription.NameService);
            tempReward.NameService = subscription.NameService;
            tempReward.Description = subscription.Description;
        }

        public void UpdateUser(User user)
        {
            if (user != null)
            {
                var tempUser = users.Find(u => u.UserId == user.UserId);
                tempUser.FirstName = user.FirstName;
                tempUser.LastName = user.LastName;
                tempUser.Birthdate = user.Birthdate;
                tempUser.Subscriptions = user.Subscriptions;
            }
        }
    }
}

