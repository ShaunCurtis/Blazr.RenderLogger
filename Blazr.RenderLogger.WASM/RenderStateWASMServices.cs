using Blazr.RenderLogger.Core;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Blazr.RenderLogger.WASM;

public static class RenderStateWASMServices
{
    public static void AddRenderStateWASMServices(this WebAssemblyHostBuilder builder)
    {
        builder.Services.AddScoped<IRenderStateService, WASMRenderStateService>();
    }
}
