using System.Text;
using FactoryPattern.Themes.Abstractions;

namespace FactoryPattern.Themes;

public class TrackingThemeFactory
{
    private readonly List<WeakReference<ITheme>> _themes = new();

    public ITheme CreateTheme(bool darkTheme)
    {
        ITheme theme = darkTheme ? new DarkTheme() : new LightTheme();
        _themes.Add(new WeakReference<ITheme>(theme));
        return theme;
    }

    public string Info
    {
        get
        {
            var sb = new StringBuilder();
            foreach (var weakReference in _themes)
            {
                if (weakReference.TryGetTarget(out var theme))
                {
                    sb.AppendLine(
                        $"Theme: {theme.GetType().Name}, TextColor: {theme.TextColor}, BackgroundColor: {theme.BackgroundColor}");
                }
            }

            return sb.ToString();
        }
    }
}