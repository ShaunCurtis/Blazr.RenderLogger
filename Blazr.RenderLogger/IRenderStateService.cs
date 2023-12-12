namespace Blazr.RenderLogger;

public interface IRenderStateService
{
    public string UidName { get; }
    public string Renderer { get; }
    public bool IsPreRender { get; }
}
