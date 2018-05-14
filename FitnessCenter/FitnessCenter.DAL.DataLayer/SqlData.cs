using FitnessCenter.Shared;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;

namespace FitnessCenter.DAL.DataLayer
{
    public class SqlData : IData
    {
        string connectionString = ConfigurationManager.ConnectionStrings["myconnectionString"].ConnectionString;

        #region User

        public void AddUser(User user)
        {
            var subscriptionIDs = user.Subscriptions.Select(r => r.SubscriptionId).ToList();
            var list = new List<int>();
            DataTable data = new DataTable();
            data.Columns.Add("id", typeof(int));
            foreach (var item in subscriptionIDs)
            {
                data.Rows.Add(item);
            }
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand
                {
                    CommandText = "AddUser",
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.Add("@ids", SqlDbType.Structured);
                command.Parameters["@ids"].TypeName = "intTable";
                command.Parameters["@ids"].Value = data;
                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@birthDate", user.Birthdate);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int userId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand
                {
                    CommandText = "DeleteUser",
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@id", userId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public User GetUserById(int userId)
        {
            var user = new User();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand
                {
                    CommandText = "GetUserById",
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };

                command.Parameters.AddWithValue("@id", userId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ID = reader.GetInt32(0);
                        var firstName = reader.GetString(1);
                        var lastName = reader.GetString(2);
                        var birthdate = reader.GetDateTime(3);
                        user.UserId = userId;
                        user.FirstName = firstName;
                        user.LastName = lastName;
                        user.Birthdate = birthdate;
                    }
                }
            }
            return user;
        }

        public List<User> GetUsers()
        {
            var users = new List<User>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand
                {
                    CommandText = "GetUsers",
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userId = reader.GetInt32(0);
                        var firstName = reader.GetString(1);
                        var lastName = reader.GetString(2);
                        var birthdate = reader.GetDateTime(3);
                        var user = new User
                        {
                            UserId = userId,
                            FirstName = firstName,
                            LastName = lastName,
                            Birthdate = birthdate,
                            Subscriptions = GetSubscriptionsByUserID(userId)
                        };
                        users.Add(user);
                    }
                }
            }
            return users;
        }

        private List<Subscription> GetSubscriptionsByUserID(int userId)
        {
            var subscriptions = new List<Subscription>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand
                {
                    CommandText = "ShowSubscriptionsOfUser",
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@id", userId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var subscriptionID = reader.GetInt32(0);
                        var nameService = reader.GetString(1);
                        var description = reader.GetString(2);
                        var subscription = new Subscription
                        {
                            SubscriptionId = subscriptionID,
                            NameService = nameService,
                            Description = description
                        };
                        subscriptions.Add(subscription);
                    }
                }
            }

            return subscriptions;
        }

        public void UpdateUser(User user)
        {
            var subscriptionsIds = user.Subscriptions.Select(r => r.SubscriptionId).ToList();
            var list = new List<int>();
            DataTable data = new DataTable();
            data.Columns.Add("id", typeof(int));
            foreach (var r in subscriptionsIds)
            {
                data.Rows.Add(r);
            }
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand
                {
                    CommandText = "UpdateUser",
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.Add("@ids", SqlDbType.Structured);
                command.Parameters["@ids"].TypeName = "intTable";
                command.Parameters["@ids"].Value = data;
                command.Parameters.AddWithValue("@id", user.UserId);
                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@birthdate", user.Birthdate);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Subscription

        public void AddSubscription(Subscription subscription)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand
                {
                    CommandText = "AddSubscription",
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };

                command.Parameters.AddWithValue("@nameService", subscription.NameService);
                command.Parameters.AddWithValue("@description", subscription.Description);

                connection.Open();
                var result = command.ExecuteScalar();
                var subscriptionId = result as int?;
                if (subscriptionId.HasValue)
                {
                    subscription.SubscriptionId = subscriptionId.Value;
                }
            }
        }

        public void DeleteSubscription(int subscriptionId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand
                {
                    CommandText = "DeleteSubscription",
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@id", subscriptionId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Subscription> GetSubscription()
        {
            var subscriptions = new List<Subscription>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand
                {
                    CommandText = "GetSubscriptions",
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var subscriptionId = reader.GetInt32(0);
                        var nameService = reader.GetString(1);
                        var description = reader.GetString(2);
                        var subscription = new Subscription
                        {
                            SubscriptionId = subscriptionId,
                            NameService = nameService,
                            Description = description
                        };
                        subscriptions.Add(subscription);
                    }
                }

                return subscriptions;
            }
        }

        public Subscription GetSubscriptionById(int subscriptionId)
        {
            var subscription = new Subscription();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand
                {
                    CommandText = "GetSubscriptionById",
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };

                command.Parameters.AddWithValue("@id", subscriptionId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ID = reader.GetInt32(0);
                        var nameService = reader.GetString(1);
                        var description = reader.GetString(2);
                        subscription.SubscriptionId = subscriptionId;
                        subscription.NameService = nameService;
                        subscription.Description = description;
                    }
                }
            }
            return subscription;
        }

        public void UpdateSubscription(Subscription subscription)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand
                {
                    CommandText = "UpdateSubscription",
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@id", subscription.SubscriptionId);
                command.Parameters.AddWithValue("@nameService", subscription.NameService);
                command.Parameters.AddWithValue("@description", subscription.Description);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        #endregion

    }
}
