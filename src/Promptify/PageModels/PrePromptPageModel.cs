namespace Promptify.PageModels;

using CommunityToolkit.Mvvm.ComponentModel;
using Models;

public partial class PrePromptPageModel : ObservableObject
{
    [ObservableProperty]
    private List<Prompt> _prompts = [];
}
