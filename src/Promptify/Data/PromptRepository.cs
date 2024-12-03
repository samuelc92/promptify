namespace Promptify.Data;

using Microsoft.Extensions.Logging;
using Models;

public class PromptRepository(ILogger<PromptRepository> logger)
{
    private readonly List<Prompt> _prompts = [];

    public void Add(Prompt prompt)
    {
        var lastPrompt = _prompts.LastOrDefault();
        prompt.Id = lastPrompt is null ? 0 : lastPrompt.Id + 1;
        _prompts.Add(prompt);
        logger.LogInformation("Prompt added {Prompt}", prompt);
    }

    public List<Prompt> GetAll() => _prompts;
}
