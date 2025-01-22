namespace api_hotelaria.Config;

public static class GerenciadorServicos
{
    public static void GerenciadorDeServicos(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
}
