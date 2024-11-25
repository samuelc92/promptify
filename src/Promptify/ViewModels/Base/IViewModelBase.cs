namespace Promptify.ViewModels.Base;

using CommunityToolkit.Mvvm.Input;
using Services.Navigation;

public interface IViewModelBase : IQueryAttributable
{
    public INavigationService NavigationService { get; }

    public IAsyncRelayCommand InitializeAsyncCommand { get; }

    public bool IsBusy { get; }

    Task InitializeAsync();
}
