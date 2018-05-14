using FitnessCenter.Shared;
using System.Collections.Generic;
using FitnessCenter.DAL.DataLayer;
using System.Linq;

namespace FitnessCenter.BL.Logic
{
    public class Logic : ILogic
    {
        private IData data;

        public Logic()
        {
            data = new SqlData();
        }

        public void AddSubscription(Subscription subscription)
        {
            data.AddSubscription(subscription);
        }

        public void AddUser(User user)
        {
            data.AddUser(user);
        }

        public void DeleteSubscription(int subscriptionId)
        {
            data.DeleteSubscription(subscriptionId);
        }

        public void DeleteUser(int userId)
        {
            data.DeleteUser(userId);
        }

        public List<Subscription> GetSubscription()
        {
            return data.GetSubscription();
        }

        public List<Subscription> GetSubscriptionById(int subscriptionId)
        {
            return data.GetSubscriptionById(subscriptionId);
        }

        public User GetUserById(int userId)
        {
            return data.GetUserById(userId);
        }

        public List<User> GetUsers()
        {
            return data.GetUsers();
        }

        public List<UserViewModel> GetUsersViewModel()

        {
            var users = GetUsers();
            var usersModels = users.Select(u => UserViewModel.ToModel(u));
            return usersModels.ToList();
        }

        public void UpdateSubscription(Subscription subscription)
        {
            if (subscription != null)
            {
                data.UpdateSubscription(subscription);
            }
        }

        public void UpdateUser(User user)
        {
            if (user != null)
            {
                data.UpdateUser(user);
            }
        }
    }
}
