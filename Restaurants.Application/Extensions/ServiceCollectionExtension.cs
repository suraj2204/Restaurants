
using Microsoft.Extensions.DependencyInjection;
using Restaurants.Application.Restaurants;


namespace Restaurants.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(ServiceCollectionExtensions).Assembly;
            //var assembly1 = typeof(ServiceCollectionExtensions1).Assembly;
            services.AddScoped<IRestaurantsService, RestaurantsService>();
            services.AddAutoMapper(assembly);
            
        }
    }
}
