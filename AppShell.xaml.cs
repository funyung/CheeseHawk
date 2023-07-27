using CheeseHawk.Views;

namespace CheeseHawk
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			Routing.RegisterRoute(nameof(AllUsersPage), typeof(AllUsersPage));
			Routing.RegisterRoute(nameof(NewUserPage), typeof(NewUserPage));
			Routing.RegisterRoute(nameof(UserContactsPage), typeof(UserContactsPage));
		}
	}
}