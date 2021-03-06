﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlog.Controllers;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var NameSpaces = new[] { typeof(PostsController).Namespace };
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" }, NameSpaces);
            routes.MapRoute("Logout", "logout", new { controller = "Auth", action = "Logout" }, NameSpaces);

            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" }, NameSpaces);
        }
    }
}
