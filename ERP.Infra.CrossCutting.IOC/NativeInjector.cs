using ERP.Application.Interfaces;
using ERP.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ERP.Infra.CrossCutting.IOC
{
    public static class NativeInjector
    {
        public static void RegistrarServicos(IServiceCollection service) 
        {
            service.AddScoped<IUserService, UserService>();
        }
    }
}
