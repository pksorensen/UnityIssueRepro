using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Unity;
using Unity.Builder;
using Unity.Builder.Strategy;
using Unity.Container;
using Unity.Extension;
using Unity.Microsoft.DependencyInjection;
using Unity.ObjectBuilder.BuildPlan.DynamicMethod;
using Unity.Policy;
using Unity.Registration;
using Unity.Storage;

namespace WebApplication10
{
   
 
    public class Program
    {
        static IUnityContainer container = new UnityContainer();
        public static void Main(string[] args)
        {
           

       

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
             .UseUnityServiceProvider()
                .UseStartup<Startup>()
                .Build();
    }
}
