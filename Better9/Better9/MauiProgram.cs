using Microsoft.Extensions.Logging;

namespace Better9;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				//fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				//fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("BE.otf", "BE");
				fonts.AddFont("BN.ttf", "BN");
				fonts.AddFont("BT.otf", "BT");
				fonts.AddFont("BTL.ttf", "BTL");
				fonts.AddFont("CFF.ttf", "CFF");
				fonts.AddFont("Fondre.ttf", "Fondre");
				fonts.AddFont("OpenSansR.ttf", "OpenSansR");
				fonts.AddFont("OpenSansSB.ttf", "OpenSansSB");
				fonts.AddFont("PKR.ttf", "PKR");
				fonts.AddFont("RDD.ttf", "RDD");
				fonts.AddFont("TW.ttf", "TW");
				fonts.AddFont("UnTH.ttf", "UnTh");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
