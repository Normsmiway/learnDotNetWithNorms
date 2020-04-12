using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MessageProcessor.Options
{
    public static class Extensions
    {
        public static IServiceCollection AddAppOptions(this IServiceCollection services, IConfiguration configuration)
        {
            var swiftOptions = configuration.GetOptions<StrategyOptions>("Strategies");
            services.AddSingleton(swiftOptions);
            return services;
            //QuerySetting
        }

        public static TModel GetOptions<TModel>(this IConfiguration configuration, string section) where TModel : new()
        {
            var model = new TModel();
            configuration.GetSection(section).Bind(model);

            return model;
        }

    }

   
}
