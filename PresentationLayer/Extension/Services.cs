using BusinessLayer.Services;

namespace PresentationLayer.Extension
{
    public static class Services
    {
        public static void AddMemberService(this IServiceCollection services)
        {
            services.AddScoped<IMemberService, MemberService>();
        }
    }
}
