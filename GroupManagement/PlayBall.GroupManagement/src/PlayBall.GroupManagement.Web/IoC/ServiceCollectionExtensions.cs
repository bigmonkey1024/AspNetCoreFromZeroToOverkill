using Microsoft.Extensions.DependencyInjection;
using PlayBall.GroupManagement.Business.Services;
using PlayBall.GroupManagement.Business.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddSingleton<IGroupsService, InMemoryGroupsService>();
            return services;
        }
    }
}
