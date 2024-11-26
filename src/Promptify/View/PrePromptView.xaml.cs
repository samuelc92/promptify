namespace Promptify.View;

using ViewModels;

public partial class PrePromptView
{
	public PrePromptView(PrePromptPageModel viewModel)
	{
		BindingContext = viewModel;

		InitializeComponent();
	}
}