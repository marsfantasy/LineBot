using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineBot.Extensions
{
    public static class ServiceCollections
    {
        public static void AddLineBotSDK(this IServiceCollection services, IConfiguration Configuration)
        {
        }
    }
}
