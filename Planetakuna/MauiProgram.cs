namespace Planetakuna;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("customfonticons.ttf", "CustomFontIcons");
				fonts.AddFont("Kanit-Light.ttf", "Kanit#300");
				fonts.AddFont("Kanit-Regular.ttf", "Kanit#400");
				fonts.AddFont("Kanit-Medium.ttf", "Kanit#500");
				fonts.AddFont("Kanit-SemiBold.ttf", "Kanit#600");
			});

		return builder.Build();
	}
}
