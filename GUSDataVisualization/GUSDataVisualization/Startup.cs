﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(GUSDataVisualization.Startup))]

namespace GUSDataVisualization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
