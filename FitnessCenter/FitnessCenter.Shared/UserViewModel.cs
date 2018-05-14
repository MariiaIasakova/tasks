using System;
using System.Linq;

namespace FitnessCenter.Shared
{
    public class UserViewModel
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public int Age { get; set; }

        public string Subscription { get; set; }

        public static UserViewModel ToModel(User user)
        {
            var model = new UserViewModel
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Age = user.Age,
                Birthdate = user.Birthdate,
                Subscription = string.Join(", ", user.Subscriptions.Select(s => s.NameService))
            };

            return model;
        }

        public User GetUser()
        {
            User user = new User
            {
                UserId = UserId,
                FirstName = FirstName,
                LastName = LastName,
                Birthdate = Birthdate
            };

            return user;
        }
    }
}
