﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RaspPi3.WebApi.Startup))]

namespace RaspPi3.WebApi
{
    public partial class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
