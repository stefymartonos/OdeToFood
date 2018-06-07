using Microsoft.Extensions.FileProviders;
using System.IO;

namespace Microsoft.AspNetCore.Builder
{
    public static class ApplicationBuilderExtensions
    {

        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app,string root)
        {
            var options = new StaticFileOptions();
            options.RequestPath = "/node_modules";

            var path = Path.Combine(root, "node_modules");
            var fileProvider = new PhysicalFileProvider(path);
            options.FileProvider = fileProvider;

            app.UseStaticFiles(options);
            return app;
        }
    }
}
