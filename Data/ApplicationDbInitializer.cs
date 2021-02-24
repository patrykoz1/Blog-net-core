using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data
{
    public static class ApplicationDbInitializer
    {
        public static async void SeedUsers(UserManager<IdentityUser> userManager,RoleManager<IdentityRole> roleManager)
        {

            /*if (roleManager.FindByNameAsync("Admin").Result== null)
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }*/

            if ((userManager.FindByEmailAsync("email@email.com").Result) == null)
            { var hasher = new PasswordHasher<IdentityUser>();

                IdentityUser user = new IdentityUser
                {
                    UserName = "email@email.com",
                    Email = "email@email.com",
                    //Id = "1",               
                    NormalizedUserName = "email@email.com".ToUpper(),             
                    NormalizedEmail = "email@email.com".ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = string.Empty,
                    
                };
                //user.PasswordHash = hasher.HashPassword(user, "pA2ssword!123");


                var result = userManager.CreateAsync(user).Result;

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, "pA2ssword!123");
                    userManager.AddToRoleAsync(user, "Admin").Wait();

                }
                else
                {
                    throw new ArgumentException("Something went wrong with user seeding!");
                }
            }
        }
    }
}

namespace Your.Namespace
{
    public static class ApplicationDbInitializer
    {
        public static async void SeedUsers(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {

         
            if ((userManager.FindByEmailAsync("john@doe.com").Result) == null)
            {
                var hasher = new PasswordHasher<IdentityUser>();

                IdentityUser user = new IdentityUser
                {
                    UserName = "name",
                    Email = "john@doe.com",               
                    NormalizedUserName = "name".ToUpper(),
                    NormalizedEmail = "john@doe.com".ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = string.Empty,

                };
              


                var result = userManager.CreateAsync(user).Result;

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, "password_here");
                    userManager.AddToRoleAsync(user, "Admin_or_other_role_here").Wait();

                }
                else
                {
                    throw new ArgumentException("Something went wrong with user seeding!");
                }
            }
        }
    }
}
