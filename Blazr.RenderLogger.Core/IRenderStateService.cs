namespace Blazr.RenderLogger.Core;

public interface IRenderStateService
{
    public string UidName { get; }
    public string Renderer { get; }
    public bool IsPreRender { get; }
}
