using CourseWork.UI;
using Microsoft.Extensions.DependencyInjection;

namespace CourseWork.BLL.Configuration
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
