using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Mon",
                    Email = "Mon@test.com",
                    UserName = "Mon@test.com",
                    Address = new Address
                    {
                        FirstName = "Mohamed",
                        LastName = "Ayman",
                        Street = "Ahmed Shawki",
                        City = "Alex",
                        State = "Roushdy",
                        ZipCode = "22222"
                    }
                };

                await userManager.CreateAsync(user,"Pa$$w0rd");
            }
        }
    }
}