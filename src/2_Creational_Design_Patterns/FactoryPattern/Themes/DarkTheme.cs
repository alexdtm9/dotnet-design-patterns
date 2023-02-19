using FactoryPattern.Themes.Abstractions;

namespace FactoryPattern.Themes;

public class DarkTheme : ITheme
{
    public string TextColor { get; set; } = "White";
    
    public string BackgroundColor { get; set; } = "Black";
}