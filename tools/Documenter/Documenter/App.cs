using Microsoft.Extensions.Configuration;

namespace Documenter;

internal static class App
{
	public static IConfiguration Configuration { get; }


	static App()
	{
		IConfigurationBuilder builder = new ConfigurationBuilder()
			.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
			.AddJsonFile(nameof(AppSettings) + ".json")
			.AddCommandLine(Environment.GetCommandLineArgs());
		Configuration = builder.Build();
	}


	public static AppSettings? GetSettings()
	{
		if (Configuration != null)
			return Configuration.GetSection(nameof(AppSettings)).Get<AppSettings>();
		else
			return null;
	}

}
