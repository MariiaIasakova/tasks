using System;
using System.Collections.Generic;

namespace FitnessCenter.Shared
{
    public class User
    {
        static int i = 0;
        public User()
        {
            Subscriptions = new List<Subscription>();
        }

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public int Age {
            get {
                    int age = 0;
                    if (DateTime.Today.Month < Birthdate.Month)
                    {
                        age = DateTime.Today.Year - Birthdate.Year - 1;
                    }
                    else
                    {
                        age = DateTime.Today.Year - Birthdate.Year;
                    }
                    return age;
                }
        }

        public List<Subscription> Subscriptions { get; set; }

        public void Edit(User user)
        {
            if (user != null)
            {
                FirstName = user.FirstName;
                LastName = user.LastName;
                Birthdate = user.Birthdate;
                Subscriptions = user.Subscriptions;
            }
        }

        public void AddSubscription(List<Subscription> subscriptions)
        {
            if (subscriptions != null)
            {
                this.Subscriptions = subscriptions;
            }
        }

    }
}
