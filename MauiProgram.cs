using CheeseHawk.ViewModels;
using CheeseHawk.Views;
using Microsoft.Extensions.Logging;

namespace CheeseHawk
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif
			builder.Services.AddSingleton<MainPage>();
			builder.Services.AddSingleton<StartingPage>();

			builder.Services.AddTransient<AllUsersPage>();

			return builder.Build();
		}
	}
}