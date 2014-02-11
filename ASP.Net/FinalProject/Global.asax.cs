using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Data.Entity;
using FinalProject;
using FinalProject.Models;

namespace FinalProject
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer(new HouseDatabaseInitializer());

            // Add Administrator Role
            if (!Roles.RoleExists("Administrator"))
                Roles.CreateRole("Administrator");

            // Add Resident Manager Role
            if (!Roles.RoleExists("ResidentManager"))
                Roles.CreateRole("ResidentManager");

            // Add Resident Role
            if (!Roles.RoleExists("Resident"))
                Roles.CreateRole("Resident");

            // Add Admin User
            if (Membership.GetUser("admin@viki.com") == null)
            {
                Membership.CreateUser("admin@viki.com", "password", "admin@viki.com");
                Roles.AddUserToRole("admin@viki.com", "Administrator");
            }

            // Add Resident Manager User
            if (Membership.GetUser("manager@viki.com") == null)
            {
                Membership.CreateUser("manager@viki.com", "password", "manager@viki.com");
                Roles.AddUserToRole("manager@viki.com", "ResidentManager");
            }
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }
    }
}
