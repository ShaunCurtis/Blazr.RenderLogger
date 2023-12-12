namespace Blazr.RenderLogger.WASM;

public class WASMRenderStateService : IRenderStateService
{
    private readonly Guid _uid = Guid.NewGuid();

    public bool IsPreRender => false;
    public string Renderer => "Client";
    public string UidName => _uid.ToString().Substring(0, 8);

    public WASMRenderStateService()
    {
        var message = $"WASMRenderStateService Instance Created with ID: {_uid}";

        Console.WriteLine(message);
    }
}
