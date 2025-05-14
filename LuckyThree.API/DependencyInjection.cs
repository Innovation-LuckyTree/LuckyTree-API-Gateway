namespace LuckyThree.API;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddAppBuilder(this WebApplicationBuilder builder)
    {
        string connString = builder.Configuration.GetConnectionString("AddressDb");

        builder.Services.AddConfiguration(builder.Configuration);

        return builder;
    }
}