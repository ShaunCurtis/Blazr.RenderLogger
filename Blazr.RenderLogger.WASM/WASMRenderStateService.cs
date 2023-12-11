using Microsoft.Extensions.Logging;
using Blazr.RenderLogger.Core;
namespace Blazr.RenderLogger.WASM;

public class WASMRenderStateService : IRenderStateService
{
    private readonly Guid _uid = Guid.NewGuid();
    private readonly ILogger _logger;
    
    public bool IsPreRender => false;
    public string Renderer => "Client";
    public string UidName => _uid.ToString().Substring(0, 8);

    public WASMRenderStateService(ILogger logger )
    {
        _logger = logger;

        var message = $"WASMRenderStateService Instance Created with ID: {_uid}";

        Console.WriteLine(message);
        _logger.LogDebug(message);
    }
}
