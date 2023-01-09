using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Shop.DataAccess
{
    public class AppIdentityDbContextSeeder
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {

            var defaultUser = new ApplicationUser { UserName = "admin@svetlavka.com", Email = "admin@svetlavka.com" };
            if ((await userManager.FindByEmailAsync("admin@svetlavka.com")) == null)
            {
                await userManager.CreateAsync(defaultUser, "Pass1@word");
                var roleName = "Admin";
                await roleManager.CreateAsync(new IdentityRole(roleName));
                await userManager.AddToRoleAsync(defaultUser, roleName);
            }
        }
    }
}
