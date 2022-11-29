using CourseWork.BLL.Configuration;
using CourseWork.UI;
using Microsoft.Extensions.DependencyInjection;

namespace CourseWork.UI.Configuration
{
    public static class ConfigureUiServices
    {
        public static IServiceCollection AddUiServices(this IServiceCollection services)
        {
            services.AddBllServices();
            services.AddTransient<MainForm>();
            return services;
        }
    }
}
