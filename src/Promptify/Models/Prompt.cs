namespace Promptify.Models;

public class Prompt : BindableObject
{
    public string Description{ get; set; } = string.Empty;

    public string Text { get; set; } = string.Empty;
}
