﻿/* ***********************************************
 * author:  奔跑的牛排
 * email:   beefsteak@live.cn  
 * ***********************************************/

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Simple.AspNetCore.Seedwork.MvcCore.StartupFilters;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class VirtualPathServiceCollectionExtensions
    {
        public static void AddVirtualPath(this IServiceCollection services, IConfigurationSection configuration)
        {
            services.Configure<VirtualPathOptions>(configuration);
            services.AddTransient<IStartupFilter, VirtualPathStartupFilter>();
        }
    }
}