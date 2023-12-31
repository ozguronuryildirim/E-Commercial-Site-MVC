using A.ÖzgürOnurYıldırım_E_ticaretSitesiWebUI.Models.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace A.ÖzgürOnurYıldırım_E_ticaretSitesiWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {   

            //Roller
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager =new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" }; ;
                manager.Create(role);
            }

            //user
            if (!context.Users.Any(i => i.Name == "ozguronuryildirim"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user= new ApplicationUser()
                {
                    Name = "ezgi",
                    SurName = "yildirim",
                    UserName = "ezgiyildirim",
                    Email = "ezgiyildirim@gmail.com"
                };

                manager.Create(user,"14531453");
                manager.AddToRole(user.Id,"admin");
                manager.AddToRole(user.Id, "user");
            }
            if (!context.Users.Any(i => i.Name == "ozguronur"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    Name = "ahmet",
                    SurName = "yildirim",
                    UserName = "ahmet",
                    Email = "ahmet.com"
                };

                manager.Create(user, "1234567");
               
                manager.AddToRole(user.Id, "user");
            }

            base.Seed(context);
        }

    }
}