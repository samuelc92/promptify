namespace Promptify.PageModels;

using Models;

public partial class PrePromptListPageModel(PromptRepository repository) : ObservableObject
{
    [ObservableProperty]
    private List<Prompt> _prompts = [new Prompt { Text = "Test", Description = "Test"}];

    [RelayCommand]
    private async Task Appearing()
    {
        Prompts = repository.GetAll();
    }

    [RelayCommand]
    Task NavigateToPrePrompt(Prompt prompt)
        => Shell.Current.GoToAsync($"preprompt?id={prompt.Id}");

    [RelayCommand]
    async Task AddPrePrompt()
    {
        await Shell.Current.GoToAsync($"preprompt");
    }
}
