using Microsoft.AspNetCore.Builder;

namespace DemoApp
{
    public static class DemoMiddlewareExtensions
    {
        public static void UseDemoMiddleware(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<DemoMiddleware>();
        }
    }
}
