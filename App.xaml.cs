using CheeseHawk.Services;
using Microsoft.EntityFrameworkCore;

namespace CheeseHawk
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			CheeseHawkContext context = new CheeseHawkContext();
			DatabaseInitializer startup = new DatabaseInitializer(context);

			startup.InitializeDB();

			MainPage = new AppShell();
		}
	}
}