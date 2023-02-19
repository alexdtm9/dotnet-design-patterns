using FactoryPattern.Themes.Abstractions;

namespace FactoryPattern.Themes;

public class LightTheme : ITheme
{
    public string TextColor { get; set; } = "Black";
    
    public string BackgroundColor { get; set; } = "White";
}