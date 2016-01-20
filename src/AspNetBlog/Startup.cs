﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Diagnostics;
using Microsoft.Framework.ConfigurationModel;
namespace AspNetBlog
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            var config = new Configuration();
            config.AddEnvironmentVariables();
            config.AddIniFile("config.ini");

            app.UseErrorHandler("/home/error");

            app.UseMvc(routes => routes.MapRoute(
                "Default", "{controller=Home}/{action=Index}/{id?}"));

            app.UseFileServer();

                
                
        }
    }
}
