namespace Api.Extensions;

public static class Extensions
{
    public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddPresentationLayer();

        return builder;
    }
}