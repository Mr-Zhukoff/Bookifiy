using Bookify.Application.Abstractions.Behaviors;
using Bookify.Domain.Bookings;
using Microsoft.Extensions.DependencyInjection;

namespace Bookify.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(conf =>
        {
            conf.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);

            conf.AddOpenBehavior(typeof(LoggingBehavior<,>));

            conf.AddOpenBehavior(typeof(ValidationBehavior<,>));

            conf.AddOpenBehavior(typeof(QueryCachingBehavior<,>));
        });

        services.AddTransient<PricingService>();

        return services;
    }
}
