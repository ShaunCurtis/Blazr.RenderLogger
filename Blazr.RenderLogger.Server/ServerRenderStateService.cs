namespace Blazr.RenderLogger.Server;

public class ServerRenderStateService : IRenderStateService
{
    private IHttpContextAccessor _httpContextAccessor;
    private readonly Guid _uid = Guid.NewGuid();
    private readonly ILogger _logger;

    public bool IsPreRender => !(_httpContextAccessor.HttpContext is not null && _httpContextAccessor.HttpContext.Response.HasStarted);
    public string Renderer => "Server";
    public string UidName => _uid.ToString().Substring(0, 8);
    
    public ServerRenderStateService(IHttpContextAccessor httpContextAccessor, ILogger logger)
    {
        _httpContextAccessor = httpContextAccessor;
        _logger = logger;

        var message = IsPreRender ?
            $"Pre-Render ServerRenderStateService Instance Created with ID: {_uid}"
            : $"ServerRenderStateService Instance Created with ID: {_uid}";

        Console.WriteLine(message);
        _logger.LogDebug(message);
    }
}
