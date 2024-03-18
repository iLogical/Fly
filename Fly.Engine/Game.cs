using Silk.NET.Maths;
using Silk.NET.Windowing;

namespace Fly.Engine;

public sealed class Game(int width, int height, string title) : IDisposable
{
    private readonly IWindow _window = WindowManager.CreateWindow(width, height, title);

    public void Dispose()
    {
        _window.Dispose();
    }

    public void Run()
    {
        _window.Run();
    }
}

public static class WindowManager
{
    public static IWindow CreateWindow(int width, int height, string title = "")
    {
        var options = WindowOptions.Default;
        options.Size = new Vector2D<int>(width, height);
        options.Title = title;
        options.API = GraphicsAPI.Default;
        return Window.Create(options);
    }
}