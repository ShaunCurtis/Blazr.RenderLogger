namespace Blazr.RenderLogger.Server;

public static class RenderStateServerServices
{
    public static void AddRenderStateServerServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddHttpContextAccessor();
        builder.Services.AddScoped<IRenderStateService, ServerRenderStateService>();
    }
}
