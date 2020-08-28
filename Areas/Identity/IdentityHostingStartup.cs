using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WelTecEventSystem.Areas.Identity.Data;
using WelTecEventSystem.Data;

[assembly: HostingStartup(typeof(WelTecEventSystem.Areas.Identity.IdentityHostingStartup))]
namespace WelTecEventSystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WelTecEventSystemContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LoginConnection")));

                services.AddDefaultIdentity<WelTecEventSystemUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<WelTecEventSystemContext>();
            });
        }
    }
}