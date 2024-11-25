using Promptify.Models;

namespace Promptify.Services.PrePrompt;

public class PrePromptService : IPrePromptService
{
    public IEnumerable<Prompt> Prompts { get; set; } = [];
}
