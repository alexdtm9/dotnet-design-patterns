using Factory.Themes.Abstractions;

namespace Factory.Themes;

public class DarkTheme : ITheme
{
    public string TextColor { get; set; } = "White";
    
    public string BackgroundColor { get; set; } = "Black";
}