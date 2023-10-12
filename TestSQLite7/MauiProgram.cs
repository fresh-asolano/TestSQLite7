using Microsoft.Extensions.Logging;
using TestSQLite7.Base;
using TestSQLite7.ViewModel;

namespace TestSQLite7;

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

		builder.Services.AddTransient<MainPage>()
			.AddTransient<BookViewModel>();

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "test.db3");

        builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<SQLiteAsyncClient>(s, dbPath));

		return builder.Build();
	}
}