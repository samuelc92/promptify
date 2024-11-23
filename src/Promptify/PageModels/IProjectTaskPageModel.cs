using CommunityToolkit.Mvvm.Input;
using Promptify.Models;

namespace Promptify.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}