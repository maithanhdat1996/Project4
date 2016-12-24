using Microsoft.AspNet.SignalR;
using SocialFashion.Model.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SocialFashion.Web
{
    public class NotificationComponent
    {
        public  void RegisterNotification()
        {
            

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(@"SELECT [NotificationId], [OwnerId], [RecieverId], [Type] FROM Notifications", connection))
                {
                    // Make sure the command object does not already have
                    // a notification object associated with it.
                    command.Notification = null;
                    SqlDependency.Start(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                    SqlDependency dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(SqlDep_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    using (var reader = command.ExecuteReader())
                    {

                    }
                        



                }
            }
        }

        private void SqlDep_OnChange(object sender, SqlNotificationEventArgs e)
        {
            
                SqlDependency sqlDep = sender as SqlDependency;
                sqlDep.OnChange -= SqlDep_OnChange;
                NotificationHub.Show();
                RegisterNotification();

            
        }

        public List<Notification> GetNotification()
        {
            using (SocialFashionDbContext db = new SocialFashionDbContext())
            {
                return db.Notifications.OrderByDescending(x => x.AddedOn).ToList();
            }
        }

        public int GetCountNotification()
        {
            using (SocialFashionDbContext db = new SocialFashionDbContext())
            {
                return db.Notifications.Count();
            }
        }
    }
}