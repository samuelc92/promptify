namespace Promptify.Services.PrePrompt;

using Models;

public interface IPrePromptService
{
    IEnumerable<Prompt> Prompts { get; set; }
}
