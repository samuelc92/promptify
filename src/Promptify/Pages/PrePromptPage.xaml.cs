namespace Promptify.Pages;

public partial class PrePromptPage : ContentPage
{
	public PrePromptPage(PrePromptPageModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}
}