using Factory.Themes.Abstractions;

namespace Factory.Themes;

public class LightTheme : ITheme
{
    public string TextColor { get; set; } = "Black";
    
    public string BackgroundColor { get; set; } = "White";
}