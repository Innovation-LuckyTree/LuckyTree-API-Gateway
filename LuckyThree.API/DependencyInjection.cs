namespace LuckyThree.API;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddAppBuilder(this WebApplicationBuilder builder)
    {
        builder.Services.AddConfiguration(builder.Configuration);

        return builder;
    }
}