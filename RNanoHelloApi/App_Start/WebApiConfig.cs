﻿using Microsoft.Practices.Unity;
using RNanoHello.Model;
using RNanoHelloApi.App_Start;
using RNanoHelloApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RNanoHelloApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.DependencyResolver = new UnityResolver(UnityConfig.GetConfiguredContainer());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
