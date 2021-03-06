﻿using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

using CfpExchange.Common.Services;
using CfpExchange.Common.Services.Interfaces;

[assembly: FunctionsStartup(typeof(CfpExchange.Functions.Startup))]
namespace CfpExchange.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient();
            builder.Services.AddScoped<ITwitterService, TwitterService>();
        }
    }
}
