using CheeseHawk.Views;
using CommunityToolkit.Mvvm.Input;


namespace CheeseHawk.ViewModels
{
    public partial class StartingPage
    {
		public string Title => AppInfo.Name;

		[RelayCommand]
		async Task GoToAllUsersPageAsync()
		{
			await Shell.Current.GoToAsync(nameof(AllUsersPage));
		}

		[RelayCommand]
		async Task GoToNewUserPageAsync()
		{
			await Shell.Current.GoToAsync(nameof(NewUserPage));
		}
	}
}
