using API.Repository.Abstract;
using API.Repository.Concrete;
using API.Service.Abstract;
using API.Service.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APICore
{
    public static class IoC
    {
        public static void RegisterIoC(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();

        }
    }
}
