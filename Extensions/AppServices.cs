using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebItProject.MapperProfiles;
using WebItProject.Services;

namespace WebItProject.Extensions
{
    public static class AppServices
    {
        public static IServiceCollection AddApplicationServices (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(options => 
            {
                options.AddProfile(typeof(AccountProfile));
                options.AddProfile(typeof(PaymentProfile));
                options.AddProfile<SubscriptionProfiles>();
            });

            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped<IPaymentService, IyzicoPaymentService>();

            return services;
        }
    }
}