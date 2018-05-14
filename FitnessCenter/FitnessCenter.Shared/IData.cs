using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Shared
{
    public interface IData
    {

        #region User Action

        List<User> GetUsers();

        User GetUserById(int userId);

        void AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int userId);

        #endregion

        #region Subscription Action

        List<Subscription> GetSubscription();

        List<Subscription> GetSubscriptionById(int subscriptionId);

        void AddSubscription(Subscription subscription);

        void UpdateSubscription(Subscription subscription);

        void DeleteSubscription(int subscriptionId);

        #endregion
    }
}
