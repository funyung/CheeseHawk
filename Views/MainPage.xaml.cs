using CheeseHawk.ViewModels;

namespace CheeseHawk.Views;

public partial class MainPage : ContentPage
{
	public MainPage(StartingPage viewmodel)
	{
		InitializeComponent();
		BindingContext = viewmodel;
	}
}

