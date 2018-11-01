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
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Login = "User",
                        Password = "123",
                    },
                    new User
                    {
                        Login = "Admin",
                        Password = "123",
                    });
                context.SaveChanges();
            }
        }
    }
}
