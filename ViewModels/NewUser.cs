using CheeseHawk.Views;
using CommunityToolkit.Mvvm.Input;

namespace CheeseHawk.ViewModels
{
    public partial class NewUser
    {
		[RelayCommand]
		async Task SaveUserAsync()
		{
			//Database Interaction 

			await Shell.Current.GoToAsync(nameof(UserContactsPage));
		}
	}
}
