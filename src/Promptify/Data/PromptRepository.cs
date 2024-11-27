namespace Promptify.Data;

using Microsoft.Extensions.Logging;
using Models;

public class PromptRepository(ILogger<PromptRepository> logger)
{
    private readonly List<Prompt> _prompts = [];

    public void Add(Prompt prompt)
    {
        _prompts.Add(prompt);
        logger.LogInformation("Prompt added {Prompt}", prompt);
    }
}
