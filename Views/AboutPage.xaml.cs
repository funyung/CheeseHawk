using CheeseHawk.ViewModels;

namespace CheeseHawk.Views
{
	public partial class AboutPage : ContentPage
	{
		public AboutPage()
		{
			InitializeComponent();
		}
		private async void LearnMore_Clicked(object sender, EventArgs e)
		{
			if (BindingContext is ViewModels.About about)
				await Launcher.Default.OpenAsync(about.MoreInfoUrl);
		}
	}
}