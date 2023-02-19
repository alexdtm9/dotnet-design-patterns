namespace FactoryPattern.Themes.Abstractions;

public interface ITheme
{
    string TextColor { get; set; }
    
    string BackgroundColor { get; set; }
}