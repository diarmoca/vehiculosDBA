﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VehiculosDBA.Backend.Startup))]
namespace VehiculosDBA.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
