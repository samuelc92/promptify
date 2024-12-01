namespace Promptify.PageModels;

using CommunityToolkit.Mvvm.Input;
using Models;
using System.Collections.Generic;

public partial class PrePromptPageModel(PromptRepository repository) : ObservableObject
{
    [ObservableProperty]
    private string _description = string.Empty;

    [ObservableProperty]
    private string _text = string.Empty;

    [ObservableProperty]
    private List<Prompt> _prompts = [];

    [RelayCommand]
    private async Task Save()
    {
        var prompt = new Prompt
        {
            Description = _description,
            Text = _text
        };

        repository.Add(prompt);
        await Shell.Current.GoToAsync("..");
    }

}
