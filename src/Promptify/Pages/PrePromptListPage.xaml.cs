namespace Promptify.Pages;

public partial class PrePromptListPage : ContentPage
{
	public PrePromptListPage(PrePromptListPageModel model)
	{
		BindingContext = model;
		InitializeComponent();
	}
}