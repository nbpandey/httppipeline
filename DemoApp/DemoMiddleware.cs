using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DemoApp
{
    public class DemoMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IMesssage _message;

        public DemoMiddleware(RequestDelegate next, IMesssage message)
        {
            _next = next;
            _message = message;
        }
        
        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("\r\nMessage from DemoMiddleware:");
            await context.Response.WriteAsync(_message.Info() + "\r\n");
            await _next(context);
        }
    }
}