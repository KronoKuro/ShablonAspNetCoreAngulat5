using Appli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Appli.Models
{
    public class Seed
    {
        public static void Initialize(ApplicationContext context)
        {

            if (!context.Roles.Any())
            {
                context.Roles.AddRange(
                    new Role
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "User",
                    }
                );
                context.Roles.AddRange(
                    new Role
                    {
                        Id = "b44c9bd1-ad78-447a-b498-97cd2e86e7e3",
                        Name = "Admin",
                    }
                );
            }

            if (!context.Users.Any())
            {
                var user = context.Roles.FirstOrDefault(u => u.Name == "User");
                var admin = context.Roles.FirstOrDefault(a => a.Name == "Admin");
                context.Users.AddRange(
                    new User
                    {
                        Id = Guid.NewGuid().ToString(),
                        Login = "User",
                        Password = "7Rbtv04wQNxgyhu4OpD7MQ==",
                        RoleId = string.IsNullOrEmpty(user.Id) ? null : user.Id
                    }
                );
                context.Users.AddRange(
                    new User
                    {
                        Id = Guid.NewGuid().ToString(),
                        Login = "Admin",
                        Password = "o6dRJbVxag8bW3NhXG5K7g==",
                        RoleId = string.IsNullOrEmpty(admin.Id) ? null : admin.Id
                    }
                );
            }
        }
    }
}
