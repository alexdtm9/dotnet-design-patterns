using FactoryPattern.Themes.Abstractions;

namespace FactoryPattern.Themes;

public class ReplaceableThemeFactory
{
    private readonly List<WeakReference<Ref<ITheme>>> _themes = new();

    private static ITheme CreateTheme(bool darkTheme) => darkTheme ? new DarkTheme() : new LightTheme();
    
    public Ref<ITheme> CreateThemeRef(bool darkTheme)
    {
        var themeRef = new Ref<ITheme>(CreateTheme(darkTheme));
        _themes.Add(new WeakReference<Ref<ITheme>>(themeRef));
        return themeRef;
    }
    
    public void ReplaceThemeRef(bool darkTheme)
    {
        foreach (var wv in _themes)
        {
            if (wv.TryGetTarget(out var themeRef))
            {
                themeRef.Value = CreateTheme(darkTheme);
            }
        }
    }
}