using Autofac;
using PlayBall.GroupManagement.Business.Services;
using PlayBall.GroupManagement.Business.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InMemoryGroupsService>().As<IGroupsService>().SingleInstance();
        }
    }
}
